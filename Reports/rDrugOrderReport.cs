using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Pharmacy.Reports
{
    public partial class rDrugOrderReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rDrugOrderReport()
        {
            InitializeComponent();
            //---- clear binding ----
            xrName.DataBindings.Clear();
            xrRegion.DataBindings.Clear();
            xrOgnoo.DataBindings.Clear();

            xrRowNum.DataBindings.Clear();
            xrDrugName.DataBindings.Clear();
            xrSize.DataBindings.Clear();
            xrPackage.DataBindings.Clear();
            xrOrderDate.DataBindings.Clear();
            xrOrderUser.DataBindings.Clear();
            //---- load data ----
            xrRowNum.DataBindings.Add("Text", this.DataSource, "RowNum");
            xrDrugName.DataBindings.Add("Text", this.DataSource, "Name");
            xrSize.DataBindings.Add("Text", this.DataSource, "Size");
            xrPackage.DataBindings.Add("Text", this.DataSource, "Package");
            xrOrderDate.DataBindings.Add("Text", this.DataSource, "ActionDate", "{0:yyyy-MM-dd}");
            xrOrderUser.DataBindings.Add("Text", this.DataSource, "Firstname");
        }

    }
}
