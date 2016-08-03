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
    public partial class DiscountCustomer : DevExpress.XtraEditors.XtraForm
    {
        private int CustomerID;
        public bool IsSel = false;
        public string RegNum = "";
        public DiscountCustomer()
        {
            InitializeComponent();
        }

        private void checkValidate()
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtLastName, "Овог оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtFirstName, "Нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtRegNum, "Регистрын дугаар оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtNDDNum, "НДД дугаар оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtEMDNum, "ЭМД дугаар оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtPhone, "Утасны дугаар оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtAddress, "Хаяг оруулаагүй байна.", ConditionOperator.IsNotBlank);
        }

        private void DiscountCustomer_Load(object sender, EventArgs e)
        {
            checkValidate();

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Firstname ASC)RowNum,* FROM tDiscountCustomer", "DiscountCustomer");
            gridDiscountCustomer.DataSource = DBRes.DS.Tables["DiscountCustomer"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridDiscountCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewDiscountCustomer == null || gridViewDiscountCustomer.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewDiscountCustomer.SelectedRowsCount];
            for (int i = 0; i < gridViewDiscountCustomer.SelectedRowsCount; i++)
            {
                rows[i] = gridViewDiscountCustomer.GetDataRow(gridViewDiscountCustomer.GetSelectedRows()[i]);
            }
            gridViewDiscountCustomer.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                btnSave.Text = "Хадгалах";
                CustomerID = Convert.ToInt32(row["CustomerID"]);
                txtLastName.Text = row["LastName"].ToString();
                txtFirstName.Text = row["FirstName"].ToString();
                txtRegNum.Text = RegNum = row["RegNum"].ToString();
                txtNDDNum.Text = row["NDNum"].ToString();
                txtEMDNum.Text = row["EMDNum"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                txtAddress.Text = row["Address"].ToString();
            }
            gridViewDiscountCustomer.EndSort();
            gridDiscountCustomer.Enabled = false;
            checkValidate();
            if (IsSel) this.DialogResult = DialogResult.OK;
        }

        private void gridDiscountCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (!PharmacyFun._checkPermission(18)) return;
                DataRow[] rows;
                if (gridViewDiscountCustomer != null && gridViewDiscountCustomer.SelectedRowsCount != 0)
                {
                    if (XtraMessageBox.Show("Уг даатгуулагчын мэдээлэлийг устгах гэж байгаадаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rows = new DataRow[gridViewDiscountCustomer.SelectedRowsCount];
                        for (int i = 0; i < gridViewDiscountCustomer.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewDiscountCustomer.GetDataRow(gridViewDiscountCustomer.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            String[] spPName = new String[] { "CustomerID" };
                            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                            Object[] spPValue = new Object[] { Convert.ToInt32(row["CustomerID"]) };
                            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                            if (DBRes._ParamProcedure("DELETE FROM tDiscountCustomer WHERE CustomerID=@CustomerID", CommandType.Text))
                                row.Delete();
                            else XtraMessageBox.Show("Уг даатгуулагчын мэдээлэлийг устгах боломжгүй.", "Даатгуулагчыг устгах", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            String[] spPName = new String[] { "CustomerID", "LastName", "FirstName", "RegNum", "NDNum", "EMDNum", "Phone", "Address" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar };
            Object[] spPValue = new Object[] { CustomerID, txtLastName.Text.Trim(), txtFirstName.Text.Trim(), txtRegNum.Text.Trim(), txtNDDNum.Text.Trim(), txtEMDNum.Text.Trim(), txtPhone.Text.Trim(), txtAddress.Text.Trim() };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (btnSave.Text == "Бүртгэх")
            {
                if (!PharmacyFun._checkPermission(16)) return;
                if (DBRes._ParamProcedure("INSERT INTO tDiscountCustomer (LastName,FirstName,RegNum,NDNum,EMDNum,Phone,Address) "
                        + " VALUES(@LastName,@FirstName,@RegNum,@NDNum,@EMDNum,@Phone,@Address)", CommandType.Text))
                {
                    txtLastName.Focus();
                    txtLastName.Text = String.Empty;
                    txtFirstName.Text = String.Empty;
                    txtRegNum.Text = String.Empty;
                    txtNDDNum.Text = String.Empty;
                    txtEMDNum.Text = String.Empty;
                    txtPhone.Text = String.Empty;
                    txtAddress.Text = String.Empty;
                    DiscountCustomer_Load(sender, e);
                }
                else XtraMessageBox.Show("Даатгуулагчын мэдээлээл бүртгэх үед алдаа гарлаа.", "Даатгуулагчын мэдээлээл бүртгэх", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!PharmacyFun._checkPermission(17)) return;
                string cmdText = "UPDATE tDiscountCustomer SET LastName=@LastName,FirstName=@FirstName,RegNum=@RegNum,NDNum=@NDNum,EMDNum=@EMDNum, "
                    + " Phone=@Phone,Address=@Address WHERE CustomerID=@CustomerID";
                if (DBRes._ParamProcedure(cmdText, CommandType.Text))
                {
                    txtLastName.Focus();
                    txtLastName.Text = String.Empty;
                    txtFirstName.Text = String.Empty;
                    txtRegNum.Text = String.Empty;
                    txtNDDNum.Text = String.Empty;
                    txtEMDNum.Text = String.Empty;
                    txtPhone.Text = String.Empty;
                    txtAddress.Text = String.Empty;
                    DiscountCustomer_Load(sender, e);

                    btnSave.Text = "Бүртгэх";

                    gridDiscountCustomer.Enabled = true;

                    DiscountCustomer_Load(sender, e);
                }
                else XtraMessageBox.Show("Даатгуулагчын мэдээлээл засварлах үед алдаа гарлаа.", "Даатгуулагчын мэдээлээл засварлах", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(48)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridDiscountCustomer.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridDiscountCustomer.ShowPrintPreview();
        }

        private void DiscountCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            else if (e.KeyCode == Keys.F1)
            {
                gridDiscountCustomer.Focus();
                gridDiscountCustomer.ForceInitialize();
                gridViewDiscountCustomer.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                gridViewDiscountCustomer.FocusedColumn = gridViewDiscountCustomer.Columns.ColumnByName("RegNum");
                gridViewDiscountCustomer.ShowEditor();
            }
        }
    }
}