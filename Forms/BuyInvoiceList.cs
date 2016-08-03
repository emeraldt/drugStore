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
    public partial class BuyInvoiceList : DevExpress.XtraEditors.XtraForm
    {
        public BuyInvoiceList()
        {
            InitializeComponent();
        }

        private void BuyInvoiceList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._buyinvoicelist = null;
        }

        private void BuyInvoiceList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void BuyInvoiceList_Load(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkAccountingPeriod(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"))) return;
            string startDate = PharmacyFun._startDateAccountPeriod();
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.ActionDate ASC)RowNum, "
                + " A.*,B.Name FROM tBuyInvoice A INNER JOIN tSupplier B "
                + " WITH(NOLOCK) ON(B.SupplierID=A.SupplierID)"
                + " WHERE ActionDate>='" + startDate + "' AND ActionDate<='" + DateTime.Now + "'", "BuyInvoice");
            gridBuyInvoice.DataSource = DBRes.DS.Tables["BuyInvoice"];

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY B.Name ASC)RowNum, "
                + " (B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))Name,A.* FROM tBuyDetail A INNER JOIN tDrug B "
                + " WITH(NOLOCK) ON(B.DrugID=A.DrugID) INNER JOIN tBuyInvoice C WITH(NOLOCK) ON(C.BuyInvoiceID=A.BuyInvoiceID)"
                + " WHERE A.ActionDate>='" + startDate + "' AND A.ActionDate<='" + DateTime.Now + "' AND C.Status=1", "BuyDetail");
            gridBuyDetail.DataSource = DBRes.DS.Tables["BuyDetail"];
        }

        private int RowID()
        {
            int rowId = 0;
            if (gridViewBuyInvoice == null && gridViewBuyInvoice.SelectedRowsCount == 0) return 0;
            DataRow[] rows = new DataRow[gridViewBuyInvoice.SelectedRowsCount];
            for (int i = 0; i < gridViewBuyInvoice.SelectedRowsCount; i++)
            {
                rows[i] = gridViewBuyInvoice.GetDataRow(gridViewBuyInvoice.GetSelectedRows()[i]);
            }
            foreach (DataRow row in rows)
            {
                if (row == null) return 0;
                rowId = Convert.ToInt32(row["BuyInvoiceID"].ToString());
            }
            return rowId;
        }

        private void gridBuyInvoice_DoubleClick(object sender, EventArgs e)
        {
            int rowId = RowID();
            if (rowId != 0)
            {
                DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.BuyDetailID ASC) AS RowNum, "
                    + " (B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))Name,A.* FROM tBuyDetail A "
                    + " INNER JOIN tDrug B WITH(NOLOCK) ON(B.DrugID=A.DrugID) WHERE A.BuyInvoiceID=" + rowId, "BuyDetail");
                gridBuyDetail.DataSource = DBRes.DS.Tables["BuyDetail"];
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(51)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridBuyDetail.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridBuyDetail.ShowPrintPreview();
        }

        private void barInvoicePrint_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(50)) return;
            int rowid = RowID();
            if (rowid != 0)
            {
                Reports.rBuyInvoice RB = new Reports.rBuyInvoice();
                DBRes._FillTable("SELECT A.*,B.Firstname,C.Name SupplierName FROM tBuyInvoice A "
                    + " INNER JOIN tUsers B ON(B.UserID=A.UserID) "
                    + " INNER JOIN tSupplier C ON(C.SupplierID=A.SupplierID) "
                    + " WHERE BuyInvoiceID=" + rowid, "BuyInvoice");

                RB.xrUser.Text = RB.xrUser.Text + " : " + DBRes.DS.Tables["BuyInvoice"].Rows[0]["Firstname"].ToString();
                RB.xrPadanNum.Text = RB.xrPadanNum.Text + " : " + DBRes.DS.Tables["BuyInvoice"].Rows[0]["BuyInvoiceNum"].ToString();
                RB.xrDate.Text = RB.xrDate.Text + " : " + Convert.ToDateTime(DBRes.DS.Tables["BuyInvoice"].Rows[0]["ActionDate"]).ToString("yyyy-MM-dd hh:mm:ss");

                RB.xrPadanType.Text = "/ өртөг үнээр /";

                RB.xrSupplier.Text = RB.xrSupplier.Text + " : " + DBRes.DS.Tables["BuyInvoice"].Rows[0]["SupplierName"].ToString();
                RB.xrPadanNumSal.Text = RB.xrPadanNumSal.Text + " : " + DBRes.DS.Tables["BuyInvoice"].Rows[0]["InvoiceNum"].ToString();
                RB.xrDateSale.Text = RB.xrDateSale.Text + " : " + Convert.ToDateTime(DBRes.DS.Tables["BuyInvoice"].Rows[0]["InvoiceDate"]).ToString("yyyy-MM-dd");

                DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");

                RB.xrName.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                RB.xrRegion.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Region"].ToString(); ;

                DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.BuyDetailID ASC) AS RowNum, "
                    + " A.*,(B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSize,B.BaarCode FROM tBuyDetail A  "
                    + " INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                    + " WHERE BuyInvoiceID=" + rowid, "BuyDetail");
                RB.DataSource = DBRes.DS.Tables["BuyDetail"];

                using (PrintPreviewFormEx form1 = new PrintPreviewFormEx())
                {
                    form1.PrintingSystem = RB.PrintingSystem;
                    RB.CreateDocument();
                    form1.ShowDialog();
                }
            }
        }

        private void barInvoicePrintSalePrice_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(50)) return;
            int rowid = RowID();
            if (rowid != 0)
            {
                Reports.rBuyInvoice RB = new Reports.rBuyInvoice();
                DBRes._FillTable("SELECT A.*,B.Firstname,C.Name SupplierName FROM tBuyInvoice A "
                    + " INNER JOIN tUsers B ON(B.UserID=A.UserID) "
                    + " INNER JOIN tSupplier C ON(C.SupplierID=A.SupplierID) "
                    + " WHERE BuyInvoiceID=" + rowid, "BuyInvoice");

                RB.xrUser.Text = RB.xrUser.Text + " : " + DBRes.DS.Tables["BuyInvoice"].Rows[0]["Firstname"].ToString();
                RB.xrPadanNum.Text = RB.xrPadanNum.Text + " : " + DBRes.DS.Tables["BuyInvoice"].Rows[0]["BuyInvoiceNum"].ToString();
                RB.xrDate.Text = RB.xrDate.Text + " : " + Convert.ToDateTime(DBRes.DS.Tables["BuyInvoice"].Rows[0]["ActionDate"]).ToString("yyyy-MM-dd hh:mm:ss");

                RB.xrPadanType.Text = "/ зарах үнээр /";

                RB.xrSupplier.Text = RB.xrSupplier.Text + " : " + DBRes.DS.Tables["BuyInvoice"].Rows[0]["SupplierName"].ToString();
                RB.xrPadanNumSal.Text = RB.xrPadanNumSal.Text + " : " + DBRes.DS.Tables["BuyInvoice"].Rows[0]["InvoiceNum"].ToString();
                RB.xrDateSale.Text = RB.xrDateSale.Text + " : " + Convert.ToDateTime(DBRes.DS.Tables["BuyInvoice"].Rows[0]["InvoiceDate"]).ToString("yyyy-MM-dd");

                DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");

                RB.xrName.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                RB.xrRegion.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Region"].ToString(); ;

                DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.BuyDetailID ASC) AS RowNum, "
                    + " A.BuyDetailID,A.Count,A.SalePrice Price,(A.Count * A.SalePrice)SumPrice, "
                    + " A.ActionDate,A.SalePrice,A.BuyInvoiceID,A.DrugID "
                    + " ,(B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSize,B.BaarCode FROM tBuyDetail A  "
                    + " INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                    + " WHERE BuyInvoiceID=" + rowid, "BuyDetail");
                RB.DataSource = DBRes.DS.Tables["BuyDetail"];

                using (PrintPreviewFormEx form1 = new PrintPreviewFormEx())
                {
                    form1.PrintingSystem = RB.PrintingSystem;
                    RB.CreateDocument();
                    form1.ShowDialog();
                }
            }
        }

        private void barInvoiceEdit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void barInvoiceDelete_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(66)) return;
            if (XtraMessageBox.Show("Орлогын падан устгах гэж байна. Устгах уу?", "Падан устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] spPName = new String[] { "BuyInvoiceID" };
                SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                Object[] spPValue = new Object[] { RowID() };
                if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                if (DBRes._ParamProcedure("DELETE FROM tBuyDetail WHERE BuyInvoiceID=@BuyInvoiceID DELETE FROM tBuyInvoice WHERE BuyInvoiceID=@BuyInvoiceID", CommandType.Text))
                    BuyInvoiceList_Load(sender, e);
            }
        }

    }
}