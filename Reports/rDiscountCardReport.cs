using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Pharmacy.Reports
{
    public partial class rDiscountCardReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rDiscountCardReport()
        {
            InitializeComponent();
            //---- clear binding ----
            xrName.DataBindings.Clear();
            xrRegion.DataBindings.Clear();
            xrOgnoo.DataBindings.Clear();

            xrRowNum.DataBindings.Clear();
            xrLFNameReg.DataBindings.Clear();
            xrSaleInvoiceNum.DataBindings.Clear();
            xrSumPrice.DataBindings.Clear();
            xrSumDiscount.DataBindings.Clear();
            xrFirstname.DataBindings.Clear();

            xrSumTotal.DataBindings.Clear();
            xrDisSumTotal.DataBindings.Clear();

            //---- load data ----
            xrRowNum.DataBindings.Add("Text", this.DataSource, "RowNum");
            xrLFNameReg.DataBindings.Add("Text", this.DataSource, "LFNameReg");
            xrSaleInvoiceNum.DataBindings.Add("Text", this.DataSource, "SaleInvoiceNum");
            xrSumPrice.DataBindings.Add("Text", this.DataSource, "SumPrice", "{0:n}");
            xrSumDiscount.DataBindings.Add("Text", this.DataSource, "SumDiscount", "{0:n}");
            xrFirstname.DataBindings.Add("Text", this.DataSource, "Firstname");
            //---- load sum ----
            xrSumTotal.DataBindings.Add("Text", this.DataSource, "SumPrice");
            xrDisSumTotal.DataBindings.Add("Text", this.DataSource, "SumDiscount");
        }

    }
}
