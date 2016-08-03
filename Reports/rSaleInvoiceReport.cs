using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Pharmacy.Reports
{
    public partial class rSaleInvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rSaleInvoiceReport()
        {
            InitializeComponent();
            //---- clear binding ----
            xrName.DataBindings.Clear();
            xrRegion.DataBindings.Clear();
            xrOgnoo.DataBindings.Clear();

            xrTalonNum.DataBindings.Clear();
            xrSumPrice.DataBindings.Clear();
            xrActionDate.DataBindings.Clear();
            xrCardName.DataBindings.Clear();
            xrDiscountPrice.DataBindings.Clear();

            xrSumTotal.DataBindings.Clear();
            xrDiscountTotal.DataBindings.Clear();
            //---- load data ----
            xrTalonNum.DataBindings.Add("Text", this.DataSource, "SaleInvoiceNum");
            xrSumPrice.DataBindings.Add("Text", this.DataSource, "SumPrice", "{0:n}");
            xrActionDate.DataBindings.Add("Text", this.DataSource, "ActionDate", "{0:yyyy-MM-dd}");
            xrCardName.DataBindings.Add("Text", this.DataSource, "CardName");
            xrDiscountPrice.DataBindings.Add("Text", this.DataSource, "SumDiscount", "{0:n}");
            //---- load sum ----
            xrSumTotal.DataBindings.Add("Text", this.DataSource, "SumPrice");
            xrDiscountTotal.DataBindings.Add("Text", this.DataSource, "SumDiscount");
        }

    }
}
