using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pharmacy.Codes;

namespace Pharmacy.Forms
{
    public partial class UserPermission : DevExpress.XtraEditors.XtraForm
    {
        public UserPermission()
        {
            InitializeComponent();
        }

        private void UserPermission_Load(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT A.Firstname,A.GroupName,A.UserID,A.ModuleID,A.ModuleName, "
                + " ISNULL(B.Permission,0)Permission, CASE WHEN B.Permission IS NULL THEN 'Added' ELSE 'UnChanged' END as Status FROM "
                + " (SELECT tUsers.*, tModule.ModuleID,tModule.ModuleName,Z.GroupName FROM tUsers ,tModule "
                + " LEFT JOIN tModuleGroup Z ON(Z.GroupID=tModule.GroupID)) A  "
                + " LEFT JOIN tUserPermission B ON(A.UserID=B.UserID and A.ModuleID=B.ModuleID) "
                + " WHERE A.UserID<>1", "UserPermission");
            gridUserPermission.DataSource = DBRes.DS.Tables["UserPermission"];

            gridViewUserPermission.BeginSort();
            try
            {
                gridViewUserPermission.ClearGrouping();
                gridViewUserPermission.Columns["Firstname"].GroupIndex = 0;
                gridViewUserPermission.Columns["GroupName"].GroupIndex = 1;
            }
            finally
            {
                gridViewUserPermission.EndSort();
            }
        }

        private void UserPermission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void gridViewUserPermission_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Status") return;
            if (gridViewUserPermission.GetFocusedRowCellValue("Status").ToString() != "Added")
                gridViewUserPermission.SetFocusedRowCellValue("Status", "Modified");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridUserPermission.DataSource as DataTable).Copy());
            DBRes.DS.Dispose();
            DBRes.ParameterList.Clear();
            System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
            DBRes.sql_cmd.Parameters.Add(parameter);
            if (DBRes._ParamProcedure("mUserPermission_Pro", CommandType.StoredProcedure))
                XtraMessageBox.Show("Хэвлэгчийн мэдээлэл амжилттай хадгалагдлаа.", "Хэвлэгч", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UserPermission_Load(sender, e);
        }

    }
}