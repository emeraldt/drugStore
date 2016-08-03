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
    public partial class SaleReport : DevExpress.XtraEditors.XtraForm
    {
        public SaleReport()
        {
            InitializeComponent();
        }

        private void SaleReport_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(dateStart, "Эхлэх огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(dateEnd, "Хүртэл огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(combSelect, "Сонгоогүй байна.", ConditionOperator.IsNotBlank);

            dateStart.Text = Convert.ToDateTime(PharmacyFun._startDateAccountPeriod()).ToString("yyyy-MM-dd");
        }

        private void SaleReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void SaleReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._salereport = null;
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
            string wText = "";
            if (combSelect.SelectedIndex == 2) { wText = "AND A.Status=2"; }
            else if (combSelect.SelectedIndex == 1) { wText = " AND A.Status=1 "; }
            else if (combSelect.SelectedIndex == 3) { wText = " AND A.Status=3 "; }
            else { wText = ""; }
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.SaleInvoiceID ASC) AS RowNum, "
                + " A.SaleInvoiceID,A.SaleInvoiceNum,A.SumPrice,A.ActionDate,A.UserID,A.CardID,A.SumDiscount, "
                + " CASE WHEN A.CardID=1 THEN '-' ELSE (B.CardNum + '-' + UPPER(SUBSTRING(B.LastName,0,1))+'.'+UPPER(B.FirstName)) END CardName "
                + " FROM tSaleInvoice A INNER JOIN tDiscountcard B ON(B.CardID=A.CardID)"
                + " WHERE A.ActionDate>='" + dateStart.Text + " 00:00:00' AND A.ActionDate<='" + dateEnd.Text + " 23:59:59' "
                + wText, "SaleInvoice");
            gridSaleInvoice.DataSource = DBRes.DS.Tables["SaleInvoice"];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            DataSet ds = new DataSet();
            ds.Tables.Add((gridSaleInvoice.DataSource as DataTable).Copy());
            if (ds.Tables[0].Rows.Count <= 0) return;

            Reports.rSaleInvoiceReport RB = new Reports.rSaleInvoiceReport();

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

    }
}