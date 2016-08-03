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
    public partial class DrugType : DevExpress.XtraEditors.XtraForm
    {
        private int TypeID;
        public DrugType()
        {
            InitializeComponent();
        }

        private void checkValidate()
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtName, "Төрлийин нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtShotname, "Төрлийин товч нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
        }

        private void DrugType_Load(object sender, EventArgs e)
        {
            checkValidate();

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum,* FROM tDrugType", "DrugType");
            gridType.DataSource = DBRes.DS.Tables["DrugType"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridType_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewType == null || gridViewType.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewType.SelectedRowsCount];
            for (int i = 0; i < gridViewType.SelectedRowsCount; i++)
            {
                rows[i] = gridViewType.GetDataRow(gridViewType.GetSelectedRows()[i]);
            }
            gridViewType.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                btnSave.Text = "Хадгалах";
                TypeID = Convert.ToInt32(row["TypeID"]);
                txtName.Text = row["Name"].ToString();
                txtShotname.Text = row["Shot"].ToString();
            }
            gridViewType.EndSort();
            gridType.Enabled = false;
            checkValidate();
        }

        private void gridType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (!PharmacyFun._checkPermission(6)) return;
                DataRow[] rows;
                if (gridViewType != null && gridViewType.SelectedRowsCount != 0)
                {
                    if (XtraMessageBox.Show("Уг эмийн төрлийн мэдээлэлийг устгах гэж байгаадаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rows = new DataRow[gridViewType.SelectedRowsCount];
                        for (int i = 0; i < gridViewType.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewType.GetDataRow(gridViewType.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            String[] spPName = new String[] { "TypeID" };
                            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                            Object[] spPValue = new Object[] { Convert.ToInt32(row["TypeID"]) };
                            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                            if (DBRes._ParamProcedure("DELETE FROM tDrugType WHERE TypeID=@TypeID", CommandType.Text))
                                row.Delete();
                            else XtraMessageBox.Show("Уг эмийн төрлийг устгах боломжгүй.", "Эмийн төрөл устгах", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            String[] spPName = new String[] { "TypeID", "Name", "Shot" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar };
            Object[] spPValue = new Object[] { TypeID, txtName.Text.Trim(), txtShotname.Text.Trim() };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (btnSave.Text == "Бүртгэх")
            {
                if (!PharmacyFun._checkPermission(4)) return;
                if (DBRes._ParamProcedure("INSERT INTO tDrugType (Name,Shot) VALUES(@Name,@Shot)", CommandType.Text))
                {
                    txtName.Focus();
                    txtName.Text = String.Empty;
                    txtShotname.Text = String.Empty;
                    DrugType_Load(sender, e);
                }
                else XtraMessageBox.Show("Эмийн төрөл бүртгэх үед алдаа гарлаа.", "Эмийн төрөл бүртгэх", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!PharmacyFun._checkPermission(5)) return;
                string cmdText = "UPDATE tDrugType SET Name=@Name,Shot=@Shot WHERE TypeID=@TypeID";
                if (DBRes._ParamProcedure(cmdText, CommandType.Text))
                {
                    txtName.Focus();
                    txtName.Text = String.Empty;
                    txtShotname.Text = String.Empty;

                    btnSave.Text = "Бүртгэх";

                    gridType.Enabled = true;

                    DrugType_Load(sender, e);
                }
                else XtraMessageBox.Show("Эмийн төрөл засварлах үед алдаа гарлаа.", "Эмийн төрөл засварлах", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(44)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridType.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridType.ShowPrintPreview();
        }

    }
}