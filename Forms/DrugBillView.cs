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
    public partial class DrugBillView : DevExpress.XtraEditors.XtraForm
    {
        public int BillID;
        public int CountInvoiceID;
        public string CountNum;
        public DrugBillView()
        {
            InitializeComponent();
        }

        private void DrugBillView_Load(object sender, EventArgs e)
        {
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;
            int BegInv = 0;
            int Counting = 0;
            DBRes._FillTable("SELECT * FROM tDrugBill WHERE BillID=" + BillID, "DrugBill");
            if (Convert.ToBoolean(DBRes.DS.Tables["DrugBill"].Rows[0]["Status"]))
            {
                StartDate = Convert.ToDateTime(DBRes.DS.Tables["DrugBill"].Rows[0]["ActionDate"]);
                EndDate = Convert.ToDateTime(DBRes.DS.Tables["DrugBill"].Rows[0]["CloseDate"]);
                if (DBRes.DS.Tables["DrugBill"].Rows[0]["LastBillID"].ToString() != "0")
                    BegInv = PharmacyFun.GetCountInvoiceID(Convert.ToInt32(DBRes.DS.Tables["DrugBill"].Rows[0]["LastBillID"]));
                Counting = Convert.ToInt32(DBRes.DS.Tables["DrugBill"].Rows[0]["CountInvoiceID"]);
            }
            else
            {
                StartDate = Convert.ToDateTime(DBRes.DS.Tables["DrugBill"].Rows[0]["ActionDate"]);
                BegInv = PharmacyFun.GetCountInvoiceID(Convert.ToInt32(DBRes.DS.Tables["DrugBill"].Rows[0]["LastBillID"]));
                Counting = CountInvoiceID;
            }

            string cmdText = "SELECT ROW_NUMBER() OVER(ORDER BY A.DrugID ASC) AS RowNum, "
                + " A.DrugID,(A.Name+' '+ISNULL(A.Size,'')+' '+ISNULL(A.Package,''))NameSize,A.Price,A.BaarCode, "
                    + " ISNULL(BegInv.Count,0)BegInv, "
                    + " ISNULL(B.BuyCount,0)BuyCount, "
                    + " ISNULL(C.SaleCount,0)SaleCount, "
                    + " ISNULL(Counting.Count,0)Counting, "
                    + " CASE WHEN (ISNULL(Counting.Count,0)-(ISNULL((BegInv.Count),0)+ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0)))>0 THEN (ISNULL(Counting.Count,0)-(ISNULL((BegInv.Count),0)+ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0)))*A.Price ELSE 0 END ZorooIluu, "
                    + " CASE WHEN (ISNULL(Counting.Count,0)-(ISNULL((BegInv.Count),0)+ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0)))>0 THEN 0 ELSE (ISNULL(Counting.Count,0)-(ISNULL((BegInv.Count),0)+ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0)))*A.Price*-1 END ZorooDutuu "
                + " FROM tDrug A "
                + " LEFT JOIN (SELECT * FROM tCountDetail WHERE CountInvoiceID=" + BegInv + ")BegInv ON(BegInv.DrugID=A.DrugID) "
                + " LEFT JOIN (SELECT DrugID,SUM([Count])BuyCount FROM tBuyDetail "
                    + " WHERE ActionDate>='" + StartDate + "' AND ActionDate<='" + EndDate + "' "
                    + " GROUP BY DrugID)B ON(B.DrugID=A.DrugID) "
                + " LEFT JOIN (SELECT DrugID,SUM([Count])SaleCount FROM tSaleDetail  "
                    + " WHERE ActionDate>='" + StartDate + "' AND ActionDate<='" + EndDate + "' "
                    + " GROUP BY DrugID)C ON(C.DrugID=A.DrugID) "
                + " LEFT JOIN (SELECT * FROM tCountDetail WHERE CountInvoiceID=" + Counting + ")Counting ON(Counting.DrugID=A.DrugID)";

            DBRes._FillTable(cmdText, "DrugBillView");
            gridDrugBillView.DataSource = DBRes.DS.Tables["DrugBillView"];
            barDate.Caption = "Эмийн тооцоо " + StartDate.ToString("yyyy-MM-dd hh:mm:ss tt") + " - " + EndDate.ToString("yyyy-MM-dd hh:mm:ss tt") + " хооронд";
            barCount.Caption = "Тооллогын дугаар - " + CountNum;
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(55)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridDrugBillView.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridDrugBillView.ShowPrintPreview();
        }

        private void DrugBillView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}