using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pharmacy.Codes;
using DevExpress.XtraPrinting.Preview;

namespace Pharmacy.Forms
{
    public partial class SaleInvoiceList : DevExpress.XtraEditors.XtraForm
    {
        public SaleInvoiceList()
        {
            InitializeComponent();
        }

        private void SaleInvoiceList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void SaleInvoiceList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._saleinvoicelist = null;
        }

        private void SaleInvoiceList_Load(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkAccountingPeriod(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"))) return;
            string startDate = PharmacyFun._startDateAccountPeriod();
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY ActionDate ASC) AS RowNum,* FROM tSaleInvoice "
                + " WHERE ActionDate>='" + startDate + "' AND ActionDate<='" + DateTime.Now + "' AND Status=3", "SaleInvoice");
            gridSaleInvoice.DataSource = DBRes.DS.Tables["SaleInvoice"];

            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY B.Name ASC) AS RowNum, "
                + " A.*,(B.Name+' '+ ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSizePackage FROM tSaleDetail A "
                + " INNER JOIN tDrug B ON(B.DrugID=A.DrugID) INNER JOIN tSaleInvoice C ON(C.SaleInvoiceID=A.SaleInvoiceID)"
                + " WHERE A.ActionDate>='" + startDate + "' AND A.ActionDate<='" + DateTime.Now + "' AND C.Status=3", "SaleDetail");
            gridSaleDetail.DataSource = DBRes.DS.Tables["SaleDetail"];
        }

        private int RowID()
        {
            int rowId = 0;
            if (gridViewSaleInvoice == null && gridViewSaleInvoice.SelectedRowsCount == 0) return 0;
            DataRow[] rows = new DataRow[gridViewSaleInvoice.SelectedRowsCount];
            for (int i = 0; i < gridViewSaleInvoice.SelectedRowsCount; i++)
            {
                rows[i] = gridViewSaleInvoice.GetDataRow(gridViewSaleInvoice.GetSelectedRows()[i]);
            }
            foreach (DataRow row in rows)
            {
                if (row == null) return 0;
                rowId = Convert.ToInt32(row["SaleInvoiceID"].ToString());
            }
            return rowId;
        }

        private void gridSaleInvoice_DoubleClick(object sender, EventArgs e)
        {
            int rowId = RowID();
            if (rowId != 0)
            {
                DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY B.Name ASC) AS RowNum, "
                + " A.*,(B.Name+' '+ ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSizePackage FROM tSaleDetail A "
                + " INNER JOIN tDrug B ON(B.DrugID=A.DrugID) INNER JOIN tSaleInvoice C ON(C.SaleInvoiceID=A.SaleInvoiceID) "
                + " WHERE A.SaleInvoiceID=" + rowId, "SaleDetail");
                gridSaleDetail.DataSource = DBRes.DS.Tables["SaleDetail"];
            }
        }

        private void barInvoiceDetail_Click(object sender, EventArgs e)
        {
            gridSaleInvoice_DoubleClick(sender, e);
        }

        private void barInvoiceEdit_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(85)) return;
            this.DialogResult = DialogResult.OK;
        }

        private void barInvoicePrint_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(87)) return;
            int rowid = RowID();
            if (rowid != 0)
            {
                DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");

                Reports.rBuyInvoice RB = new Reports.rBuyInvoice();
                DBRes._FillTable("SELECT A.*,B.Firstname FROM tSaleInvoice A "
                    + " INNER JOIN tUsers B ON(B.UserID=A.UserID) "
                    + " WHERE A.SaleInvoiceID=" + rowid, "SaleInvoice");

                RB.xrPadanName.Text = "ЗАРЛАГЫН ПАДАН";

                RB.xrUser.Text = "Зарлагадсан ажилтан : " + DBRes.DS.Tables["SaleInvoice"].Rows[0]["Firstname"].ToString();
                RB.xrPadanNum.Text = RB.xrPadanNum.Text + " : " + DBRes.DS.Tables["SaleInvoice"].Rows[0]["SaleInvoiceNum"].ToString();
                RB.xrDate.Text = "Зарлагадсан огноо : " + Convert.ToDateTime(DBRes.DS.Tables["SaleInvoice"].Rows[0]["ActionDate"]).ToString("yyyy-MM-dd hh:mm:ss");

                RB.xrPadanType.Text = "/ зарах үнээр /";

                RB.xrSupplier.Text = "Эмийн сан : " + DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                RB.xrPadanNumSal.Text = RB.xrPadanNumSal.Text + " : " + DBRes.DS.Tables["SaleInvoice"].Rows[0]["SaleInvoiceNum"].ToString();
                RB.xrDateSale.Text = RB.xrDateSale.Text + " : " + Convert.ToDateTime(DBRes.DS.Tables["SaleInvoice"].Rows[0]["ActionDate"]).ToString("yyyy-MM-dd");

                RB.xrName.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                RB.xrRegion.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Region"].ToString();

                DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.SaleDetailID ASC) AS RowNum, "
                    + " A.SaleDetailID,A.Count,A.Price,(A.Count * A.Price)SumPrice, "
                    + " A.ActionDate,A.Price,A.SaleInvoiceID,A.DrugID "
                    + " ,(B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSize,B.BaarCode FROM tSaleDetail A  "
                    + " INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                    + " WHERE SaleInvoiceID=" + rowid, "SaleDetail");
                RB.DataSource = DBRes.DS.Tables["SaleDetail"];

                using (PrintPreviewFormEx form1 = new PrintPreviewFormEx())
                {
                    form1.PrintingSystem = RB.PrintingSystem;
                    RB.CreateDocument();
                    form1.ShowDialog();
                }
            }
        }

        private void barInvoiceDelete_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(86)) return;
            if (XtraMessageBox.Show("Зарлагын падан устгах гэж байна. Устгах уу?", "Падан устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] spPName = new String[] { "SaleInvoiceID" };
                SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                Object[] spPValue = new Object[] { RowID() };
                if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                if (DBRes._ParamProcedure("DELETE FROM tSaleDetail WHERE SaleInvoiceID=@SaleInvoiceID DELETE FROM tSaleInvoice WHERE SaleInvoiceID=@SaleInvoiceID", CommandType.Text))
                    SaleInvoiceList_Load(sender, e);
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(87)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridSaleDetail.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridSaleDetail.ShowPrintPreview();
        }
    }
}