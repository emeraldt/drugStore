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
    public partial class Supplier : DevExpress.XtraEditors.XtraForm
    {
        private int SupplierID;
        public Supplier()
        {
            InitializeComponent();
        }

        private void checkValidate()
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtName, "Хэмжих нэгжийн нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            checkValidate();

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum,* FROM tSupplier", "Supplier");
            gridSupplier.DataSource = DBRes.DS.Tables["Supplier"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridSupplier_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewSupplier == null || gridViewSupplier.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewSupplier.SelectedRowsCount];
            for (int i = 0; i < gridViewSupplier.SelectedRowsCount; i++)
            {
                rows[i] = gridViewSupplier.GetDataRow(gridViewSupplier.GetSelectedRows()[i]);
            }
            gridViewSupplier.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                btnSave.Text = "Хадгалах";
                SupplierID = Convert.ToInt32(row["SupplierID"]);
                txtName.Text = row["Name"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                txtNOATNum.Text = row["TAXNO"].ToString();
                txtBankname.Text = row["BankName"].ToString();
                txtAccountNum.Text = row["AccountNo"].ToString();
                txtAddress.Text = row["Address"].ToString();
            }
            gridViewSupplier.EndSort();
            gridSupplier.Enabled = false;
            checkValidate();
        }

        private void gridSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (!PharmacyFun._checkPermission(15)) return;
                DataRow[] rows;
                if (gridViewSupplier != null && gridViewSupplier.SelectedRowsCount != 0)
                {
                    if (XtraMessageBox.Show("Уг нийлүүлэгчийн мэдээлэлийг устгах гэж байгаадаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rows = new DataRow[gridViewSupplier.SelectedRowsCount];
                        for (int i = 0; i < gridViewSupplier.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewSupplier.GetDataRow(gridViewSupplier.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            String[] spPName = new String[] { "SupplierID" };
                            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                            Object[] spPValue = new Object[] { Convert.ToInt32(row["SupplierID"]) };
                            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                            if (DBRes._ParamProcedure("DELETE FROM tSupplier WHERE SupplierID=@SupplierID", CommandType.Text))
                                row.Delete();
                            else XtraMessageBox.Show("Уг нийлүүлэгчийг устгах боломжгүй.", "Нийлүүлэгчийн устгах", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            String[] spPName = new String[] { "SupplierID", "Name", "Phone", "TAXNO", "BankName", "AccountNo", "Address" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar };
            Object[] spPValue = new Object[] { SupplierID, txtName.Text.Trim(), txtPhone.Text.Trim(), txtNOATNum.Text.Trim(), txtBankname.Text.Trim(), txtAccountNum.Text.Trim(), txtAddress.Text.Trim() };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (btnSave.Text == "Бүртгэх")
            {
                if (!PharmacyFun._checkPermission(13)) return;
                if (DBRes._ParamProcedure("INSERT INTO tSupplier (Name,Phone,TAXNO,BankName,AccountNo,Address) VALUES(@Name,@Phone,@TAXNO,@BankName,@AccountNo,@Address)", CommandType.Text))
                {
                    txtName.Focus();
                    txtName.Text = String.Empty;
                    txtPhone.Text = String.Empty;
                    txtNOATNum.Text = String.Empty;
                    txtBankname.Text = String.Empty;
                    txtAccountNum.Text = String.Empty;
                    txtAddress.Text = String.Empty;
                    Supplier_Load(sender, e);
                }
                else XtraMessageBox.Show("Нийлүүлэгч бүртгэх үед алдаа гарлаа.", "Нийлүүлэгч бүртгэх", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!PharmacyFun._checkPermission(14)) return;
                string cmdText = "UPDATE tSupplier SET Name=@Name,Phone=@Phone,TAXNO=@TAXNO,BankName=@BankName,AccountNo=@AccountNo,Address=@Address WHERE SupplierID=@SupplierID";
                if (DBRes._ParamProcedure(cmdText, CommandType.Text))
                {
                    txtName.Focus();
                    txtName.Text = String.Empty;
                    txtPhone.Text = String.Empty;
                    txtNOATNum.Text = String.Empty;
                    txtBankname.Text = String.Empty;
                    txtAccountNum.Text = String.Empty;
                    txtAddress.Text = String.Empty;

                    btnSave.Text = "Бүртгэх";

                    gridSupplier.Enabled = true;

                    Supplier_Load(sender, e);
                }
                else XtraMessageBox.Show("Нийлүүлэгч засварлах үед алдаа гарлаа.", "Нийлүүлэгч засварлах", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(47)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridSupplier.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridSupplier.ShowPrintPreview();
        }
    }
}