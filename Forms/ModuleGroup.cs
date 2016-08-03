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
    public partial class ModuleGroup : DevExpress.XtraEditors.XtraForm
    {
        public ModuleGroup()
        {
            InitializeComponent();
        }

        private void ModuleGroup_Load(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT GroupID,GroupName,'UnChanged'AS Status FROM tModuleGroup", "ModuleGroup");
            gridModuleGroup.DataSource = DBRes.DS.Tables["ModuleGroup"];
        }

        private void ModuleGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void gridViewModuleGroup_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Status") return;
            if (gridViewModuleGroup.GetFocusedRowCellValue("Status").ToString() == "UnChanged")
                gridViewModuleGroup.SetFocusedRowCellValue("Status", "Modified");
            else gridViewModuleGroup.SetFocusedRowCellValue("Status", "Added");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridModuleGroup.DataSource as DataTable).Copy());
            DBRes.DS.Dispose();
            System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
            DBRes.sql_cmd.Parameters.Add(parameter);
            if (DBRes._ParamProcedure("mModuleGroup_Pro", CommandType.StoredProcedure))
                XtraMessageBox.Show("Модулын бүлэг амжилттай хадгалагдлаа.", "Модулын бүлэг", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ModuleGroup_Load(sender, e);
        }
    }
}