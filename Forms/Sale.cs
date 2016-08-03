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
    public partial class Sale : DevExpress.XtraEditors.XtraForm
    {
        private int SaleInvoiceID;
        private int ActoinType;
        private string saleInvoiceNum;
        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnClose_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Зарлагын цонх хаах гэж байна. Цонхыг хаах уу?", "Зарлагын цонх хаах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                this.DialogResult = DialogResult.OK;
            }
            else { e.Cancel = true; }
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtSaleInvoiceNum, "Гүйлгээний утга (нэр) оруулаагүй байна.", ConditionOperator.IsNotBlank);

            DBRes._FillTable("SELECT *,''Status FROM tSaleDetail WHERE 1=-1", "SaleDetail");
            gridSale.DataSource = DBRes.DS.Tables["SaleDetail"];

            DBRes._FillTable("SELECT ROW_NUMBER()OVER(ORDER BY Name ASC)RowNum, "
                + " DrugID,Name+' '+ISNULL(Size,'')+' '+ISNULL(Package,'')NameSizePackage,Price FROM tDrug", "Drug");
            repositoryItemLookSale.DataSource = DBRes.DS.Tables["Drug"];
            repositoryItemLookSale.ValueMember = "DrugID";
            repositoryItemLookSale.DisplayMember = "NameSizePackage";
        }

        private void gridViewSale_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Price") return;
                if (e.Column.FieldName == "SumPrice") return;
                if (e.Column.FieldName == "Status") return;
                gridViewSale.SetFocusedRowCellValue("Price", SalePrice(Convert.ToInt32(gridViewSale.GetFocusedRowCellValue("DrugID"))));
                if (gridViewSale.GetFocusedRowCellValue("Count") != DBNull.Value)
                {
                    decimal bal = PharmacyFun.balanceCheck(Convert.ToInt32(gridViewSale.GetFocusedRowCellValue("DrugID")), Convert.ToDecimal(gridViewSale.GetFocusedRowCellValue("Count")));
                    if (bal != -1 && bal != -2 && bal != -3)
                    {
                        XtraMessageBox.Show("Эмийн үлдэгдэл хүрэхгүй байна. Үлдэгдэл - " + bal + " байна.", "Эмийн үлдэгдэл", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridViewSale.SetFocusedRowCellValue("Count", bal);
                    }
                }
                if (gridViewSale.GetFocusedRowCellValue("Count") == DBNull.Value || gridViewSale.GetFocusedRowCellValue("Price") == DBNull.Value) { }
                else
                {
                    decimal a = Convert.ToDecimal(gridViewSale.GetFocusedRowCellValue("Count"));
                    decimal b = Convert.ToDecimal(gridViewSale.GetFocusedRowCellValue("Price"));
                    gridViewSale.SetFocusedRowCellValue("SumPrice", (a * b));
                    if (gridViewSale.GetFocusedRowCellValue("Status").ToString() == "UnChanged")
                        gridViewSale.SetFocusedRowCellValue("Status", "Modified");
                    else if (gridViewSale.GetFocusedRowCellValue("Status").ToString() == "")
                        gridViewSale.SetFocusedRowCellValue("Status", "Added");
                }
            }
            catch (Exception) { }
        }

        private decimal SalePrice(int drugID)
        {
            DBRes._FillTable("SELECT Price FROM tDrug WHERE DrugID=" + drugID, "Drug");
            return Convert.ToDecimal(DBRes.DS.Tables["Drug"].Rows[0]["Price"]);
        }

        private void gridViewSale_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DataRow[] rows;
                    if (gridViewSale != null && gridViewSale.SelectedRowsCount != 0)
                    {
                        rows = new DataRow[gridViewSale.SelectedRowsCount];
                        for (int i = 0; i < gridViewSale.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewSale.GetDataRow(gridViewSale.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            if (row["Status"].ToString() == "Added")
                                row.Delete();
                            else
                            {
                                if (XtraMessageBox.Show("Падан засварлах горимоор жагсаалтаас эм устгах гэж байна. Устгах уу?", "Мөр устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    String[] spPName = new String[] { "SaleDetailID" };
                                    SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                                    Object[] spPValue = new Object[] { Convert.ToInt32(row["SaleDetailID"]) };
                                    if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                                    if (DBRes._ParamProcedure("DELETE FROM tSaleDetail WHERE SaleDetailID=@SaleDetailID", CommandType.Text))
                                    {
                                        row.Delete();
                                        DBRes._FillTable("SELECT *,'UnChanged'Status FROM tSaleDetail WHERE SaleInvoiceID=" + SaleInvoiceID, "SaleDetail");
                                        gridSale.DataSource = DBRes.DS.Tables["SaleDetail"];
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Алдаа: " + ex.Message, "Системийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private int RowID(DevExpress.XtraGrid.Views.Grid.GridView gridView, string fieldName)
        {
            int rowId = 0;
            if (gridView == null && gridView.SelectedRowsCount == 0) return 0;
            DataRow[] rows = new DataRow[gridView.SelectedRowsCount];
            for (int i = 0; i < gridView.SelectedRowsCount; i++)
            {
                rows[i] = gridView.GetDataRow(gridView.GetSelectedRows()[i]);
            }
            foreach (DataRow row in rows)
            {
                if (row == null) return 0;
                rowId = Convert.ToInt32(row[fieldName].ToString());
            }
            return rowId;
        }

        private string GetValRow(DevExpress.XtraGrid.Views.Grid.GridView gridView, string fieldName)
        {
            string rowVal = "";
            if (gridView == null && gridView.SelectedRowsCount == 0) return "";
            DataRow[] rows = new DataRow[gridView.SelectedRowsCount];
            for (int i = 0; i < gridView.SelectedRowsCount; i++)
            {
                rows[i] = gridView.GetDataRow(gridView.GetSelectedRows()[i]);
            }
            foreach (DataRow row in rows)
            {
                if (row == null) return "";
                rowVal = row[fieldName].ToString();
            }
            return rowVal;
        }

        private void btnBuyInvoiceList_Click(object sender, EventArgs e)
        {
            if (Static._saleinvoicelist != null) { XtraMessageBox.Show("Зарлагын паданы жагсаалтын цонх нээлттэй байна.", "Зарлагын падан", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            SaleInvoiceList saleinvoicelist = new SaleInvoiceList();
            if (saleinvoicelist.ShowDialog() == DialogResult.OK)
            {
                int rowID = RowID(saleinvoicelist.gridViewSaleInvoice, "SaleInvoiceID");
                this.Text = this.Text + " - " + "засварлах (" + rowID + ")";
                SaleInvoiceID = rowID;
                txtSaleInvoiceNum.Text = GetValRow(saleinvoicelist.gridViewSaleInvoice, "SaleInvoiceNum");
                DBRes._FillTable("SELECT *,'UnChanged'Status FROM tSaleDetail WHERE SaleInvoiceID=" + rowID, "SaleDetail");
                gridSale.DataSource = DBRes.DS.Tables["SaleDetail"];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            if (!PharmacyFun._checkPermission(84)) return;
            if (!PharmacyFun._checkAccountingPeriod(DateTime.Now.ToString())) return;
            DataSet ds = new DataSet();
            ds.Tables.Add((gridSale.DataSource as DataTable).Copy());
            if (ds.Tables["SaleDetail"].Rows.Count <= 0) { XtraMessageBox.Show("Уг паданд эм нэмээгүй байна.", "Хэрэглэгчийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            decimal sumprice = 0;
            try
            {
                for (int i = 0; i < ds.Tables["SaleDetail"].Rows.Count; i++)
                {
                    sumprice = sumprice + Convert.ToDecimal(ds.Tables["SaleDetail"].Rows[i]["SumPrice"]);
                }
            }
            catch (Exception) { XtraMessageBox.Show("Эмийн тоо ширхэг эсвэл авсан үнэ оруулаагүй байна.", "Хэрэглэгчийн алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (this.Text == "Зарлага")
            { ActoinType = 1; SaleInvoiceID = 0; }
            else { ActoinType = 2; }

            saleInvoiceNum = txtSaleInvoiceNum.Text.Trim();

            String[] spPName = new String[] { "SaleInvoiceID", "SaleInvoiceNum", "SumPrice", "ActionDate", "CardID", "SumDiscount", "UserID", "ActionType", "Status" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.Decimal, SqlDbType.DateTime, SqlDbType.Int, SqlDbType.Decimal, SqlDbType.Int, SqlDbType.TinyInt, SqlDbType.TinyInt };
            Object[] spPValue = new Object[] { SaleInvoiceID, saleInvoiceNum, sumprice, DateTime.Now, 1, 0, DBRes.mUserID, ActoinType, 3 };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            DBRes.DS.Dispose();
            System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
            DBRes.sql_cmd.Parameters.Add(parameter);
            if (DBRes._ParamProcedure("mSale_Pro", CommandType.StoredProcedure))
            {
                XtraMessageBox.Show("Зарлагын падан амжилттай хадгалагдлаа.", "Зарлага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.Sale_FormClosing);
                this.Close();
            }
        }
    }
}