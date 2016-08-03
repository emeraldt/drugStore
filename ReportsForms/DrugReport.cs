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
    public partial class DrugReport : DevExpress.XtraEditors.XtraForm
    {
        DateTime billStartDate;
        public DrugReport()
        {
            InitializeComponent();
        }

        private void DrugReport_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(dateStart, "Эхлэх огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(dateEnd, "Хүртэл огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);

            dateStart.Text = Convert.ToDateTime(PharmacyFun._startDateAccountPeriod()).ToString("yyyy-MM-dd");
            billStartDate = Convert.ToDateTime(PharmacyFun._startDateAccountPeriod());
        }

        private void DrugReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._drugreport = null;
        }

        private void DrugReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
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
            DateTime dateEndBegInv = Convert.ToDateTime(dateStart.Text);
            DateTime dateStartBegInv = DateTime.Now;
            dateEndBegInv = dateEndBegInv.AddDays(-1);
            //
            DBRes._FillTable("SELECT * FROM tDrugBill WHERE Status=0", "DrugBill");
            if (DBRes.DS.Tables["DrugBill"].Rows.Count > 0)
            {
                int BegInvID = PharmacyFun.GetCountInvoiceID(Convert.ToInt32(DBRes.DS.Tables["DrugBill"].Rows[0]["LastBillID"]));
                DateTime BegInvOgnoo;
                if (BegInvID != 0)
                    BegInvOgnoo = PharmacyFun.GetCountInvoiceDate(Convert.ToInt32(DBRes.DS.Tables["DrugBill"].Rows[0]["LastBillID"]));
                else BegInvOgnoo = Convert.ToDateTime(DBRes.DS.Tables["DrugBill"].Rows[0]["ActionDate"]);

                DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.Name ASC) AS RowNum, "
                    + " A.DrugID,(A.Name+' '+ISNULL(A.Size,'')+' '+ISNULL(A.Package,''))NameSize, "
                    + " (ISNULL(BgIn.Count,0)+(ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0)))BegInv, "
                    + " (A.Price*(ISNULL(BgIn.Count,0)+(ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0))))SumPriceBegInv, "
                    + " ISNULL(E.BuyCount,0)BuyCount, "
                    + " ISNULL(E.SumPrice,0)SumPriceBuyCount, "
                    + " ISNULL(F.SaleCount,0)SaleCount, "
                    + " ISNULL(F.SumPrice,0)SumPriceSaleCount, "
                    + " ((ISNULL(BgIn.Count,0)+ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0))+ISNULL(E.BuyCount,0)-ISNULL(F.SaleCount,0))BegEnd,A.Price, "
                    + " (((ISNULL(BgIn.Count,0)+ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0))+ISNULL(E.BuyCount,0)-ISNULL(F.SaleCount,0))*A.Price)SumPriceBegEnd, "
                    + " (((ISNULL(BgIn.Count,0)+ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0))+ISNULL(E.BuyCount,0)-ISNULL(F.SaleCount,0))*A.Price)- "
                    + " ((A.Price*(ISNULL(BgIn.Count,0)+(ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0))))+ISNULL(E.SumPrice,0)-ISNULL(F.SumPrice,0))ChangePrice "
                + " FROM tDrug A  "
                + " LEFT JOIN (SELECT * FROM tCountDetail WHERE CountInvoiceID=" + BegInvID + ")BgIn ON(BgIn.DrugID=A.DrugID) "
                + " LEFT JOIN (SELECT DrugID,SUM([Count])BuyCount,SUM([Count]*SalePrice)SumPrice FROM tBuyDetail  "
                    + " WHERE ActionDate>='" + BegInvOgnoo.ToString("yyyy-MM-dd") + " 00:00:00'/*ET-ehleh ogno*/ AND ActionDate<='" + dateEndBegInv.ToString("yyyy-MM-dd") + " 23:59:59' "
                    + " GROUP BY DrugID)B ON(B.DrugID=A.DrugID)  "
                + " LEFT JOIN (SELECT DrugID,SUM([Count])SaleCount,SUM(SumPrice)SumPrice FROM tSaleDetail   "
                    + " WHERE ActionDate>='" + BegInvOgnoo.ToString("yyyy-MM-dd") + " 00:00:00'/*ET-ehleh ogno*/ AND ActionDate<='" + dateEndBegInv.ToString("yyyy-MM-dd") + " 23:59:59' "
                    + " GROUP BY DrugID)C ON(C.DrugID=A.DrugID) "

                + " LEFT JOIN (SELECT DrugID,SUM([Count])BuyCount,SUM(SumPrice)SumPrice FROM tBuyDetail  "
                    + " WHERE ActionDate>='" + dateStart.Text + " 00:00:00' AND ActionDate<='" + dateEnd.Text + " 23:59:59' "
                    + " GROUP BY DrugID)E ON(E.DrugID=A.DrugID)  "
                + " LEFT JOIN (SELECT DrugID,SUM([Count])SaleCount,SUM(SumPrice)SumPrice FROM tSaleDetail   "
                    + " WHERE ActionDate>='" + dateStart.Text + " 00:00:00' AND ActionDate<='" + dateEnd.Text + " 23:59:59' "
                    + " GROUP BY DrugID)F ON(F.DrugID=A.DrugID)", "DrugBillRep");
                gridDrugBill.DataSource = DBRes.DS.Tables["DrugBillRep"];
            }
            else { Information.ErrorMessage("Эмийн тооцоо үүсгээгүй байна.", "Эмийн тооцоо"); }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(57)) return;
            if (!Static.dxV.Validate()) return;
            DataSet ds = new DataSet();
            ds.Tables.Add((gridDrugBill.DataSource as DataTable).Copy());
            if (ds.Tables[0].Rows.Count <= 0) return;

            Reports.rDrugReport RB = new Reports.rDrugReport();

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

    }
}
