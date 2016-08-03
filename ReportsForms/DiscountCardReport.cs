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
    public partial class DiscountCardReport : DevExpress.XtraEditors.XtraForm
    {
        public DiscountCardReport()
        {
            InitializeComponent();
        }

        private void DiscountCardReport_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(dateStart, "Эхлэх огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(dateEnd, "Хүртэл огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);

            dateStart.Text = Convert.ToDateTime(PharmacyFun._startDateAccountPeriod()).ToString("yyyy-MM-dd");
        }

        private void DiscountCardReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void DiscountCardReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._discountcardreport = null;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY SaleInvoiceNum ASC) AS RowNum, "
                + " A.*,(SUBSTRING(B.LastName,1,1)+'.'+B.FirstName +' - '+B.RegNum)LFNameReg,C.Firstname FROM tSaleInvoice A "
                + " INNER JOIN tDiscountcard B ON(B.CardID=A.CardID) "
                + " INNER JOIN tUsers C ON(C.UserID=A.UserID) "
                + " WHERE A.CardID<>1 AND A.ActionDate>='" + dateStart.Text.Trim() + " 00:00:00' AND "
                + " A.ActionDate<='" + dateEnd.Text.Trim() + " 23:59:59'", "DiscountcardView");
            gridDisCountCard.DataSource = DBRes.DS.Tables["DiscountcardView"];
            btnPrint.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridDisCountCard.DataSource as DataTable).Copy());
            Reports.rDiscountCardReport RB = new Reports.rDiscountCardReport();
            DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");
            RB.xrName.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
            RB.xrRegion.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Region"].ToString();
            RB.xrOgnoo.Text = dateStart.Text + " -ээс " + dateEnd.Text + " хүртэл хөнгөлөлтийн картаар хийсэн борлуулалтын тайлан";

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