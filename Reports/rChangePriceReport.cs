using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Pharmacy.Reports
{
    public partial class rChangePriceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rChangePriceReport()
        {
            InitializeComponent();
            //---- clear binding ----
            xrName.DataBindings.Clear();
            xrRegion.DataBindings.Clear();
            xrOgnoo.DataBindings.Clear();

            xrNameSize.DataBindings.Clear();
            xrCount.DataBindings.Clear();
            xrOldPrice.DataBindings.Clear();
            xrNewPrice.DataBindings.Clear();
            xrUOA.DataBindings.Clear();

            xrSumUOA.DataBindings.Clear();
            //---- load data ----
            xrNameSize.DataBindings.Add("Text", this.DataSource, "NameSize");
            xrCount.DataBindings.Add("Text", this.DataSource, "Count", "{0:n}");
            xrOldPrice.DataBindings.Add("Text", this.DataSource, "OldPrice", "{0:n}");
            xrNewPrice.DataBindings.Add("Text", this.DataSource, "NewPrice", "{0:n}");
            xrUOA.DataBindings.Add("Text", this.DataSource, "UOA", "{0:n}");
            //---- load sum ----
            xrSumUOA.DataBindings.Add("Text", this.DataSource, "UOA");
        }

    }
}
