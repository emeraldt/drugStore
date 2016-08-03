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
    public partial class DrugUnit : DevExpress.XtraEditors.XtraForm
    {
        private int UnitID;
        public DrugUnit()
        {
            InitializeComponent();
        }

        private void checkValidate()
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtName, "Хэмжих нэгжийн нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtShotname, "Хэмжих нэгжийн товч нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
        }

        private void DrugUnit_Load(object sender, EventArgs e)
        {
            checkValidate();

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum,* FROM tDrugUnit", "DrugUnit");
            gridUnit.DataSource = DBRes.DS.Tables["DrugUnit"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridUnit_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewUnit == null || gridViewUnit.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewUnit.SelectedRowsCount];
            for (int i = 0; i < gridViewUnit.SelectedRowsCount; i++)
            {
                rows[i] = gridViewUnit.GetDataRow(gridViewUnit.GetSelectedRows()[i]);
            }
            gridViewUnit.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                btnSave.Text = "Хадгалах";
                UnitID = Convert.ToInt32(row["UnitID"]);
                txtName.Text = row["Name"].ToString();
                txtShotname.Text = row["Shot"].ToString();
            }
            gridViewUnit.EndSort();
            gridUnit.Enabled = false;
            checkValidate();
        }

        private void gridUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (!PharmacyFun._checkPermission(9)) return;
                DataRow[] rows;
                if (gridViewUnit != null && gridViewUnit.SelectedRowsCount != 0)
                {
                    if (XtraMessageBox.Show("Уг эмийн хэмжих нэгжийн мэдээлэлийг устгах гэж байгаадаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rows = new DataRow[gridViewUnit.SelectedRowsCount];
                        for (int i = 0; i < gridViewUnit.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewUnit.GetDataRow(gridViewUnit.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            String[] spPName = new String[] { "UnitID" };
                            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                            Object[] spPValue = new Object[] { Convert.ToInt32(row["UnitID"]) };
                            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                            if (DBRes._ParamProcedure("DELETE FROM tDrugUnit WHERE UnitID=@UnitID", CommandType.Text))
                                row.Delete();
                            else XtraMessageBox.Show("Уг эмийн хэмжих нэгжийг устгах боломжгүй.", "Эмийн хэмжих нэгж устгах", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            String[] spPName = new String[] { "UnitID", "Name", "Shot" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar };
            Object[] spPValue = new Object[] { UnitID, txtName.Text.Trim(), txtShotname.Text.Trim() };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (btnSave.Text == "Бүртгэх")
            {
                if (!PharmacyFun._checkPermission(7)) return;
                if (DBRes._ParamProcedure("INSERT INTO tDrugUnit (Name,Shot) VALUES(@Name,@Shot)", CommandType.Text))
                {
                    txtName.Focus();
                    txtName.Text = String.Empty;
                    txtShotname.Text = String.Empty;
                    DrugUnit_Load(sender, e);
                }
                else XtraMessageBox.Show("Эмийн төрөл бүртгэх үед алдаа гарлаа.", "Эмийн төрөл бүртгэх", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!PharmacyFun._checkPermission(8)) return;
                string cmdText = "UPDATE tDrugUnit SET Name=@Name,Shot=@Shot WHERE UnitID=@UnitID";
                if (DBRes._ParamProcedure(cmdText, CommandType.Text))
                {
                    txtName.Focus();
                    txtName.Text = String.Empty;
                    txtShotname.Text = String.Empty;

                    btnSave.Text = "Бүртгэх";

                    gridUnit.Enabled = true;

                    DrugUnit_Load(sender, e);
                }
                else XtraMessageBox.Show("Эмийн төрөл засварлах үед алдаа гарлаа.", "Эмийн төрөл засварлах", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(45)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridUnit.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridUnit.ShowPrintPreview();
        }
    }
}