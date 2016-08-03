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
    public partial class UserGroup : DevExpress.XtraEditors.XtraForm
    {
        public UserGroup()
        {
            InitializeComponent();
        }

        private void UserGroup_Load(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT *,'UnChanged'AS Status FROM tUserGroup", "UserGroup");
            gridUserGroup.DataSource = DBRes.DS.Tables["UserGroup"];
        }

        private void UserGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void gridViewUserGroup_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Status") return;
            if (gridViewUserGroup.GetFocusedRowCellValue("Status").ToString() == "UnChanged")
                gridViewUserGroup.SetFocusedRowCellValue("Status", "Modified");
            else gridViewUserGroup.SetFocusedRowCellValue("Status", "Added");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridUserGroup.DataSource as DataTable).Copy());
            DBRes.DS.Dispose();
            System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
            DBRes.sql_cmd.Parameters.Add(parameter);
            if (DBRes._ParamProcedure("mUserGroup_Pro", CommandType.StoredProcedure))
                XtraMessageBox.Show("Хэрэглэгчийн бүлэг амжилттай хадгалагдлаа.", "Хэрэглэгчийн бүлэг", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UserGroup_Load(sender, e);
        }
    }
}