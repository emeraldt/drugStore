using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pharmacy.Codes;

namespace Pharmacy.Forms
{
    public partial class SalesReturn : DevExpress.XtraEditors.XtraForm
    {
        public SalesReturn()
        {
            InitializeComponent();
        }

        private void SalesReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._salesreturn = null;
        }

        private void SalesReturn_Load(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkAccountingPeriod(DateTime.Now.ToString())) return;

            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.BuyDetailID ASC) AS RowNum, "
                + " A.*,(B.Name + ' ' +ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSize,''AS Status FROM tBuyDetail A "
                + " INNER JOIN tDrug B WITH(NOLOCK) ON(B.DrugID=A.DrugID) WHERE A.BuyDetailID=-1", "BuyDetail");
            gridSaleReturn.DataSource = DBRes.DS.Tables["BuyDetail"];

            //DBRes._FillTable("SELECT * FROM tSaleInvoice WHERE ActionDate>='" + PharmacyFun._startDateAccountPeriod() + "' AND "
            //    + " ActionDate<='" + DateTime.Now + "' AND DATALENGTH(SaleInvoiceNum)>=14", "SaleInvoice");
            DBRes._FillTable("SELECT * FROM tSaleInvoice WHERE ActionDate>='" + PharmacyFun._startDateAccountPeriod() + "' AND "
                + " ActionDate<='" + DateTime.Now + "' AND Status=1", "SaleInvoice");
            lookSaleInvoice.Properties.DataSource = DBRes.DS.Tables["SaleInvoice"];
            lookSaleInvoice.Properties.ValueMember = "SaleInvoiceID";
            lookSaleInvoice.Properties.DisplayMember = "SaleInvoiceNum";
        }

        private void lookSaleInvoice_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lookSaleInvoice.EditValue) == 0) return;
            DBRes._FillTable("SELECT * FROM tBuyInvoice WHERE InvoiceNum='" + lookSaleInvoice.Text + "'", "BuyInvoiceCheck");
            if (DBRes.DS.Tables["BuyInvoiceCheck"].Rows.Count > 0) { XtraMessageBox.Show(lookSaleInvoice.Text + "- дугаартай талонаас буцаалт хийсэн байна.", "Буцаалт", MessageBoxButtons.OK, MessageBoxIcon.Error); lookSaleInvoice.EditValue = 0; return; }
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.DrugID ASC) AS RowNum, "
                + " A.*,(B.Name + ' ' +ISNULL(B.Size,'')+' '+ISNULL(B.Package,''))NameSize FROM tSaleDetail A "
                + " INNER JOIN tDrug B WITH(NOLOCK) ON(B.DrugID=A.DrugID) WHERE A.SaleInvoiceID=" + lookSaleInvoice.EditValue, "SaleDetailOld");
            gridSale.DataSource = DBRes.DS.Tables["SaleDetailOld"];
        }

        private void barReturnAddDrug_Click(object sender, EventArgs e)
        {
            lookSaleInvoice.Enabled = false;
            if (gridViewSale == null || gridViewSale.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewSale.SelectedRowsCount];
            for (int i = 0; i < gridViewSale.SelectedRowsCount; i++)
            {
                rows[i] = gridViewSale.GetDataRow(gridViewSale.GetSelectedRows()[i]);
            }
            gridViewSale.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                DataSet ds = new DataSet();
                bool addRow = true;
                ds.Tables.Add((gridSaleReturn.DataSource as DataTable).Copy());
                for (int i = 0; i < ds.Tables["BuyDetail"].Rows.Count; i++)
                {
                    if (Convert.ToInt32(ds.Tables["BuyDetail"].Rows[i]["DrugID"]) == Convert.ToInt32(row["DrugID"]))
                    {
                        addRow = false;
                        i = ds.Tables["BuyDetail"].Rows.Count + 1;
                    }
                }
                if (addRow)
                {
                    ds.Tables["BuyDetail"].Rows.Add(
                        0,
                        0,
                        Convert.ToDecimal(row["Count"]),
                        Convert.ToDecimal(row["Price"]),
                        Convert.ToDecimal(row["SumPrice"]),
                        DateTime.Now,
                        Convert.ToDecimal(row["SumPrice"]),
                        0,
                        Convert.ToInt32(row["DrugID"]),
                        row["NameSize"],
                        "Added"
                        );
                    gridSaleReturn.DataSource = ds.Tables["BuyDetail"];
                }
                else XtraMessageBox.Show("Энэ эм буцаалтын жагсаалтруу нэмэгдсэн байна.", "Буцаалт", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gridViewSale.EndSort();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridSaleReturn.DataSource as DataTable).Copy());
            if (ds.Tables["BuyDetail"].Rows.Count <= 0) { XtraMessageBox.Show("Буцаалтын эмийн жагсаалтанд эм нэмээгүй байна.", "Буцаалт", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!PharmacyFun._checkAccountingPeriod(DateTime.Now.ToString())) return;
            decimal sumprice = 0;
            for (int i = 0; i < ds.Tables["BuyDetail"].Rows.Count; i++)
            {
                sumprice = sumprice + Convert.ToDecimal(ds.Tables["BuyDetail"].Rows[i]["SumPrice"]);
            }
            string BuyInvoiceNum = DateTime.Now.ToString("yyyyMMddhhmmss");
            DBRes._FillTable("SELECT * FROM tBuyInvoice A JOIN tSaleInvoice B WITH(NOLOCK) ON(B.SaleInvoiceID=A.SupplierID) "
                + " WHERE A.Status=2 AND B.SaleInvoiceID=" + lookSaleInvoice.EditValue, "checkReturn");
            if (DBRes.DS.Tables["checkReturn"].Rows.Count > 0)
            {
                XtraMessageBox.Show("Уг талонын эмэнд өмнө нь буцаалт хийсэн байна. Буцаалт хийх боломжгүй.", "Буцаалт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Буцаалтыг хадгалах гэж байна. Хадгалах бол OK товч дарна уу.", "Буцаалт хадгалах", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ds.Tables["BuyDetail"].Columns.Remove("NameSize");
                String[] spPName = new String[] { "BuyInvoiceNum", "InvoiceNum", "InvoiceDate", "SumPrice", "ActionDate", "Loan", "Status", "UserID", "ActionType" };
                SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.DateTime, SqlDbType.Decimal, SqlDbType.DateTime, SqlDbType.Bit, SqlDbType.TinyInt, SqlDbType.Int, SqlDbType.TinyInt };
                Object[] spPValue = new Object[] { BuyInvoiceNum, lookSaleInvoice.Text, DateTime.Now, sumprice, DateTime.Now, false, 2, DBRes.mUserID, 1 };
                if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                DBRes.DS.Dispose();
                System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@xml", ds.GetXml());
                DBRes.sql_cmd.Parameters.Add(parameter);
                if (DBRes._ParamProcedure("mBuy_Pro", CommandType.StoredProcedure))
                {
                    XtraMessageBox.Show("Буцаалт амжилттэй хийгдлээ.", "Буцаалт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void SalesReturn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

    }
}