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
using DevExpress.XtraPrinting.Preview;

namespace Pharmacy.Forms
{
    public partial class LoanClose : DevExpress.XtraEditors.XtraForm
    {
        public LoanClose()
        {
            InitializeComponent();
        }

        private void LoanClose_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(dateStart, "Эхлэх огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(dateEnd, "Хүртэл огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);

            dateStart.Text = Convert.ToDateTime(PharmacyFun._startDateAccountPeriod()).ToString("yyyy-MM-dd");
        }

        private void LoanClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void LoanClose_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._loanclose = null;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            if (Convert.ToDateTime(dateStart.Text) > Convert.ToDateTime(dateEnd.Text))
            {
                XtraMessageBox.Show("Хүртэлх огноо эхлэх огнооноос бага байж болохгүй.", "Огноо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string isloan = "", joinText = "";
            if (chbLoan.Checked) isloan = "1";
            else { joinText = " INNER JOIN tLoanClose D ON(D.BuyInvoiceID=A.BuyInvoiceID) "; isloan = "0"; }
            DateTime a = Convert.ToDateTime(dateStart.Text);
            DateTime b = Convert.ToDateTime(dateEnd.Text);
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY A.BuyInvoiceID ASC) AS RowNum, "
                + " A.*,B.Name,C.Firstname FROM tBuyInvoice A "
                + " INNER JOIN tSupplier B ON(B.SupplierID=A.SupplierID) "
                + " INNER JOIN tUsers C ON(C.UserID=A.UserID) " + joinText
                + " WHERE A.ActionDate>='" + a.ToString("yyyy-MM-dd") + " 00:00:00' AND "
                + " A.ActionDate<='" + b.ToString("yyyy-MM-dd") + " 23:59:59' "
                + " AND A.Loan=" + isloan, "LoanClose");
            gridLoanClose.DataSource = DBRes.DS.Tables["LoanClose"];
        }

        private void repositoryItemHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            int BuyInvoiceID = 0;
            decimal sumprice = 0;
            string supplierName = "";
            bool loan = false;
            if (gridViewLoanClose == null || gridViewLoanClose.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewLoanClose.SelectedRowsCount];
            for (int i = 0; i < gridViewLoanClose.SelectedRowsCount; i++)
            {
                rows[i] = gridViewLoanClose.GetDataRow(gridViewLoanClose.GetSelectedRows()[i]);
            }
            gridViewLoanClose.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                BuyInvoiceID = Convert.ToInt32(row["BuyInvoiceID"]);
                loan = Convert.ToBoolean(row["Loan"]);
                sumprice = Convert.ToDecimal(row["SumPrice"]);
                supplierName = row["Name"].ToString();
            }
            gridViewLoanClose.EndSort();
            if (loan)
            {
                if (XtraMessageBox.Show("Уг зээлээр авсан паданы төлөлт оруулах гэж байна. Төлөлт хийх үү?", "Зээл төлөлт", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String[] spPName = new String[] { "BuyInvoiceID", "ActionDate", "UserID" };
                    SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.DateTime, SqlDbType.Int };
                    Object[] spPValue = new Object[] { BuyInvoiceID, DateTime.Now, DBRes.mUserID };
                    if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                    if (DBRes._ParamProcedure("UPDATE tBuyInvoice SET Loan=0 WHERE BuyInvoiceID=@BuyInvoiceID "
                        + " INSERT INTO tLoanClose VALUES(@BuyInvoiceID,@ActionDate,@UserID)", CommandType.Text))
                    {
                        for (int i = 0; i < DBRes.DS.Tables["LoanClose"].Rows.Count; i++)
                        {
                            if (Convert.ToInt32(DBRes.DS.Tables["LoanClose"].Rows[i]["BuyInvoiceID"]) == BuyInvoiceID)
                                DBRes.DS.Tables["LoanClose"].Rows[i].Delete();
                        }
                        gridLoanClose.DataSource = DBRes.DS.Tables["LoanClose"];
                        belenMongoBarimt(supplierName, sumprice);
                    }
                }
            }
            else
            {
                DBRes._FillTable("SELECT A.*,B.Firstname FROM tLoanClose A "
                    + " INNER JOIN tUsers B ON(B.UserID=A.UserID) "
                    + " WHERE A.BuyInvoiceID=" + BuyInvoiceID, "LoanCloseView");
                XtraMessageBox.Show("Уг паданы зээлийн төлөлтийг "
                    + Convert.ToDateTime(DBRes.DS.Tables["LoanCloseView"].Rows[0]["ActionDate"]).ToString("yyyy-MM-dd hh:mm:ss")
                    + " - нд " + DBRes.DS.Tables["LoanCloseView"].Rows[0]["Firstname"].ToString()
                    + " оруулсан байна.", "Зээл төлөлт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                belenMongoBarimt(supplierName, sumprice);
            }
        }

        private void belenMongoBarimt(string supplierName, decimal sumprice)
        {
            if (XtraMessageBox.Show("Кассын зарлагын ордер хэвлэж авах уу?", "Кассын зарлагын ордер", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Reports.rCashOrder RB = new Reports.rCashOrder();
                DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");
                RB.xrName.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
                DateTime a = Convert.ToDateTime(dateStart.Text);
                RB.xrOgnoo.Text = a.ToString("yyyy") + " он " + a.ToString("MM") + " сар " + a.ToString("dd") + " өдөр";
                RB.xrSupplierName.Text = supplierName;
                RB.xrTotal.Text = sumprice.ToString("###,###,###,###,###.## ₮");
                using (PrintPreviewFormEx form1 = new PrintPreviewFormEx())
                {
                    form1.PrintingSystem = RB.PrintingSystem;
                    RB.CreateDocument();
                    form1.ShowDialog();
                }
            }
        }

    }
}