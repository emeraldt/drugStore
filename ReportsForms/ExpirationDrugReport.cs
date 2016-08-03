using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pharmacy.Codes;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraPrinting.Preview;

namespace Pharmacy.ReportsForms
{
    public partial class ExpirationDrugReport : DevExpress.XtraEditors.XtraForm
    {
        public ExpirationDrugReport()
        {
            InitializeComponent();
        }

        private void ExpirationDrugReport_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(dateStart, "Эхлэх огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(dateEnd, "Хүртэл огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);

            dateStart.Text = Convert.ToDateTime(PharmacyFun._startDateAccountPeriod()).ToString("yyyy-MM-dd");
        }

        private void ExpirationDrugReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void ExpirationDrugReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._expirationdrugreport = null;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            if (Convert.ToDateTime(dateStart.Text) > Convert.ToDateTime(dateEnd.Text))
            {
                XtraMessageBox.Show("Хүртэлх огноо эхлэх огнооноос бага байж болохгүй.", "Огноо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnPrint.Enabled = true;
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY B.Name ASC) AS RowNum, "
                + " A.*,(B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSizePackage, "
                + " C.Firstname FROM tExpirationDrug A "
                + " INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                + " INNER JOIN tUsers C ON(C.UserID=A.UserID) "
                + " WHERE A.ActionDate>='"
                + dateStart.Text + " 00:00:00' AND A.ActionDate<='" + dateEnd.Text + " 23:59:59'", "ExpirationDrug");
            gridExpirationDrugReport.DataSource = DBRes.DS.Tables["ExpirationDrug"];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            DataSet ds = new DataSet();
            ds.Tables.Add((gridExpirationDrugReport.DataSource as DataTable).Copy());
            if (ds.Tables[0].Rows.Count <= 0) return;

            Reports.rExpirationDrugReport RB = new Reports.rExpirationDrugReport();

            DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");

            RB.xrName.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
            RB.xrRegion.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Region"].ToString();

            RB.xrOgnoo.Text = dateStart.Text + " -ээс " + dateEnd.Text + " хүртэл";

            RB.DataSource = ds.Tables[0];

            using (PrintPreviewFormEx form1 = new PrintPreviewFormEx())
            {
                form1.PrintingSystem = RB.PrintingSystem;
                RB.CreateDocument();
                form1.ShowDialog();
            }
        }
    }
}