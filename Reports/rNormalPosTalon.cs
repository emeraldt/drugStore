using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Pharmacy.Reports
{
    public partial class rNormalPosTalon : DevExpress.XtraReports.UI.XtraReport
    {
        public rNormalPosTalon()
        {
            InitializeComponent();
            //---- clear binding ----
            xrCompanyname.DataBindings.Clear();
            xrTalonnum.DataBindings.Clear();
            xrPhonenum.DataBindings.Clear();
            xrDate.DataBindings.Clear();
            
            xrName.DataBindings.Clear();
            xrCount.DataBindings.Clear();
            xrPrice.DataBindings.Clear();
            xrSumprice.DataBindings.Clear();

            xrSumTotal.DataBindings.Clear();
            xrDiscountTotal.DataBindings.Clear();
            xrPayTotal.DataBindings.Clear();
            xrPaidTotal.DataBindings.Clear();
            xrOddMoney.DataBindings.Clear();
            //---- load data ----
            xrName.DataBindings.Add("Text", this.DataSource, "NameSize");
            xrCount.DataBindings.Add("Text", this.DataSource, "Count", "{0:n}");
            xrPrice.DataBindings.Add("Text", this.DataSource, "Price", "{0:n}");
            xrSumprice.DataBindings.Add("Text", this.DataSource, "SumPrice", "{0:n}");
        }

    }
}
