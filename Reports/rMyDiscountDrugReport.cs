using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Pharmacy.Reports
{
    public partial class rMyDiscountDrugReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rMyDiscountDrugReport()
        {
            InitializeComponent();
            //
            xrCompanyname.DataBindings.Clear();
            xrOgnoo.DataBindings.Clear();
            //
            xrRowNum.DataBindings.Clear();
            xrLFName.DataBindings.Clear();
            xrRegNum.DataBindings.Clear();
            xrEMDNum.DataBindings.Clear();
            xrNDDNum.DataBindings.Clear();
            xrAddress.DataBindings.Clear();
            //xrJorNumOgnoo.DataBindings.Clear();
            xrJorNum.DataBindings.Clear();
            xrJorDate.DataBindings.Clear();
            xrDoctorShipr.DataBindings.Clear();
            //
            xrDrugName1.DataBindings.Clear();
            xrCount1.DataBindings.Clear();
            xrUnitPrice1.DataBindings.Clear();
            xrSumTotal1.DataBindings.Clear();
            xrNDDun1.DataBindings.Clear();
            xrTolson1.DataBindings.Clear();
            //
            xrDrugName2.DataBindings.Clear();
            xrCount2.DataBindings.Clear();
            xrUnitPrice2.DataBindings.Clear();
            xrSumTotal2.DataBindings.Clear();
            xrNDDun2.DataBindings.Clear();
            xrTolson2.DataBindings.Clear();
            //
            xrDrugName3.DataBindings.Clear();
            xrCount3.DataBindings.Clear();
            xrUnitPrice3.DataBindings.Clear();
            xrSumTotal3.DataBindings.Clear();
            xrNDDun3.DataBindings.Clear();
            xrTolson3.DataBindings.Clear();
            //
            xrMyDrugName1.DataBindings.Clear();
            xrMyCount1.DataBindings.Clear();
            xrMyPrice1.DataBindings.Clear();
            xrMySumPrice1.DataBindings.Clear();
            //
            xrMyDrugName2.DataBindings.Clear();
            xrMyCount2.DataBindings.Clear();
            xrMyPrice2.DataBindings.Clear();
            xrMySumPrice2.DataBindings.Clear();
            //
            xrMyDrugName3.DataBindings.Clear();
            xrMyCount3.DataBindings.Clear();
            xrMyPrice3.DataBindings.Clear();
            xrMySumPrice3.DataBindings.Clear();
            //
            xrNDAvahDun.DataBindings.Clear();
            //
            xrRowNum.DataBindings.Add("Text", this.DataSource, "RowNum");
            xrLFName.DataBindings.Add("Text", this.DataSource, "LFName");
            xrRegNum.DataBindings.Add("Text", this.DataSource, "RegNum");
            xrEMDNum.DataBindings.Add("Text", this.DataSource, "EMDNum");
            xrNDDNum.DataBindings.Add("Text", this.DataSource, "NDNum");
            xrAddress.DataBindings.Add("Text", this.DataSource, "Address");
            //xrJorNumOgnoo.DataBindings.Add("Text", this.DataSource, "JorNumOgnoo");
            xrJorNum.DataBindings.Add("Text", this.DataSource, "JorNum");
            xrJorDate.DataBindings.Add("Text", this.DataSource, "JorDate", "{0:yyyy-MM-dd}");
            xrDoctorShipr.DataBindings.Add("Text", this.DataSource, "DoctorCipher");
            //
            xrDrugName1.DataBindings.Add("Text", this.DataSource, "name1");
            xrCount1.DataBindings.Add("Text", this.DataSource, "too1");
            xrUnitPrice1.DataBindings.Add("Text", this.DataSource, "uprice1");
            xrSumTotal1.DataBindings.Add("Text", this.DataSource, "price1");
            xrNDDun1.DataBindings.Add("Text", this.DataSource, "nddun1");
            xrTolson1.DataBindings.Add("Text", this.DataSource, "tolson1");
            //
            xrDrugName2.DataBindings.Add("Text", this.DataSource, "name2");
            xrCount2.DataBindings.Add("Text", this.DataSource, "too2");
            xrUnitPrice2.DataBindings.Add("Text", this.DataSource, "uprice2");
            xrSumTotal2.DataBindings.Add("Text", this.DataSource, "price2");
            xrNDDun2.DataBindings.Add("Text", this.DataSource, "nddun2");
            xrTolson2.DataBindings.Add("Text", this.DataSource, "tolson2");
            //
            xrDrugName3.DataBindings.Add("Text", this.DataSource, "name3");
            xrCount3.DataBindings.Add("Text", this.DataSource, "too3");
            xrUnitPrice3.DataBindings.Add("Text", this.DataSource, "uprice3");
            xrSumTotal3.DataBindings.Add("Text", this.DataSource, "price3");
            xrNDDun3.DataBindings.Add("Text", this.DataSource, "nddun3");
            xrTolson3.DataBindings.Add("Text", this.DataSource, "tolson3");
            //
            xrMyDrugName1.DataBindings.Add("Text", this.DataSource, "n1");
            xrMyCount1.DataBindings.Add("Text", this.DataSource, "to1");
            xrMyPrice1.DataBindings.Add("Text", this.DataSource, "pr1");
            xrMySumPrice1.DataBindings.Add("Text", this.DataSource, "dun1");
            //
            xrMyDrugName2.DataBindings.Add("Text", this.DataSource, "n2");
            xrMyCount2.DataBindings.Add("Text", this.DataSource, "to2");
            xrMyPrice2.DataBindings.Add("Text", this.DataSource, "pr2");
            xrMySumPrice2.DataBindings.Add("Text", this.DataSource, "dun2");
            //
            xrMyDrugName3.DataBindings.Add("Text", this.DataSource, "n3");
            xrMyCount3.DataBindings.Add("Text", this.DataSource, "to3");
            xrMyPrice3.DataBindings.Add("Text", this.DataSource, "pr3");
            xrMySumPrice3.DataBindings.Add("Text", this.DataSource, "dun3");
        }

    }
}
