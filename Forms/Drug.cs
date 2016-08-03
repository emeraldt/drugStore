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
    public partial class Drug : DevExpress.XtraEditors.XtraForm
    {
        private int DrugID;
        public Drug()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmpVal()
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtName, "Нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtPrice, "Зарах үнэ оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(lookType, "Төрөл сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(lookUnit, "Хэмжих нэгж сонгоогүй байна.", ConditionOperator.IsNotBlank);
        }

        private void Drug_Load(object sender, EventArgs e)
        {
            EmpVal();

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum,* FROM tDrugType", "DrugType");
            lookType.Properties.DataSource = DBRes.DS.Tables["DrugType"];
            lookType.Properties.ValueMember = "TypeID";
            lookType.Properties.DisplayMember = "Name";

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum,* FROM tDrugUnit", "DrugUnit");
            lookUnit.Properties.DataSource = DBRes.DS.Tables["DrugUnit"];
            lookUnit.Properties.ValueMember = "UnitID";
            lookUnit.Properties.DisplayMember = "Name";
        }

        private void btnDrugList_Click(object sender, EventArgs e)
        {
            if (Static._druglist == null)
            {
                DrugList druglist = new DrugList();
                druglist.ShowInTaskbar = false;
                if (druglist.ShowDialog() == DialogResult.OK)
                {
                    DataRow[] rows;
                    try
                    {
                        if (druglist.gridViewDrug == null && druglist.gridViewDrug.SelectedRowsCount == 0) return;
                        rows = new DataRow[druglist.gridViewDrug.SelectedRowsCount];
                        for (int i = 0; i < druglist.gridViewDrug.SelectedRowsCount; i++)
                        {
                            rows[i] = druglist.gridViewDrug.GetDataRow(druglist.gridViewDrug.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            if (row == null) return;
                            DrugID = Convert.ToInt32(row["DrugID"]);
                            txtName.Text = row["Name"].ToString();
                            txtPrice.Text = row["Price"].ToString();
                            if (Convert.ToBoolean(row["IsDiscount"]) == true)
                                chbDiscount.Checked = true;
                            else chbDiscount.Checked = false;
                            lookType.EditValue = Convert.ToInt32(row["TypeID"]);
                            lookUnit.EditValue = Convert.ToInt32(row["UnitID"]);

                            txtBaarCode.Text = row["BaarCode"].ToString();
                            txtIntername.Text = row["InterName"].ToString();
                            txtVendor.Text = row["Vendor"].ToString();
                            txtSize.Text = row["Size"].ToString();
                            txtPackage.Text = row["Package"].ToString();
                            txtComment.Text = row["Comment"].ToString();
                        }
                    }
                    catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Системийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    this.Text = "Эм засварлах";
                    btnSave.Text = "Хадгалах";
                    txtPrice.Enabled = false;
                    chbEditPrice.Enabled = true;
                }
            }
            else XtraMessageBox.Show("Эмийн жагсаалтын цонх нээлттэй байна.", "Эмийн жагсаалт", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            bool IsDiscount = false;
            if (chbDiscount.Checked) IsDiscount = true;
            String[] spPName = new String[] { "DrugID", "BaarCode", "Name", "InterName", "Vendor", "Size", "Package", "Price", "Comment", "IsDiscount", "TypeID", "UnitID" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.Decimal, SqlDbType.NVarChar, SqlDbType.Bit, SqlDbType.Int, SqlDbType.Int };
            Object[] spPValue = new Object[] { DrugID, txtBaarCode.Text.Trim(), txtName.Text.Trim(), txtIntername.Text.Trim(), txtVendor.Text.Trim(), txtSize.Text.Trim(), txtPackage.Text.Trim(), txtPrice.Text.Trim(), txtComment.Text.Trim(), IsDiscount, lookType.EditValue, lookUnit.EditValue };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (btnSave.Text == "Бүртгэх")
            {
                if (!PharmacyFun._checkPermission(1)) return;
                if (DBRes._ParamProcedure("INSERT INTO tDrug (BaarCode,Name,InterName,Vendor,Size,Package,Price,Comment,IsDiscount,TypeID,UnitID)"
                    + " VALUES(@BaarCode,@Name,@InterName,@Vendor,@Size,@Package,@Price,@Comment,@IsDiscount,@TypeID,@UnitID)", CommandType.Text))
                {
                    txtName.Focus();
                    txtName.Text = String.Empty;
                    txtPrice.Text = String.Empty;
                    chbDiscount.Checked = false;
                    lookType.EditValue = 0;
                    lookUnit.EditValue = 0;
                    txtBaarCode.Text = String.Empty;
                    txtIntername.Text = String.Empty;
                    txtVendor.Text = String.Empty;
                    txtSize.Text = String.Empty;
                    txtPackage.Text = String.Empty;
                    txtComment.Text = String.Empty;
                    XtraMessageBox.Show("Эмийн бүртгэл амжилттай хийгдлээ. Эмийн жагсаалтаас үзнэ үү.", "Эм бүртгэх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else XtraMessageBox.Show("Эм бүртгэх үед алдаа гарлаа.", "Эм бүртгэх", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!PharmacyFun._checkPermission(2)) return;
                string cmdText = "UPDATE tDrug SET BaarCode=@BaarCode,Name=@Name,InterName=@InterName,Vendor=@Vendor, "
                    + " Size=@Size,Package=@Package,Price=@Price,Comment=@Comment,IsDiscount=@IsDiscount,TypeID=@TypeID, "
                    + " UnitID=@UnitID WHERE DrugID=@DrugID";
                if (DBRes._ParamProcedure(cmdText, CommandType.Text))
                {
                    txtName.Focus();
                    txtName.Text = String.Empty;
                    txtPrice.Text = String.Empty;
                    chbDiscount.Checked = false;
                    lookType.EditValue = 0;
                    lookUnit.EditValue = 0;
                    txtBaarCode.Text = String.Empty;
                    txtIntername.Text = String.Empty;
                    txtVendor.Text = String.Empty;
                    txtSize.Text = String.Empty;
                    txtPackage.Text = String.Empty;
                    txtComment.Text = String.Empty;
                    this.Text = "Эмийн бүртгэл";
                    btnSave.Text = "Бүртгэх";
                    chbEditPrice.Enabled = false;
                    chbEditPrice.Checked = false;
                    XtraMessageBox.Show("Эм засварлах үйлдэл амжилттай хийгдлээ. Эмийн жагсаалтаас үзнэ үү.", "Эм засварлах", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnSave.Text = "Бүртгэх";
                }
                else XtraMessageBox.Show("Эм засварлах үед алдаа гарлаа.", "Эм засварлах", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbEditPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEditPrice.Checked)
            {
                if (DBRes.mRole != 3)
                {
                    txtPrice.Enabled = true;
                    chbEditPrice.Enabled = false;
                }
                else
                {
                    XtraMessageBox.Show("Эмийн үнэ засварлах эрхгүй байна.", "Хэрэглэгчийн эрх", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chbEditPrice.Checked = false;
                }
            }
        }

        private void btnDrugTypeAdd_Click(object sender, EventArgs e)
        {
            DrugType drugtype = new DrugType();
            drugtype.ShowDialog();
            DBRes._FillTable("SELECT * FROM tDrugType", "DrugType");
            lookType.Properties.DataSource = DBRes.DS.Tables["DrugType"];
            lookType.Properties.ValueMember = "TypeID";
            lookType.Properties.DisplayMember = "Name";
            EmpVal();
        }

        private void btnDrugUnitAdd_Click(object sender, EventArgs e)
        {
            DrugUnit drugunit = new DrugUnit();
            drugunit.ShowDialog();
            DBRes._FillTable("SELECT * FROM tDrugUnit", "DrugUnit");
            lookUnit.Properties.DataSource = DBRes.DS.Tables["DrugUnit"];
            lookUnit.Properties.ValueMember = "UnitID";
            lookUnit.Properties.DisplayMember = "Name";
            EmpVal();
        }
    }
}