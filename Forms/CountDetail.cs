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
    public partial class CountDetail : DevExpress.XtraEditors.XtraForm
    {
        public int CountInvoiceID;
        public CountDetail()
        {
            InitializeComponent();
        }

        private void CountDetail_Load(object sender, EventArgs e)
        {
            CountInvoiceID = DBRes.CountInvoiceID;
            this.Text = this.Text + DBRes.CountDetailText;
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY B.Name) AS RowNum, "
                + " A.*,B.Name,B.BaarCode,B.Size,B.Package,B.Price,0 AS Status,(B.Price*A.Balance)UTotal,(ISNULL(Count,0)*B.Price)TTotal, "
                + " CASE WHEN A.Zoroo > 0 THEN B.Price*A.Zoroo ELSE 0 END IluuTotal, "
                + " CASE WHEN A.Zoroo > 0 THEN 0 ELSE (B.Price*A.Zoroo)*-1 END DutuuTotal FROM tCountDetail A "
                + " INNER JOIN tDrug B WITH(NOLOCK) ON(B.DrugID=A.DrugID) WHERE CountInvoiceID=" + CountInvoiceID, "CountDetail");
            gridCountDetail.DataSource = DBRes.DS.Tables["CountDetail"];
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(52)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridCountDetail.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridCountDetail.ShowPrintPreview();
        }

        private void gridViewCountDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Status") return;
            if (e.Column.FieldName == "Zoroo") return;
            if (e.Column.FieldName == "TTotal") return;
            if (e.Column.FieldName == "IluuTotal") return;
            if (e.Column.FieldName == "DutuuTotal") return;
            gridViewCountDetail.SetFocusedRowCellValue("Status", -2);
            gridViewCountDetail.SetFocusedRowCellValue("Zoroo", (Convert.ToDecimal(gridViewCountDetail.GetFocusedRowCellValue("Balance")) - Convert.ToDecimal(gridViewCountDetail.GetFocusedRowCellValue("Count"))) * -1);
            gridViewCountDetail.SetFocusedRowCellValue("TTotal", Convert.ToDecimal(gridViewCountDetail.GetFocusedRowCellValue("Price")) * Convert.ToDecimal(gridViewCountDetail.GetFocusedRowCellValue("Count")));
            if (Convert.ToDecimal(gridViewCountDetail.GetFocusedRowCellValue("Zoroo")) > 0)
            {
                gridViewCountDetail.SetFocusedRowCellValue("IluuTotal", Convert.ToDecimal(gridViewCountDetail.GetFocusedRowCellValue("Zoroo")) * Convert.ToDecimal(gridViewCountDetail.GetFocusedRowCellValue("Price")));
                gridViewCountDetail.SetFocusedRowCellValue("DutuuTotal", 0);
            }
            else
            {
                gridViewCountDetail.SetFocusedRowCellValue("DutuuTotal", Convert.ToDecimal(gridViewCountDetail.GetFocusedRowCellValue("Zoroo")) * Convert.ToDecimal(gridViewCountDetail.GetFocusedRowCellValue("Price")));
                gridViewCountDetail.SetFocusedRowCellValue("IluuTotal", 0);
            }
        }

        private void CountDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._countdetail = null;
            DataSet ds = new DataSet();
            ds.Tables.Add((gridCountDetail.DataSource as DataTable).Copy());
            bool isSave = false;
            for (int i = 0; i < ds.Tables["CountDetail"].Rows.Count; i++)
            {
                if (Convert.ToInt16(ds.Tables["CountDetail"].Rows[i]["Status"]) == -2)
                {
                    isSave = true;
                    i = DBRes.DS.Tables["CountDetail"].Rows.Count + 1;
                }
            }
            if (isSave)
            {
                DialogResult diares = XtraMessageBox.Show("Тооллогын цонхонд орсон өөрчлөлтийг хадгалах уу?", "Хадгалах", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (diares == DialogResult.Yes)
                {
                    e.Cancel = false;

                    String[] spPName = new String[] { "CountInvoiceID" };
                    SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                    Object[] spPValue = new Object[] { CountInvoiceID };
                    if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                    System.Data.SqlClient.SqlParameter xml = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
                    DBRes.sql_cmd.Parameters.Add(xml);
                    DBRes._ParamProcedure("mCountCreate_Pro", CommandType.StoredProcedure);
                    this.DialogResult = DialogResult.OK;
                }
                else if (diares == DialogResult.Cancel)
                { e.Cancel = true; }
                else { e.Cancel = false; this.DialogResult = DialogResult.OK; }
            }
        }

        private void CountDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.F12)
            {
                DialogResult diares = XtraMessageBox.Show("Тооллогын цонхонд орсон өөрчлөлтийг хадгалах уу?", "Хадгалах", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (diares == DialogResult.Yes)
                {
                    btnPrintPreview.Focus();
                    DataSet ds = new DataSet();
                    ds.Tables.Add((gridCountDetail.DataSource as DataTable).Copy());
                    String[] spPName = new String[] { "CountInvoiceID" };
                    SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                    Object[] spPValue = new Object[] { CountInvoiceID };
                    if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                    System.Data.SqlClient.SqlParameter xml = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
                    DBRes.sql_cmd.Parameters.Add(xml);
                    DBRes._ParamProcedure("mCountCreate_Pro", CommandType.StoredProcedure);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult diares = XtraMessageBox.Show("Тооллогын цонхонд орсон өөрчлөлтийг хадгалах уу?", "Хадгалах", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (diares == DialogResult.Yes)
            {
                btnPrintPreview.Focus();
                DataSet ds = new DataSet();
                ds.Tables.Add((gridCountDetail.DataSource as DataTable).Copy());
                String[] spPName = new String[] { "CountInvoiceID" };
                SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                Object[] spPValue = new Object[] { CountInvoiceID };
                if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                System.Data.SqlClient.SqlParameter xml = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
                DBRes.sql_cmd.Parameters.Add(xml);
                DBRes._ParamProcedure("mCountCreate_Pro", CommandType.StoredProcedure);
            }
        }

    }
}