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
    public partial class Module : DevExpress.XtraEditors.XtraForm
    {
        public Module()
        {
            InitializeComponent();
        }

        private void Module_Load(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT ModuleID,ModuleName,GroupID,'UnChanged'AS Status FROM tModule", "Module");
            gridModule.DataSource = DBRes.DS.Tables["Module"];

            DBRes._FillTable("SELECT * FROM tModuleGroup", "ModuleGroup");
            repositoryItemLookModuleGroup.DataSource = DBRes.DS.Tables["ModuleGroup"];
            repositoryItemLookModuleGroup.ValueMember = "GroupID";
            repositoryItemLookModuleGroup.DisplayMember = "GroupName";
        }

        private void Module_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void gridViewModule_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Status") return;
            if (gridViewModule.GetFocusedRowCellValue("Status").ToString() == "UnChanged")
                gridViewModule.SetFocusedRowCellValue("Status", "Modified");
            else gridViewModule.SetFocusedRowCellValue("Status", "Added");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridModule.DataSource as DataTable).Copy());
            DBRes.DS.Dispose();
            System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
            DBRes.sql_cmd.Parameters.Add(parameter);
            if (DBRes._ParamProcedure("mModule_Pro", CommandType.StoredProcedure))
                XtraMessageBox.Show("Модуль амжилттай хадгалагдлаа.","Модуль",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Module_Load(sender, e);
        }
    }
}