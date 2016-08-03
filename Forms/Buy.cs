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
    public partial class Buy : DevExpress.XtraEditors.XtraForm
    {
        private int BuyInvoiceID;
        private int ActionType = 1;
        public Buy()
        {
            InitializeComponent();
        }

        private void EmpVal()
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(lookSupplier, "Нийлүүлэгч сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(dateDate, "Паданы огноо оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtInvoiceNum, "Паданы дугаар оруулаагүй байна.", ConditionOperator.IsNotBlank);
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            EmpVal();

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum,* FROM tSupplier", "Supplier");
            lookSupplier.Properties.DataSource = DBRes.DS.Tables["Supplier"];
            lookSupplier.Properties.ValueMember = "SupplierID";
            lookSupplier.Properties.DisplayMember = "Name";

            DBRes._FillTable("SELECT *,'' AS Status,0.0 AS SumPriceSale, 0.0 AS SumPriceHuviTootsson FROM tBuyDetail WHERE BuyDetailID=-1", "BuyDetail");
            gridBuy.DataSource = DBRes.DS.Tables["BuyDetail"];
        }

        private void Buy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnCreateInvoice.Enabled == false)
            {
                if (XtraMessageBox.Show("Орлогын цонх хаах гэж байна. Цонхыг хаах уу?", "Орлогын цонх хаах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                    this.DialogResult = DialogResult.OK;
                }
                else { e.Cancel = true; }
            }
            else
            {
                e.Cancel = false;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(22)) return;
            if (!PharmacyFun._checkAccountingPeriod(DateTime.Now.ToString())) return;
            if (!Static.dxV.Validate()) return;
            btnSupplierAdd.Enabled = false;
            lookSupplier.Enabled = false;
            dateDate.Enabled = false;
            txtInvoiceNum.Enabled = false;
            chbIsLoan.Enabled = false;
            btnCreateInvoice.Enabled = false;
            btnBuyInvoiceList.Enabled = false;
            txtAshigTootsohHuvi.Enabled = false;

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum,* FROM tDrug", "Drug");
            repositoryItemLookDrug.DataSource = DBRes.DS.Tables["Drug"];
            repositoryItemLookDrug.ValueMember = "DrugID";
            repositoryItemLookDrug.DisplayMember = "Name";

            gridBuy.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnBuyInvoiceList_Click(object sender, EventArgs e)
        {
            if (Static._buyinvoicelist == null)
            {
                BuyInvoiceList buyinvoicelist = new BuyInvoiceList();
                if (buyinvoicelist.ShowDialog() == DialogResult.OK)
                {
                    Buy_Load(sender, e);
                    txtAshigTootsohHuvi.Text = String.Empty;
                    txtAshigTootsohHuvi.Enabled = false;
                    DataRow[] rows;
                    try
                    {
                        if (buyinvoicelist.gridViewBuyInvoice == null && buyinvoicelist.gridViewBuyInvoice.SelectedRowsCount == 0) return;
                        rows = new DataRow[buyinvoicelist.gridViewBuyInvoice.SelectedRowsCount];
                        for (int i = 0; i < buyinvoicelist.gridViewBuyInvoice.SelectedRowsCount; i++)
                        {
                            rows[i] = buyinvoicelist.gridViewBuyInvoice.GetDataRow(buyinvoicelist.gridViewBuyInvoice.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            BuyInvoiceID = Convert.ToInt32(row["BuyInvoiceID"]);
                            lookSupplier.EditValue = Convert.ToInt32(row["SupplierID"]);
                            dateDate.Text = Convert.ToDateTime(row["InvoiceDate"]).ToString("yyyy-MM-dd");
                            txtInvoiceNum.Text = row["InvoiceNum"].ToString();
                            if (Convert.ToBoolean(row["Loan"]) == true)
                                chbIsLoan.Checked = true;
                            else chbIsLoan.Checked = false;

                            DataSet dsBuy = new DataSet();
                            dsBuy.Tables.Add((gridBuy.DataSource as DataTable).Copy());
                            DataSet dsBuyDetail = new DataSet();
                            dsBuyDetail.Tables.Add((buyinvoicelist.gridBuyDetail.DataSource as DataTable).Copy());

                            for (int i = 0; i < dsBuyDetail.Tables["BuyDetail"].Rows.Count; i++)
                            {
                                if (BuyInvoiceID == Convert.ToInt32(dsBuyDetail.Tables["BuyDetail"].Rows[i]["BuyInvoiceID"]))
                                {
                                    dsBuy.Tables["BuyDetail"].Rows.Add(
                                        Convert.ToInt32(dsBuyDetail.Tables["BuyDetail"].Rows[i]["BuyDetailID"]),
                                        Convert.ToDecimal(dsBuyDetail.Tables["BuyDetail"].Rows[i]["Count"]),
                                        Convert.ToDecimal(dsBuyDetail.Tables["BuyDetail"].Rows[i]["Price"]),
                                        Convert.ToDecimal(dsBuyDetail.Tables["BuyDetail"].Rows[i]["SumPrice"]),
                                        dsBuyDetail.Tables["BuyDetail"].Rows[i]["ActionDate"],
                                        Convert.ToDecimal(dsBuyDetail.Tables["BuyDetail"].Rows[i]["SalePrice"]),
                                        Convert.ToInt32(dsBuyDetail.Tables["BuyDetail"].Rows[i]["BuyInvoiceID"]),
                                        Convert.ToInt32(dsBuyDetail.Tables["BuyDetail"].Rows[i]["DrugID"]),
                                        "UnChanged",
                                        Convert.ToDecimal(Convert.ToDecimal(dsBuyDetail.Tables["BuyDetail"].Rows[i]["Count"]) * Convert.ToDecimal(dsBuyDetail.Tables["BuyDetail"].Rows[i]["SalePrice"]))
                                        );
                                }
                            }
                            gridBuy.DataSource = dsBuy.Tables["BuyDetail"];
                        }
                    }
                    catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Системийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    btnCreateInvoice.Text = "Падан засварлах";
                    this.Text = "Эм засварлах";
                    btnSave.Text = "Хадгалах";
                    ActionType = 2;
                }
            }
            else XtraMessageBox.Show("Орлогын паданы жагсаалтын цонх нээлттэй байна.", "Орлогын падан", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gridViewBuy_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SumPriceHuviTootsson") return;
            if (e.Column.FieldName == "SumPriceSale") return;
            if (e.Column.FieldName == "SalePrice") return;
            if (e.Column.FieldName == "SumPrice") return;
            if (e.Column.FieldName == "Status") return;
            try
            {
                gridViewBuy.SetFocusedRowCellValue("SalePrice", SalePrice(Convert.ToInt32(gridViewBuy.GetFocusedRowCellValue("DrugID"))));
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Эм сонгоогүй байна!", "Эм сонгох", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gridViewBuy.GetFocusedRowCellValue("Count") == DBNull.Value || gridViewBuy.GetFocusedRowCellValue("Price") == DBNull.Value) { }
            else
            {
                decimal pp = Convert.ToDecimal(txtAshigTootsohHuvi.Text);
                decimal a = Convert.ToDecimal(gridViewBuy.GetFocusedRowCellValue("Count"));
                decimal b = Convert.ToDecimal(gridViewBuy.GetFocusedRowCellValue("Price"));
                gridViewBuy.SetFocusedRowCellValue("SumPrice", (a * b));
                decimal c = Convert.ToDecimal(gridViewBuy.GetFocusedRowCellValue("SalePrice"));
                gridViewBuy.SetFocusedRowCellValue("SumPriceSale", (a * c));
                gridViewBuy.SetFocusedRowCellValue("SumPriceHuviTootsson", (b + ((b * pp) / 100)));
                if (gridViewBuy.GetFocusedRowCellValue("Status").ToString() == "UnChanged")
                    gridViewBuy.SetFocusedRowCellValue("Status", "Modified");
                else if (gridViewBuy.GetFocusedRowCellValue("Status").ToString() == "")
                    gridViewBuy.SetFocusedRowCellValue("Status", "Added");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(22)) return;
            if (!PharmacyFun._checkAccountingPeriod(DateTime.Now.ToString())) return;
            if (btnSave.Enabled == false) return;
            DataSet ds = new DataSet();
            ds.Tables.Add((gridBuy.DataSource as DataTable).Copy());
            if (ds.Tables["BuyDetail"].Rows.Count <= 0) { XtraMessageBox.Show("Уг паданд эм нэмээгүй байна.", "Хэрэглэгчийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            decimal sumprice = 0;
            try
            {
                for (int i = 0; i < ds.Tables["BuyDetail"].Rows.Count; i++)
                {
                    sumprice = sumprice + Convert.ToDecimal(ds.Tables["BuyDetail"].Rows[i]["SumPrice"]);
                }
            }
            catch (Exception) { XtraMessageBox.Show("Эмийн тоо ширхэг эсвэл авсан үнэ оруулаагүй байна.", "Хэрэглэгчийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            bool isLoan = false;
            if (chbIsLoan.Checked) isLoan = true;
            string InvoiceNum = DateTime.Now.ToString("yyyyMMddhhmmss");
            if (XtraMessageBox.Show("Падан хадгалах гэж байна. Хадгалах бол OK товч дарна уу.", "Падан хадгалах", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String[] spPName = new String[] { "BuyInvoiceID", "BuyInvoiceNum", "InvoiceNum", "InvoiceDate", "SumPrice", "ActionDate", "SupplierID", "Loan", "Status", "UserID", "ActionType" };
                SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.DateTime, SqlDbType.Decimal, SqlDbType.DateTime, SqlDbType.Int, SqlDbType.Bit, SqlDbType.TinyInt, SqlDbType.Int, SqlDbType.TinyInt };
                Object[] spPValue = new Object[] { BuyInvoiceID, InvoiceNum, txtInvoiceNum.Text.Trim(), dateDate.Text, sumprice, DateTime.Now, lookSupplier.EditValue, isLoan, 1, DBRes.mUserID, ActionType };
                if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                DBRes.DS.Dispose();
                System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
                DBRes.sql_cmd.Parameters.Add(parameter);
                if (DBRes._ParamProcedure("mBuy_Pro", CommandType.StoredProcedure))
                {
                    //Reset
                    lookSupplier.EditValue = 0;
                    dateDate.Text = "";
                    txtInvoiceNum.Text = "";
                    chbIsLoan.Checked = false;
                    Buy_Load(sender, e);
                    //
                    btnSupplierAdd.Enabled = true;
                    lookSupplier.Enabled = true;
                    dateDate.Enabled = true;
                    txtInvoiceNum.Enabled = true;
                    chbIsLoan.Enabled = true;
                    btnCreateInvoice.Enabled = true;
                    txtAshigTootsohHuvi.Enabled = true;
                    //
                    gridBuy.Enabled = false;
                    btnSave.Enabled = false;
                    btnCreateInvoice.Text = "Падан үүсгэх";
                    btnBuyInvoiceList.Enabled = true;
                    XtraMessageBox.Show("Орлогын падан шивэлт амжилттэй хийгдлээ. Паданы жагсаалтаас дэлгэрэнгүй үзнэ үү.", "Орлогын падан шивэх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSupplierAdd_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.ShowDialog();
            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum,* FROM tSupplier", "Supplier");
            lookSupplier.Properties.DataSource = DBRes.DS.Tables["Supplier"];
            lookSupplier.Properties.ValueMember = "SupplierID";
            lookSupplier.Properties.DisplayMember = "Name";
            EmpVal();
        }

        private void repositoryItemLookDrug_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Ellipsis-DrugAdd")
            {
                Drug drug = new Drug();
                drug.ShowDialog();
                DBRes._FillTable("SELECT * FROM tDrug", "Drug");
                repositoryItemLookDrug.DataSource = DBRes.DS.Tables["Drug"];
                repositoryItemLookDrug.ValueMember = "DrugID";
                repositoryItemLookDrug.DisplayMember = "Name";
            }
        }

        private decimal SalePrice(int drugID)
        {
            DBRes._FillTable("SELECT Price FROM tDrug WHERE DrugID=" + drugID, "Drug");
            return Convert.ToDecimal(DBRes.DS.Tables["Drug"].Rows[0]["Price"]);
        }

        private void gridViewBuy_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DataRow[] rows;
                    if (gridViewBuy != null && gridViewBuy.SelectedRowsCount != 0)
                    {
                        rows = new DataRow[gridViewBuy.SelectedRowsCount];
                        for (int i = 0; i < gridViewBuy.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewBuy.GetDataRow(gridViewBuy.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            if (row["Status"].ToString() == "Added")
                                row.Delete();
                            else
                            {
                                if (XtraMessageBox.Show("Падан засварлах горимоор жагсаалтаас эм устгах гэж байна. Устгах уу?", "Мөр устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    String[] spPName = new String[] { "BuyDetailID" };
                                    SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                                    Object[] spPValue = new Object[] { Convert.ToInt32(row["BuyDetailID"]) };
                                    if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                                    if (DBRes._ParamProcedure("DELETE FROM tBuyDetail WHERE BuyDetailID=@BuyDetailID", CommandType.Text))
                                        row.Delete();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Алдаа: " + ex.Message, "Системийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void repositoryItemButtonEditSalePrice_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ChangePrice changeprice = new ChangePrice();
            changeprice.lookDrug.EditValue = gridViewBuy.GetFocusedRowCellValue("DrugID");
            changeprice.lookDrug.Enabled = false;
            changeprice.btnDrugList.Enabled = false;
            if (changeprice.ShowDialog() == DialogResult.OK)
            {
                gridViewBuy.SetFocusedRowCellValue("SalePrice", SalePrice(Convert.ToInt32(gridViewBuy.GetFocusedRowCellValue("DrugID"))));
                if (gridViewBuy.GetFocusedRowCellValue("Count") != DBNull.Value)
                {
                    decimal a = Convert.ToDecimal(gridViewBuy.GetFocusedRowCellValue("Count"));
                    decimal c = Convert.ToDecimal(gridViewBuy.GetFocusedRowCellValue("SalePrice"));
                    gridViewBuy.SetFocusedRowCellValue("SumPriceSale", (a * c));
                }
                if (gridViewBuy.GetFocusedRowCellValue("Status").ToString() == "UnChanged")
                    gridViewBuy.SetFocusedRowCellValue("Status", "Modified");
                else gridViewBuy.SetFocusedRowCellValue("Status", "Added");
            }
        }

    }
}