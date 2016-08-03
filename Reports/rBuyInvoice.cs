using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Pharmacy.Reports
{
    public partial class rBuyInvoice : DevExpress.XtraReports.UI.XtraReport
    {
        public rBuyInvoice()
        {
            InitializeComponent();
            //---- clear binding ----
            xrPadanName.DataBindings.Clear();
            xrName.DataBindings.Clear();
            xrRegion.DataBindings.Clear();

            xrUser.DataBindings.Clear();
            xrPadanNum.DataBindings.Clear();
            xrDate.DataBindings.Clear();

            xrPadanType.DataBindings.Clear();

            xrSupplier.DataBindings.Clear();
            xrPadanNumSal.DataBindings.Clear();
            xrDateSale.DataBindings.Clear();

            xrDrugName.DataBindings.Clear();
            xrBaarCode.DataBindings.Clear();
            xrCount.DataBindings.Clear();
            xrPrice.DataBindings.Clear();
            xrSumPrice.DataBindings.Clear();
            
            xrAmount.DataBindings.Clear();
            //---- load data ----
            xrRowNum.DataBindings.Add("Text", this.DataSource, "RowNum");
            xrDrugName.DataBindings.Add("Text", this.DataSource, "NameSize");
            xrBaarCode.DataBindings.Add("Text", this.DataSource, "BaarCode");
            xrCount.DataBindings.Add("Text", this.DataSource, "Count", "{0:n}");
            xrPrice.DataBindings.Add("Text", this.DataSource, "Price", "{0:n}");
            xrSumPrice.DataBindings.Add("Text", this.DataSource, "SumPrice", "{0:n}");
            //---- load sum ----
            xrAmount.DataBindings.Add("Text", this.DataSource, "SumPrice");
        }

    }
}
