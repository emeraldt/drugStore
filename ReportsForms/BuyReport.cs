using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pharmacy.Codes;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraPrinting.Preview;

namespace Pharmacy.ReportsForms
{
    public partial class BuyReport : DevExpress.XtraEditors.XtraForm
    {
        public BuyReport()
        {
            InitializeComponent();
        }

        private void BuyReport_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(dateStart, "Эхлэх огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(dateEnd, "Хүртэл огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);

            dateStart.Text = Convert.ToDateTime(PharmacyFun._startDateAccountPeriod()).ToString("yyyy-MM-dd");
        }

        private void BuyReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void BuyReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._buyreport = null;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            if (Convert.ToDateTime(dateStart.Text) > Convert.ToDateTime(dateEnd.Text))
            {
                XtraMessageBox.Show("Хүртэлх огноо эхлэх огнооноос бага байж болохгүй.", "Огноо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnPrint.Enabled = true;
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.BuyInvoiceID ASC) AS RowNum,A.*,B.Name FROM tBuyInvoice A "
                + " INNER JOIN tSupplier B ON(B.SupplierID=A.SupplierID) "
                + " WHERE A.ActionDate>='"
                + dateStart.Text + " 00:00:00' AND A.ActionDate<='" + dateEnd.Text + " 23:59:59'", "BuyInvoice");
            gridBuyInvoice.DataSource = DBRes.DS.Tables["BuyInvoice"];
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

                RB.xrSupplier.Text = RB.xrSupplier.Text + " : " + DBRes.DS.Tables["BuyInvoice"].Rows[0]["SupplierName"].ToString();
                RB.xrPadanNumSal.Text = RB.xrPadanNumSal.Text + " : " + DBRes.DS.Tables["BuyInvoice"].Rows[0]["InvoiceNum"].ToString();
                RB.xrDateSale.Text = RB.xrDateSale.Text + " : " + Convert.ToDateTime(DBRes.DS.Tables["BuyInvoice"].Rows[0]["InvoiceDate"]).ToString("yyyy-MM-dd");

                DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");

                RB.xrName.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                RB.xrRegion.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Region"].ToString(); ;

                DBRes._FillTable("SELECT A.*,(B.Name+' - '+ISNULL(B.Size,''))NameSize,B.Package FROM tBuyDetail A "
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            DataSet ds = new DataSet();
            ds.Tables.Add((gridBuyInvoice.DataSource as DataTable).Copy());
            if (ds.Tables[0].Rows.Count <= 0) return;

            Reports.rBuyInvoiceReport RB = new Reports.rBuyInvoiceReport();

            DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");

            RB.xrName.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
            RB.xrRegion.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Region"].ToString();

            RB.xrOgnoo.Text = dateStart.Text + " -ээс " + dateEnd.Text + " хүртэл";

            RB.DataSource = ds.Tables[0];

            using (PrintPreviewFormEx form1 = new PrintPreviewFormEx())
            {
                form1.PrintingSystem = RB.PrintingSystem;
                RB.CreateDocument();
                form1.ShowDialog();
            }
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
    }
}