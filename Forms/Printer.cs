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
    public partial class Printer : DevExpress.XtraEditors.XtraForm
    {
        public Printer()
        {
            InitializeComponent();
        }

        private void Printer_Load(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT *,'UnChanged'AS Status FROM tPrinter", "Printer");
            gridPrinter.DataSource = DBRes.DS.Tables["Printer"];
        }

        private void gridViewPrinter_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Status") return;
            if (gridViewPrinter.GetFocusedRowCellValue("Status").ToString() == "UnChanged")
                gridViewPrinter.SetFocusedRowCellValue("Status", "Modified");
            else gridViewPrinter.SetFocusedRowCellValue("Status", "Added");
        }

        private void Printer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridPrinter.DataSource as DataTable).Copy());
            DBRes.DS.Dispose();
            System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
            DBRes.sql_cmd.Parameters.Add(parameter);
            if (DBRes._ParamProcedure("mPrinter_Pro", CommandType.StoredProcedure))
                XtraMessageBox.Show("Хэвлэгчийн мэдээлэл амжилттай хадгалагдлаа.", "Хэвлэгч", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Printer_Load(sender, e);
        }
    }
}