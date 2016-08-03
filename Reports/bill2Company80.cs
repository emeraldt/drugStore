using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Pharmacy.Reports
{
    public partial class bill2Company80 : DevExpress.XtraReports.UI.XtraReport
    {
        public bill2Company80()
        {
            InitializeComponent();

            xrName.DataBindings.Add("Text", this.DataSource, "NameSize");
            xrCount.DataBindings.Add("Text", this.DataSource, "Count", "{0:n}");
            xrPrice.DataBindings.Add("Text", this.DataSource, "Price", "{0:n}");
            xrSumprice.DataBindings.Add("Text", this.DataSource, "SumPrice", "{0:n}");
        }

    }
}
