using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pharmacy.Codes;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Pharmacy.Pos
{
    public partial class Payment : DevExpress.XtraEditors.XtraForm
    {
        public int CardID;        

        public Payment()
        {
            InitializeComponent();
        }

        private void NormalPayment_Load(object sender, EventArgs e)
        {
            CardID = 1;
            Static.dxV.Dispose();
            Static.EmptyValidate(txtCashAmount, "Төлсөн дүн оруулаагүй байна.", ConditionOperator.IsNotBlank);

            //txtNUAT.Text = String.Format("{0:0.00}", getNuatInfo());
            //txtPayTotal.Text = String.Format("{0:0.00}", setTuluhDun());
            getNuatInfo();
        }

        private void txtDiscountCardNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                checkDiscountCard();
        }

        private void checkDiscountCard()
        {
            if (txtDiscountCardNum.Text.Trim() != String.Empty)
            {
                try
                {
                    DBRes._FillTable("SELECT * FROM tDiscountcard WHERE CardNum='" + txtDiscountCardNum.Text.Trim() + "'", "Discountcard");
                    if (DBRes.DS.Tables["Discountcard"].Rows.Count > 0)
                    {
                        CardID = Convert.ToInt32(DBRes.DS.Tables["Discountcard"].Rows[0]["CardID"]);
                        txtDiscountPrecent.Text = DBRes.DS.Tables["Discountcard"].Rows[0]["Discount"].ToString();
                        txtCardName.Text = DBRes.DS.Tables["Discountcard"].Rows[0]["LastName"].ToString().Substring(0, 1).ToUpper() + "." + DBRes.DS.Tables["Discountcard"].Rows[0]["FirstName"].ToString()
                            + " - " + DBRes.DS.Tables["Discountcard"].Rows[0]["RegNum"].ToString().ToUpper();
                        txtDiscountTotal.Text = (Convert.ToDecimal(txtTotal.Text) * Convert.ToDecimal(txtDiscountPrecent.Text) / 100).ToString();
                        txtDiscountCardNum.Enabled = false;
                        txtCashAmount.Focus();
                    }
                    else XtraMessageBox.Show(txtDiscountCardNum.Text.Trim() + " - картын дугаартай карт эзэмшигч олдсонгүй.", "Хөнгөлөлтийн карт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception) { XtraMessageBox.Show(txtDiscountCardNum.Text.Trim() + " - картын дугаартай карт эзэмшигч олдсонгүй.", "Хөнгөлөлтийн карт.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                CardID = 0;
                txtDiscountPrecent.Text = String.Empty;
                txtCardName.Text = String.Empty;
                txtCashAmount.Focus();
            }
        }

        private void txtDiscountCardNum_Leave(object sender, EventArgs e)
        {
            checkDiscountCard();
        }

        #region key down event's
        private void NormalPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            else if (e.KeyCode == Keys.F2)
                btnF2_Click(sender, e);
            else if (e.KeyCode == Keys.F4)
                btnF4_Click(sender, e);
            if (e.KeyCode == Keys.F6)
                btnF6_Click(sender, e);
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            if (!txtDiscountCardNum.Enabled)
            {
                txtDiscountCardNum.Enabled = true;
                txtDiscountCardNum.Focus();
                txtDiscountCardNum.SelectAll();
            }
            else
            {
                txtDiscountCardNum.Focus();
                txtDiscountCardNum.SelectAll();
            }
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            txtCashAmount.Focus();
            txtCashAmount.SelectAll();
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            if (Convert.ToDecimal(txtPayTotal.Text) > (Convert.ToDecimal(txtCashAmount.Text) + Convert.ToDecimal(txtNonCashAmount.Text))) return;
            if (Convert.ToInt32(rGrpBillType.EditValue) == 2 && (txtBuyerTTD.Text == "" || txtBuyerName.Text == ""))
            {
                XtraMessageBox.Show("Байгууллагын ТТД болон нэрийг заавал бөглөнө үү!");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void txtPaidTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            if ((Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtDiscountTotal.Text)) > Convert.ToDecimal(txtCashAmount.Text)) return;
            if (e.KeyCode == Keys.Enter)
                btnF6.Focus();
        }
        #endregion

        private void txtPaidTotal_EditValueChanged(object sender, EventArgs e)
        {
            if (txtCashAmount.Text.Trim() != String.Empty)
            {
                txtOddMoney.Text = ((Convert.ToDecimal(txtPayTotal.Text) - Convert.ToDecimal(txtPaidTotal.Text)) * -1).ToString("###,###,###,###,###.##");
            }
        }

        private void txtDiscountTotal_EditValueChanged(object sender, EventArgs e)
        {
            getNuatInfo();

            if (txtCashAmount.Text.Trim() != String.Empty)
            {
                txtOddMoney.Text = ((Convert.ToDecimal(txtPayTotal.Text) - Convert.ToDecimal(txtNonCashAmount.Text) - Convert.ToDecimal(txtCashAmount.Text)) * -1).ToString();
            }
            //txtPayTotal.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtDiscountTotal.Text)).ToString("###,###,###,###,###.##");
            //txtCashAmount.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtDiscountTotal.Text)).ToString("###,###,###,###,###.##");

        }

        private void txtCashAmount_EditValueChanged(object sender, EventArgs e)
        {
            double cashAmount = Convert.ToDouble(txtCashAmount.Text);
            double nonCashAmount = Convert.ToDouble(txtNonCashAmount.Text);
            
            txtPaidTotal.Text = Convert.ToString(cashAmount + nonCashAmount);
        }

        private void txtNonCashAmount_EditValueChanged(object sender, EventArgs e)
        {
            double cashAmount = Convert.ToDouble(txtCashAmount.Text);
            double nonCashAmount = Convert.ToDouble(txtNonCashAmount.Text);

            txtPaidTotal.Text = Convert.ToString(cashAmount + nonCashAmount);
        }

        private void getNuatInfo()
        {
            double nuatDun = 0;
            var table = new DataTable();
            var cmd = new SqlDataAdapter("select * from tSystemInfo", DBRes.sql_conn);

            try
            {
                cmd.Fill(table);

                bool nuatTulugch = Convert.ToBoolean(table.Rows[0]["NuatTulugch"]);
                bool nuatOrson = Convert.ToBoolean(table.Rows[0]["NuatOrson"]);

                if (nuatTulugch == true && nuatOrson == true)
                {
                    txtNUAT.Text = String.Format("{0:0.00}", (Convert.ToDouble(txtTotal.Text) / 1.1) * 0.1);
                    txtPayTotal.Text = String.Format("{0:0.00}", txtTotal.Text);
                }

                if (nuatTulugch == true && nuatOrson == false)
                {
                    txtNUAT.Text = String.Format("{0:0.00}", Convert.ToDouble(txtTotal.Text) * 0.1);
                    txtPayTotal.Text = String.Format("{0:0.00}", Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(txtNUAT.Text));
                }

                if (!nuatTulugch)
                {
                    txtNUAT.Text = "0.00";
                    txtPayTotal.Text = String.Format("{0:0.00}", txtTotal.Text);
                }
                
            }
            catch { }            
            
            //return nuatDun;
        }

        private double setTuluhDun()
        {
            double totalAmount = Convert.ToDouble(txtTotal.Text);
            double totalDiscount = Convert.ToDouble(txtDiscountTotal.Text);
            double nuat = Convert.ToDouble(txtNUAT.Text);

            double tuluhDun = totalAmount - totalDiscount + nuat;

            return tuluhDun;
        }

        private void rGrpBillType_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(rGrpBillType.EditValue) == 1)
                panelControlBuyer.Visible = false;
            else panelControlBuyer.Visible = true;
        }
    }
}