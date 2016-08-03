using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Pharmacy.Reports
{
    public partial class rDiscountPosTalon : DevExpress.XtraReports.UI.XtraReport
    {
        public rDiscountPosTalon()
        {
            InitializeComponent();
            //---- clear binding ----
            xrCompanyname.DataBindings.Clear();
            xrLastName.DataBindings.Clear();
            xrRegNum.DataBindings.Clear();
            xrJorNum.DataBindings.Clear();
            xrDoctorNum.DataBindings.Clear();

            xrNameSize.DataBindings.Clear();

            xrCount.DataBindings.Clear();
            xrPrice.DataBindings.Clear();
            xrPriceND.DataBindings.Clear();
            xrPriceDT.DataBindings.Clear();

            xrSumTotal.DataBindings.Clear();
            xrTotalND.DataBindings.Clear();
            xrTotalDT.DataBindings.Clear();
            //---- load data ----
            xrNameSize.DataBindings.Add("Text", this.DataSource, "Name");
            xrCount.DataBindings.Add("Text", this.DataSource, "Count", "{0:n}");
            xrPrice.DataBindings.Add("Text", this.DataSource, "PriceND", "{0:n}");
            xrPriceND.DataBindings.Add("Text", this.DataSource, "NDDiscountTotal", "{0:n}");
            xrPriceDT.DataBindings.Add("Text", this.DataSource, "DisCusPrice", "{0:n}");
            //---- load sum ----
            xrSumTotal.DataBindings.Add("Text", this.DataSource, "PriceND", "{0:n}");
            xrTotalND.DataBindings.Add("Text", this.DataSource, "NDDiscountTotal", "{0:n}");
            xrTotalDT.DataBindings.Add("Text", this.DataSource, "DisCusPrice", "{0:n}");
        }

    }
}
