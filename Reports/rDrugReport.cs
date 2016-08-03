using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Pharmacy.Reports
{
    public partial class rDrugReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rDrugReport()
        {
            InitializeComponent();
            //---- clear binding ----
            xrName.DataBindings.Clear();
            xrRegion.DataBindings.Clear();
            xrOgnoo.DataBindings.Clear();

            xrDrugName.DataBindings.Clear();
            xrBegInv.DataBindings.Clear();
            xrBegInvPrice.DataBindings.Clear();
            xrBuy.DataBindings.Clear();
            xrBuyPrice.DataBindings.Clear();
            xrSale.DataBindings.Clear();
            xrSalePrice.DataBindings.Clear();
            xrBegEnd.DataBindings.Clear();
            xrBegEndPrice.DataBindings.Clear();
            xrUOAPrice.DataBindings.Clear();

            xrBegEndSumPrice.DataBindings.Clear();
            xrBuySumPrice.DataBindings.Clear();
            xrSaleSumPrice.DataBindings.Clear();
            xrBegEndSumPrice.DataBindings.Clear();
            xrUOASumPrice.DataBindings.Clear();
            //---- load data ----
            xrDrugName.DataBindings.Add("Text", this.DataSource, "NameSize");
            xrBegInv.DataBindings.Add("Text", this.DataSource, "BegInv", "{0:n}");
            xrBegInvPrice.DataBindings.Add("Text", this.DataSource, "SumPriceBegInv", "{0:n}");
            xrBuy.DataBindings.Add("Text", this.DataSource, "BuyCount", "{0:n}");
            xrBuyPrice.DataBindings.Add("Text", this.DataSource, "SumPriceBuyCount", "{0:n}");
            xrSale.DataBindings.Add("Text", this.DataSource, "SaleCount", "{0:n}");
            xrSalePrice.DataBindings.Add("Text", this.DataSource, "SumPriceSaleCount", "{0:n}");
            xrBegEnd.DataBindings.Add("Text", this.DataSource, "BegEnd", "{0:n}");
            xrBegEndUne.DataBindings.Add("Text", this.DataSource, "Price", "{0:n}");
            xrBegEndPrice.DataBindings.Add("Text", this.DataSource, "SumPriceBegEnd", "{0:n}");
            xrUOAPrice.DataBindings.Add("Text", this.DataSource, "ChangePrice", "{0:n}");
            //---- load sum ----
            xrBegInvSumPrice.DataBindings.Add("Text", this.DataSource, "SumPriceBegInv");
            xrBuySumPrice.DataBindings.Add("Text", this.DataSource, "SumPriceBuyCount");
            xrSaleSumPrice.DataBindings.Add("Text", this.DataSource, "SumPriceSaleCount");
            xrBegEndSumPrice.DataBindings.Add("Text", this.DataSource, "SumPriceBegEnd");
            xrUOASumPrice.DataBindings.Add("Text", this.DataSource, "ChangePrice");
        }

    }
}
