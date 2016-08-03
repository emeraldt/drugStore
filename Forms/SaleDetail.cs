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

namespace Pharmacy.Forms
{
    public partial class SaleDetail : DevExpress.XtraEditors.XtraForm
    {
        public SaleDetail()
        {
            InitializeComponent();
        }

        private void SaleDetail_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(dateStart, "Эхлэх огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(dateEnd, "Хүртэл огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);

            dateStart.Text = Convert.ToDateTime(PharmacyFun._startDateAccountPeriod()).ToString("yyyy-MM-dd");

            DBRes._FillTable("SELECT * FROM tUsers WHERE GroupID=3", "Users");
            lookPosUser.Properties.DataSource = DBRes.DS.Tables["Users"];
            lookPosUser.Properties.ValueMember = "UserID";
            lookPosUser.Properties.DisplayMember = "Firstname";

            //Discount
            Codes.DBRes._FillTable("SELECT A.*,(B.Name)PrinterName  FROM tSystemInfo A INNER JOIN tPrinter B ON(B.PrintID=A.PrinterID)", "SystemInfo");
            if (!Convert.ToBoolean(Codes.DBRes.DS.Tables["SystemInfo"].Rows[0]["NDDiscount"]))
            {
                layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void SaleDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._saledetail = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            string wStatus="";
            if (chbDiscount.Checked)
                wStatus = " AND B.Status=2";
            else wStatus = " AND B.Status=1";
            if (!PharmacyFun._checkAccountingPeriod(dateStart.Text.Trim() + " 00:00:00")) return;
            if (Convert.ToDateTime(dateStart.Text) > Convert.ToDateTime(dateEnd.Text))
            {
                XtraMessageBox.Show("Хүртэлх огноо эхлэх огнооноос бага байж болохгүй.", "Огноо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmdText = "SELECT ROW_NUMBER() OVER(ORDER BY A.SaleDetailID ASC) AS RowNum, "
                + " A.*,B.UserID,(C.Name + ' - ' + ISNULL(C.Size,''))NameSize FROM tSaleDetail A "
                + " INNER JOIN tSaleInvoice B WITH(NOLOCK) ON(B.SaleInvoiceID=A.SaleInvoiceID) "
                + " INNER JOIN tDrug C WITH(NOLOCK) ON(C.DrugID=A.DrugID) "
                + " WHERE A.ActionDate>='" + dateStart.Text.Trim() + "' AND A.ActionDate<='" + dateEnd.Text.Trim() + " 23:59:59' "
                + wStatus;
            if (Convert.ToInt32(lookPosUser.EditValue) != 0)
                cmdText = cmdText + " AND B.UserID=" + lookPosUser.EditValue;
            DBRes._FillTable(cmdText, "SaleDetail");
            gridSaleDetail.DataSource = DBRes.DS.Tables["SaleDetail"];
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(54)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridSaleDetail.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridSaleDetail.ShowPrintPreview();
        }

        private void SaleDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

    }
}