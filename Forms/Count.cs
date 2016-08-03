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
    public partial class Count : DevExpress.XtraEditors.XtraForm
    {
        private int CountInvoiceID;
        public Count()
        {
            InitializeComponent();
        }

        private void checkValidate()
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtCountName, "Тооллогын нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
        }

        private void Count_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void Count_Load(object sender, EventArgs e)
        {
            checkValidate();

            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY CountInvoiceID ASC) AS RowNum,* FROM tCountInvoice "
                + " WHERE ActionDate>='" + PharmacyFun._startDateAccountPeriod() + "' AND ActionDate<='" + DateTime.Now.ToString() + "'", "CountInvoice");
            gridCount.DataSource = DBRes.DS.Tables["CountInvoice"];
        }

        private void gridCount_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewCount == null || gridViewCount.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewCount.SelectedRowsCount];
            for (int i = 0; i < gridViewCount.SelectedRowsCount; i++)
            {
                rows[i] = gridViewCount.GetDataRow(gridViewCount.GetSelectedRows()[i]);
            }
            gridViewCount.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                btnCreateCount.Text = "Хадгалах";
                CountInvoiceID = Convert.ToInt32(row["CountInvoiceID"]);
                txtCountName.Text = row["CountName"].ToString();
            }
            gridViewCount.EndSort();
            gridCount.Enabled = false;
            checkValidate();
        }

        private void gridCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (!PharmacyFun._checkPermission(27)) return;
                DataRow[] rows;
                if (gridViewCount != null && gridViewCount.SelectedRowsCount != 0)
                {
                    if (XtraMessageBox.Show("Уг тооллогыг устгах гэж байгаадаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rows = new DataRow[gridViewCount.SelectedRowsCount];
                        for (int i = 0; i < gridViewCount.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewCount.GetDataRow(gridViewCount.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            String[] spPName = new String[] { "CountInvoiceID" };
                            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                            Object[] spPValue = new Object[] { Convert.ToInt32(row["CountInvoiceID"]) };
                            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                            if (DBRes._ParamProcedure("DELETE FROM tCountInvoice WHERE CountInvoiceID=@CountInvoiceID", CommandType.Text))
                                row.Delete();
                            else XtraMessageBox.Show("Уг тооллогыг устгах боломжгүй.", "Тооллого устгах", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnCreateCount_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            if (!PharmacyFun._checkAccountingPeriod(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"))) return;
            String[] spPName = new String[] { "CountInvoiceID", "CountNum", "CountName", "ActionDate" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.DateTime };
            Object[] spPValue = new Object[] { CountInvoiceID, DateTime.Now.ToString("yyyyMMddhhmmss"), txtCountName.Text.Trim(), DateTime.Now };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (btnCreateCount.Text == "Үүсгэх")
            {
                if (!PharmacyFun._checkPermission(25)) return;
                if (DBRes._ParamProcedure("INSERT INTO tCountInvoice (CountNum,CountName,ActionDate) VALUES(@CountNum,@CountName,@ActionDate)", CommandType.Text))
                {
                    txtCountName.Focus();
                    txtCountName.Text = String.Empty;
                    System.Threading.Thread.Sleep(1000);
                    Count_Load(sender, e);
                }
                else XtraMessageBox.Show("Тооллого үүсгэх үед алдаа гарлаа.", "Тооллого үүсгэх", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!PharmacyFun._checkPermission(26)) return;
                string cmdText = "UPDATE tCountInvoice SET CountName=@CountName WHERE CountInvoiceID=@CountInvoiceID";
                if (DBRes._ParamProcedure(cmdText, CommandType.Text))
                {
                    txtCountName.Focus();
                    txtCountName.Text = String.Empty;

                    btnCreateCount.Text = "Үүсгэх";

                    gridCount.Enabled = true;

                    Count_Load(sender, e);
                }
                else XtraMessageBox.Show("Тооллогын нэр засах үед алдаа гарлаа.", "Тооллогын нэр засах", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repositoryItemHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(28)) return;
            int CountInvoiceID = 0;
            if (gridViewCount == null || gridViewCount.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewCount.SelectedRowsCount];
            for (int i = 0; i < gridViewCount.SelectedRowsCount; i++)
            {
                rows[i] = gridViewCount.GetDataRow(gridViewCount.GetSelectedRows()[i]);
            }
            gridViewCount.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                DBRes.CountInvoiceID = CountInvoiceID = Convert.ToInt32(row["CountInvoiceID"]);
                DBRes.CountDetailText = " : " + row["CountNum"].ToString() + " - " + row["CountName"].ToString();
            }
            gridViewCount.EndSort();

            DateTime StartDate = Convert.ToDateTime(DBRes.DS.Tables["DrugBill"].Rows[0]["ActionDate"]);
            DateTime EndDate = DateTime.Now;
            int BegInv = 0;
            //
            StartDate = Convert.ToDateTime(DBRes.DS.Tables["DrugBill"].Rows[0]["ActionDate"]);
            BegInv = PharmacyFun.GetCountInvoiceID(Convert.ToInt32(DBRes.DS.Tables["DrugBill"].Rows[0]["LastBillID"]));
            //
            string cmdText = "SELECT X.*,M.Balance, 0 AS Zoroo FROM vCountDetail X "
                + " INNER JOIN (SELECT A.DrugID, "
                + " (ISNULL(BegInv.Count,0)+ISNULL(B.BuyCount,0)-ISNULL(C.SaleCount,0))Balance "
                + " FROM tDrug A "
                + " LEFT JOIN (SELECT * FROM tCountDetail WHERE CountInvoiceID=" + BegInv + ")BegInv ON(BegInv.DrugID=A.DrugID) "
                + " LEFT JOIN (SELECT DrugID,SUM([Count])BuyCount FROM tBuyDetail "
                + " WHERE ActionDate>='" + StartDate + "' AND ActionDate<='" + EndDate + "' "
                + " GROUP BY DrugID)B ON(B.DrugID=A.DrugID) "
                + " LEFT JOIN (SELECT DrugID,SUM([Count])SaleCount FROM tSaleDetail  "
                + " WHERE ActionDate>='" + StartDate + "' AND ActionDate<='" + EndDate + "' "
                + " GROUP BY DrugID)C ON(C.DrugID=A.DrugID))M ON(M.DrugID=X.DrugID) "
                + " WHERE X.Status=-1 AND X.CountInvoiceID=" + CountInvoiceID;

            //DBRes._FillTable("SELECT * FROM vCountDetail WHERE Status=-1 AND CountInvoiceID=" + CountInvoiceID, "CountDetail");
            DBRes._FillTable(cmdText, "CountDetail");
            String[] spPName = new String[] { "CountInvoiceID" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
            Object[] spPValue = new Object[] { CountInvoiceID };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            System.Data.SqlClient.SqlParameter xml = new System.Data.SqlClient.SqlParameter("@xml", DBRes.DS.GetXml());
            DBRes.sql_cmd.Parameters.Add(xml);
            if (DBRes._ParamProcedure("mCountCreate_Pro", CommandType.StoredProcedure))
                this.DialogResult = DialogResult.OK;
        }

    }
}