using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Pharmacy.Reports
{
    public partial class rBuyInvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rBuyInvoiceReport()
        {
            InitializeComponent();
            //---- clear binding ----
            xrName.DataBindings.Clear();
            xrRegion.DataBindings.Clear();
            xrOgnoo.DataBindings.Clear();

            xrInvoiceNum.DataBindings.Clear();
            xrInvoiceNumSale.DataBindings.Clear();
            xrInvoiceOgnooSale.DataBindings.Clear();
            xrSumPrice.DataBindings.Clear();
            xrInvoiceOgnoo.DataBindings.Clear();
            xrSupplier.DataBindings.Clear();
            xrLoan.DataBindings.Clear();

            xrSumPriceTotal.DataBindings.Clear();
            //---- load data ----
            xrInvoiceNum.DataBindings.Add("Text", this.DataSource, "BuyInvoiceNum");
            xrInvoiceNumSale.DataBindings.Add("Text", this.DataSource, "InvoiceNum");
            xrInvoiceOgnooSale.DataBindings.Add("Text", this.DataSource, "InvoiceDate", "{0:yyyy-MM-dd}");
            xrSumPrice.DataBindings.Add("Text", this.DataSource, "SumPrice", "{0:n}");
            xrInvoiceOgnoo.DataBindings.Add("Text", this.DataSource, "ActionDate", "{0:yyyy-MM-dd}");
            xrSupplier.DataBindings.Add("Text", this.DataSource, "Name");
            xrLoan.DataBindings.Add("Text", this.DataSource, "Loan");
            //---- load sum ----
            xrSumPriceTotal.DataBindings.Add("Text", this.DataSource, "SumPrice");
        }

    }
}
