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
    public partial class ChangePrice : DevExpress.XtraEditors.XtraForm
    {
        public ChangePrice()
        {
            InitializeComponent();
        }

        private void ChangePrice_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(lookDrug, "Эм сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtBalance, "Эм үлдэгдэлийн мэдээлэл байхгүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtNewPrice, "Зарах шинэ үнэ оруулаагүй байна.", ConditionOperator.IsNotBlank);

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum,* FROM tDrug", "lookDrug");
            lookDrug.Properties.DataSource = DBRes.DS.Tables["lookDrug"];
            lookDrug.Properties.ValueMember = "DrugID";
            lookDrug.Properties.DisplayMember = "Name";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lookDrug_EditValueChanged(object sender, EventArgs e)
        {
            if (!PharmacyFun.DrugBillV("balanceInfo")) return;
            for (int i = 0; i < DBRes.DS.Tables["balanceInfo"].Rows.Count; i++)
            {
                if (Convert.ToInt32(DBRes.DS.Tables["balanceInfo"].Rows[i]["DrugID"]) == Convert.ToInt32(lookDrug.EditValue))
                {
                    txtBalance.Text = DBRes.DS.Tables["balanceInfo"].Rows[i]["Balance"].ToString();
                    DBRes._FillTable("SELECT * FROM tDrug WHERE DrugID=" + lookDrug.EditValue, "Drug");
                    if (DBRes.DS.Tables["Drug"].Rows.Count > 0)
                    {
                        txtOldPrice.Text = DBRes.DS.Tables["Drug"].Rows[0]["Price"].ToString();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(29)) return;
            if (!Static.dxV.Validate()) return;
            if (XtraMessageBox.Show("Эмийн борлуулалтын үнэ өөрчлөх гэж байна. Өөрчлөх үү?", "Үнэ өөрчлөх", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String[] spPName = new String[] { "DrugID", "Count", "OldPrice", "Price", "ActionDate", "UserID" };
                SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.Decimal, SqlDbType.Decimal, SqlDbType.Decimal, SqlDbType.DateTime, SqlDbType.Int };
                Object[] spPValue = new Object[] { lookDrug.EditValue, txtBalance.Text, txtOldPrice.Text, txtNewPrice.Text.Trim(), DateTime.Now, DBRes.mUserID };
                if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                if (DBRes._ParamProcedure("INSERT INTO tChangePrice VALUES(@Count,@OldPrice,@Price,@ActionDate,@DrugID,@UserID)"
                    + "UPDATE tDrug SET Price=@Price WHERE DrugID=@DrugID", CommandType.Text))
                {
                    XtraMessageBox.Show("Эмийн борлуулалтын үнэ амжилттай өөрчлөгдлөө.", "Үнэ өөрчлөх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnDrugList_Click(object sender, EventArgs e)
        {
            DrugList druglist = new DrugList();
            if (druglist.ShowDialog() == DialogResult.OK)
            {
                lookDrug.EditValue = druglist.gridViewDrug.GetFocusedRowCellValue("DrugID");
                txtNewPrice.Focus();
            }
        }

        private void ChangePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                btnDrugList_Click(sender, e);
        }

    }
}