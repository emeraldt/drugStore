using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Pharmacy.Reports
{
    public partial class rSaleShotReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rSaleShotReport()
        {
            InitializeComponent();
            //---- clear binding ----
            xrName.DataBindings.Clear();
            xrRegion.DataBindings.Clear();
            xrOgnoo.DataBindings.Clear();

            xrNameSize.DataBindings.Clear();
            xrCount.DataBindings.Clear();
            xrPrice.DataBindings.Clear();
            xrSumPrice.DataBindings.Clear();
            xrActionDate.DataBindings.Clear();

            xrSumTotal.DataBindings.Clear();
            //---- load data ----
            xrNameSize.DataBindings.Add("Text", this.DataSource, "NameSize");
            xrCount.DataBindings.Add("Text", this.DataSource, "Count", "{0:n}");
            xrPrice.DataBindings.Add("Text", this.DataSource, "Price", "{0:n}");
            xrSumPrice.DataBindings.Add("Text", this.DataSource, "SumPrice", "{0:n}");
            xrActionDate.DataBindings.Add("Text", this.DataSource, "ActionDate", "{0:yyyy-MM-dd}");
            //---- load sum ----
            xrSumTotal.DataBindings.Add("Text", this.DataSource, "SumPrice");
        }

    }
}
