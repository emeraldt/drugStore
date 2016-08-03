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
    public partial class DiscountDrug : DevExpress.XtraEditors.XtraForm
    {
        private int DiscountDrugID;
        public DiscountDrug()
        {
            InitializeComponent();
        }

        private void checkValidate()
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtBarCode, "Бар код оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtDrugName, "Эмийн нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtPackage, "Эмийн савлалт оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtPrice, "Худалдах үнэ оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(lookType, "Эмийн төрөл сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtFileNum, "Файл дугаар оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtNDDiscount, "НД хөнгөлөлт оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtMaxSize, "НД дээд хязгаар оруулаагүй байна.", ConditionOperator.IsNotBlank);
        }

        private void DiscountDrug_Load(object sender, EventArgs e)
        {
            checkValidate();

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum,* FROM tDrugType", "DrugType");
            lookType.Properties.DataSource = DBRes.DS.Tables["DrugType"];
            lookType.Properties.ValueMember = "TypeID";
            lookType.Properties.DisplayMember = "Name";

            DBRes._FillTable("SELECT A.*,B.Name NameType FROM tDiscountDrug A "
                + " INNER JOIN tDrugType B ON(B.TypeID=A.TypeID) ORDER BY Name ASC", "DiscountDrug");
            gridDiscountDrug.DataSource = DBRes.DS.Tables["DiscountDrug"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDiscount.Checked)
            {
                txtFileNum.Enabled = true;
                txtNDDiscount.Enabled = true;
                txtMaxSize.Enabled = true;
                checkValidate();
            }
            else
            {
                txtFileNum.Text = String.Empty;
                txtNDDiscount.Text = String.Empty;
                txtMaxSize.Text = String.Empty;
                txtFileNum.Enabled = false;
                txtNDDiscount.Enabled = false;
                txtMaxSize.Enabled = false;
                checkValidate();
            }
        }

        private void gridDiscountDrug_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewDiscountDrug == null || gridViewDiscountDrug.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewDiscountDrug.SelectedRowsCount];
            for (int i = 0; i < gridViewDiscountDrug.SelectedRowsCount; i++)
            {
                rows[i] = gridViewDiscountDrug.GetDataRow(gridViewDiscountDrug.GetSelectedRows()[i]);
            }
            gridViewDiscountDrug.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                btnSave.Text = "Хадгалах";
                DiscountDrugID = Convert.ToInt32(row["DiscountDrugID"]);
                txtBarCode.Text = row["BarCode"].ToString();
                txtDrugName.Text = row["Name"].ToString();
                txtInterName.Text = row["InterName"].ToString();
                lookType.EditValue = Convert.ToInt32(row["TypeID"]);
                txtPackage.Text = row["Package"].ToString();
                txtComment.Text = row["Comment"].ToString();
                txtPrice.Text = row["Price"].ToString();
                if (Convert.ToBoolean(row["IsDiscount"]) == true)
                    chbDiscount.Checked = true;
                else chbDiscount.Checked = false;
                txtFileNum.Text = row["FileNum"].ToString();
                txtNDDiscount.Text = row["NDDiscountTotal"].ToString();
                txtMaxSize.Text = row["MaxSize"].ToString();
            }
            gridViewDiscountDrug.EndSort();
            gridDiscountDrug.Enabled = false;
            checkValidate();
        }

        private void gridDiscountDrug_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (!PharmacyFun._checkPermission(12)) return;
                DataRow[] rows;
                if (gridViewDiscountDrug != null && gridViewDiscountDrug.SelectedRowsCount != 0)
                {
                    if (XtraMessageBox.Show("Хөнгөлөлттэй эмийн мэдээлэлийг устгах гэж байгаадаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rows = new DataRow[gridViewDiscountDrug.SelectedRowsCount];
                        for (int i = 0; i < gridViewDiscountDrug.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewDiscountDrug.GetDataRow(gridViewDiscountDrug.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            String[] spPName = new String[] { "DiscountDrugID" };
                            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                            Object[] spPValue = new Object[] { Convert.ToInt32(row["DiscountDrugID"]) };
                            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                            if (DBRes._ParamProcedure("DELETE FROM tDiscountDrug WHERE DiscountDrugID=@DiscountDrugID", CommandType.Text))
                                row.Delete();
                            else XtraMessageBox.Show("Хөнгөлөлттэй эмийн мэдээлэлийг устгах боломжгүй.", "Хөнгөлөлттэй эм устгах", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            bool IsDiscount = false;
            if (chbDiscount.Checked) IsDiscount = true;
            String[] spPName = new String[] { "DiscountDrugID", "BarCode", "Name", "InterName", "Package", "Comment", "Price", "IsDiscount", "FileNum", "NDDiscountTotal", "MaxSize", "TypeID" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.Decimal, SqlDbType.Bit, SqlDbType.NVarChar, SqlDbType.Decimal, SqlDbType.Int, SqlDbType.TinyInt, SqlDbType.Int };
            Object[] spPValue = new Object[] { DiscountDrugID, txtBarCode.Text.Trim(), txtDrugName.Text.Trim(), txtInterName.Text.Trim(), txtPackage.Text.Trim(), txtComment.Text.Trim(), txtPrice.Text.Trim(), IsDiscount, txtFileNum.Text.Trim(), txtNDDiscount.Text.Trim(), txtMaxSize.Text.Trim(), lookType.EditValue };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (btnSave.Text == "Бүртгэх")
            {
                if (!PharmacyFun._checkPermission(10)) return;
                if (DBRes._ParamProcedure("INSERT INTO tDiscountDrug (BarCode,Name,InterName,Package,Comment,Price,IsDiscount,FileNum,NDDiscountTotal,MaxSize,TypeID) "
                        + " VALUES(@BarCode,@Name,@InterName,@Package,@Comment,@Price,@IsDiscount,@FileNum,@NDDiscountTotal,@MaxSize,@TypeID)", CommandType.Text))
                {
                    txtBarCode.Focus();
                    txtBarCode.Text = String.Empty;
                    txtDrugName.Text = String.Empty;
                    txtInterName.Text = String.Empty;
                    lookType.EditValue= 0;
                    txtPackage.Text = String.Empty;
                    txtComment.Text = String.Empty;
                    txtPrice.Text = String.Empty;
                    chbDiscount.Checked = false;
                    txtFileNum.Text = String.Empty;
                    txtNDDiscount.Text = String.Empty;
                    txtMaxSize.Text = String.Empty;
                    DiscountDrug_Load(sender, e);
                }
                else XtraMessageBox.Show("Хөнгөлөлттэй эмийн мэдээлээл бүртгэх үед алдаа гарлаа.", "Хөнгөлөлттэй эм бүртгэх", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!PharmacyFun._checkPermission(11)) return;
                string cmdText = "UPDATE tDiscountDrug SET BarCode=@BarCode,Name=@Name,InterName=@InterName,Package=@Package, "
                        + " Comment=@Comment,Price=@Price,IsDiscount=@IsDiscount,FileNum=@FileNum,NDDiscountTotal=@NDDiscountTotal, "
                        + " MaxSize=@MaxSize,TypeID=@TypeID WHERE DiscountDrugID=@DiscountDrugID";
                if (DBRes._ParamProcedure(cmdText, CommandType.Text))
                {
                    txtBarCode.Focus();
                    txtBarCode.Text = String.Empty;
                    txtDrugName.Text = String.Empty;
                    txtInterName.Text = String.Empty;
                    lookType.EditValue = 0;
                    txtPackage.Text = String.Empty;
                    txtComment.Text = String.Empty;
                    txtPrice.Text = String.Empty;
                    chbDiscount.Checked = false;
                    txtFileNum.Text = String.Empty;
                    txtNDDiscount.Text = String.Empty;
                    txtMaxSize.Text = String.Empty;
                    DiscountDrug_Load(sender, e);

                    btnSave.Text = "Бүртгэх";

                    gridDiscountDrug.Enabled = true;

                    DiscountDrug_Load(sender, e);
                }
                else XtraMessageBox.Show("Хөнгөлөлттэй эмийн мэдээлээл засварлах үед алдаа гарлаа.", "Хөнгөлөлттэй эм засварлах", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(46)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridDiscountDrug.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridDiscountDrug.ShowPrintPreview();
        }

        private void btnDrugTypeAdd_Click(object sender, EventArgs e)
        {
            DrugType drugtype = new DrugType();
            drugtype.ShowDialog();
            DBRes._FillTable("SELECT * FROM tDrugType", "DrugType");
            lookType.Properties.DataSource = DBRes.DS.Tables["DrugType"];
            lookType.Properties.ValueMember = "TypeID";
            lookType.Properties.DisplayMember = "Name";
        }
        
    }
}