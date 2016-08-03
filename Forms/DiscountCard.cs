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
    public partial class DiscountCard : DevExpress.XtraEditors.XtraForm
    {
        private int CardID;
        public DiscountCard()
        {
            InitializeComponent();
        }

        private void checkValidate()
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtLastname, "Овог оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtFirstname, "Нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtRegnum, "Регистрын дугаар оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtCardnum, "Картын дугаар оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtDiscountProcent, "Хөнгөлөлтийн хувь оруулаагүй байна.", ConditionOperator.IsNotBlank);
        }

        private void DiscountCard_Load(object sender, EventArgs e)
        {
            checkValidate();

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Firstname ASC)RowNum,* FROM tDiscountcard WHERE CardID<>1", "Discountcard");
            gridDiscountCard.DataSource = DBRes.DS.Tables["Discountcard"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridDiscountCard_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewDiscountCard == null || gridViewDiscountCard.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewDiscountCard.SelectedRowsCount];
            for (int i = 0; i < gridViewDiscountCard.SelectedRowsCount; i++)
            {
                rows[i] = gridViewDiscountCard.GetDataRow(gridViewDiscountCard.GetSelectedRows()[i]);
            }
            gridViewDiscountCard.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                btnSave.Text = "Хадгалах";
                CardID = Convert.ToInt32(row["CardID"]);
                txtLastname.Text = row["LastName"].ToString();
                txtFirstname.Text = row["FirstName"].ToString();
                txtRegnum.Text = row["RegNum"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                txtCardnum.Text = row["CardNum"].ToString();
                txtDiscountProcent.Text = row["Discount"].ToString();
                txtAddress.Text = row["Address"].ToString();
            }
            gridViewDiscountCard.EndSort();
            gridDiscountCard.Enabled = false;
            checkValidate();
        }

        private void gridDiscountCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (!PharmacyFun._checkPermission(21)) return;
                DataRow[] rows;
                if (gridViewDiscountCard != null && gridViewDiscountCard.SelectedRowsCount != 0)
                {
                    if (XtraMessageBox.Show("Уг хөнгөлөлтийн картын мэдээлэлийг устгах гэж байгаадаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rows = new DataRow[gridViewDiscountCard.SelectedRowsCount];
                        for (int i = 0; i < gridViewDiscountCard.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewDiscountCard.GetDataRow(gridViewDiscountCard.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            String[] spPName = new String[] { "CardID" };
                            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                            Object[] spPValue = new Object[] { Convert.ToInt32(row["CardID"]) };
                            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                            if (DBRes._ParamProcedure("DELETE FROM tDiscountcard WHERE CardID=@CardID", CommandType.Text))
                                row.Delete();
                            else XtraMessageBox.Show("Уг хөнгөлөлтийн картыг устгах боломжгүй.", "Хөнгөлөлтийн карт устгах", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;

            DBRes._FillTable("SELECT * FROM tDiscountcard WHERE CardNum='" + txtCardnum.Text.Trim() + "'", "checkCardNum");
            if (DBRes.DS.Tables["checkCardNum"].Rows.Count > 0)
            {
                XtraMessageBox.Show(txtCardnum.Text + "- гэсэн картын дугаар бүртгэгдсэн байна.", "Хэрэглэгчийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String[] spPName = new String[] { "CardID", "LastName", "FirstName", "RegNum", "Phone", "CardNum", "Discount", "Address" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.Int, SqlDbType.NVarChar };
            Object[] spPValue = new Object[] { CardID, txtLastname.Text.Trim(), txtFirstname.Text.Trim(), txtRegnum.Text.Trim(), txtPhone.Text.Trim(), txtCardnum.Text.Trim(), txtDiscountProcent.Text.Trim(), txtAddress.Text.Trim() };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (btnSave.Text == "Бүртгэх")
            {
                if (!PharmacyFun._checkPermission(19)) return;
                if (DBRes._ParamProcedure("INSERT INTO tDiscountcard (LastName,FirstName,RegNum,Phone,CardNum,Discount,Address) "
                        + " VALUES(@LastName,@FirstName,@RegNum,@Phone,@CardNum,@Discount,@Address)", CommandType.Text))
                {
                    txtLastname.Focus();
                    txtLastname.Text = String.Empty;
                    txtFirstname.Text = String.Empty;
                    txtRegnum.Text = String.Empty;
                    txtPhone.Text = String.Empty;
                    txtCardnum.Text = String.Empty;
                    txtDiscountProcent.Text = String.Empty;
                    txtAddress.Text = String.Empty;
                    DiscountCard_Load(sender, e);
                }
                else XtraMessageBox.Show("Хөнгөлөлтийн карт бүртгэх үед алдаа гарлаа.", "Хөнгөлөлтийн карт бүртгэх", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!PharmacyFun._checkPermission(20)) return;
                string cmdText = "UPDATE tDiscountcard SET LastName=@LastName,FirstName=@FirstName,RegNum=@RegNum,Phone=@Phone, "
                        + " CardNum=@CardNum,Discount=@Discount,Address=@Address WHERE CardID=@CardID";
                if (DBRes._ParamProcedure(cmdText, CommandType.Text))
                {
                    txtLastname.Focus();
                    txtLastname.Text = String.Empty;
                    txtFirstname.Text = String.Empty;
                    txtRegnum.Text = String.Empty;
                    txtPhone.Text = String.Empty;
                    txtCardnum.Text = String.Empty;
                    txtDiscountProcent.Text = String.Empty;
                    txtAddress.Text = String.Empty;
                    DiscountCard_Load(sender, e);

                    btnSave.Text = "Бүртгэх";

                    gridDiscountCard.Enabled = true;

                    DiscountCard_Load(sender, e);
                }
                else XtraMessageBox.Show("Хөнгөлөлтийн карт засварлах үед алдаа гарлаа.", "Хөнгөлөлтийн карт засварлах", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(49)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridDiscountCard.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridDiscountCard.ShowPrintPreview();
        }
    }
}