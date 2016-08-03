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
    public partial class ExpirationDrug : DevExpress.XtraEditors.XtraForm
    {
        private int ExpirationDrugID;
        public ExpirationDrug()
        {
            InitializeComponent();
        }

        private void ExpirationDrug_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(lookDrugID, "Эмийн нэр сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtCount, "Тоо ширхэг оруулаагүй байна.", ConditionOperator.IsNotBlank);

            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY B.Name ASC)RowNum, "
                + " A.*,(B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSizePackage, "
                + " C.Firstname FROM tExpirationDrug A "
                + " INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                + " INNER JOIN tUsers C ON(C.UserID=A.UserID) "
                + " WHERE ActionDate>='" + DateTime.Now.ToString("yyyy-MM-dd")
                + " 00:00:00' AND ActionDate<='" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59'", "ExpirationDrug");
            gridExpirationDrug.DataSource = DBRes.DS.Tables["ExpirationDrug"];

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum,DrugID, "
                + " (Name+' '+ISNULL(Size,'')+' '+ISNULL(Package,''))NameSizePackage,Price,InterName,Vendor FROM tDrug", "DrugExpiration");
            lookDrugID.Properties.DataSource = DBRes.DS.Tables["DrugExpiration"];
            lookDrugID.Properties.ValueMember = "DrugID";
            lookDrugID.Properties.DisplayMember = "NameSizePackage";
        }

        private void ExpirationDrug_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void gridExpirationDrug_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewExpirationDrug == null || gridViewExpirationDrug.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewExpirationDrug.SelectedRowsCount];
            for (int i = 0; i < gridViewExpirationDrug.SelectedRowsCount; i++)
            {
                rows[i] = gridViewExpirationDrug.GetDataRow(gridViewExpirationDrug.GetSelectedRows()[i]);
            }
            gridViewExpirationDrug.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                btnAdd.Text = "Хадгалах";
                ExpirationDrugID = Convert.ToInt32(row["ExpirationDrugID"]);
                lookDrugID.EditValue = Convert.ToInt32(row["DrugID"]);
                txtCount.Text = row["Count"].ToString();
                txtPrice.Text = row["Price"].ToString();
            }
            gridViewExpirationDrug.EndSort();
            gridExpirationDrug.Enabled = false;
        }

        private void gridExpirationDrug_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (!PharmacyFun._checkPermission(80)) return;
                DataRow[] rows;
                if (gridViewExpirationDrug != null && gridViewExpirationDrug.SelectedRowsCount != 0)
                {
                    if (XtraMessageBox.Show("Уг хугацаа нь дууссан эмийг бүртгэлийн мэдээлэлээс устгах гэж байгаадаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rows = new DataRow[gridViewExpirationDrug.SelectedRowsCount];
                        for (int i = 0; i < gridViewExpirationDrug.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewExpirationDrug.GetDataRow(gridViewExpirationDrug.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            String[] spPName = new String[] { "ExpirationDrugID" };
                            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                            Object[] spPValue = new Object[] { Convert.ToInt32(row["ExpirationDrugID"]) };
                            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                            if (DBRes._ParamProcedure("DELETE FROM tExpirationDrug WHERE ExpirationDrugID=@ExpirationDrugID", CommandType.Text))
                                row.Delete();
                            else XtraMessageBox.Show("Хугацаа дууссан эм устгах боломжгүй.", "Хугацаа дууссан эм устгах", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            String[] spPName = new String[] { "ExpirationDrugID", "DrugID", "Count", "Price", "SumPrice", "UserID" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.Int, SqlDbType.Decimal, SqlDbType.Decimal, SqlDbType.Decimal, SqlDbType.Int };
            Object[] spPValue = new Object[] { ExpirationDrugID, lookDrugID.EditValue, txtCount.Text, txtPrice.Text, (Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtCount.Text)), DBRes.mUserID };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (btnAdd.Text == "Бүртгэх")
            {
                if (!PharmacyFun._checkPermission(78)) return;
                if (DBRes._ParamProcedure("INSERT INTO tExpirationDrug VALUES(@DrugID,@Count,@Price,@SumPrice,GETDATE(),@UserID)", CommandType.Text))
                {
                    lookDrugID.Focus();
                    lookDrugID.EditValue = 0;
                    txtCount.Text = String.Empty;
                    txtPrice.Text = String.Empty;
                    ExpirationDrug_Load(sender, e);
                }
                else XtraMessageBox.Show("Хугацаа дууссан эм бүртгэх үед алдаа гарлаа.", "Эмийн төрөл бүртгэх", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!PharmacyFun._checkPermission(79)) return;
                string cmdText = "UPDATE tExpirationDrug SET DrugID=@DrugID,Count=@Count,Price=@Price,SumPrice=@SumPrice WHERE ExpirationDrugID=@ExpirationDrugID";
                if (DBRes._ParamProcedure(cmdText, CommandType.Text))
                {
                    lookDrugID.Focus();
                    lookDrugID.EditValue = 0;
                    txtCount.Text = String.Empty;
                    txtPrice.Text = String.Empty;

                    btnAdd.Text = "Бүртгэх";

                    gridExpirationDrug.Enabled = true;

                    ExpirationDrug_Load(sender, e);
                }
                else XtraMessageBox.Show("Хугацаа дууссан эм засварлах үед алдаа гарлаа.", "Эмийн төрөл засварлах", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(81)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridExpirationDrug.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridExpirationDrug.ShowPrintPreview();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dateSearchOgnoo.Text.Trim() == String.Empty) return;
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.B.Name ASC)RowNum, "
                + " A.*,(B.Name+' '+ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSizePackage, "
                + " C.Firstname FROM tExpirationDrug A "
                + " INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                + " INNER JOIN tUsers C ON(C.UserID=A.UserID) "
                + " WHERE ActionDate>='" + dateSearchOgnoo.Text.Trim()
                + " 00:00:00' AND ActionDate<='" + dateSearchOgnoo.Text.Trim() + " 23:59:59'", "ExpirationDrug");
            gridExpirationDrug.DataSource = DBRes.DS.Tables["ExpirationDrug"];
        }

        private void lookDrugID_EditValueChanged(object sender, EventArgs e)
        {
            DataRow[] dr = DBRes.DS.Tables["DrugExpiration"].Select("DrugID=" + lookDrugID.EditValue);
            if (dr.Length > 0)
            {
                txtPrice.Text = dr[0]["Price"].ToString();
            }
        }

    }
}