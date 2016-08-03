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
    public partial class DrugBill : DevExpress.XtraEditors.XtraForm
    {
        private int BillID;
        public DrugBill()
        {
            InitializeComponent();
        }

        private void DrugBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void DrugBill_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtBillName, "Тооцооны нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);

            DBRes._FillTable("SELECT A.*,B.CountNum FROM tDrugBill A LEFT JOIN tCountInvoice B "
                + " WITH(NOLOCK) ON(B.CountInvoiceID=A.CountInvoiceID) ORDER BY BillID DESC", "DrugBill");
            gridDrugBill.DataSource = DBRes.DS.Tables["DrugBill"];

            DBRes._FillTable("SELECT * FROM tCountInvoice WHERE ActionDate>='" + PharmacyFun._startDateAccountPeriod() + "' AND ActionDate<='" + DateTime.Now.ToString() + "'", "CountInvoice");
            lookCountInvoiceID.Properties.DataSource = DBRes.DS.Tables["CountInvoice"];
            lookCountInvoiceID.Properties.ValueMember = "CountInvoiceID";
            lookCountInvoiceID.Properties.DisplayMember = "CountNum";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            int LastBillID = PharmacyFun.DrugBillLastID();
            String[] spPName = new String[] { "BillID", "BillName", "ActionDate", "LastBillID", "Status" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.DateTime, SqlDbType.Int, SqlDbType.Bit };
            Object[] spPValue = new Object[] { BillID, txtBillName.Text.Trim(), DateTime.Now, LastBillID, false };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            string cmdText = "";
            string messText = "";

            if (btnCreate.Text == "Үүсгэх")
            {
                if (!PharmacyFun._checkPermission(38)) return;
                DBRes._FillTable("SELECT * FROM tDrugBill WHERE Status=0", "DrugBillSel");
                if (DBRes.DS.Tables["DrugBillSel"].Rows.Count == 0)
                {
                    cmdText = "INSERT INTO tDrugBill (BillName,ActionDate,LastBillID,Status) VALUES(@BillName,@ActionDate,@LastBillID,@Status)";
                    messText = "Эмийн тооцоо амжилттэй үүслээ.";
                }
                else { XtraMessageBox.Show("Өмнөх тооцоог хаагаагүй байна.", "Эмийн тооцоо", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
            else
            {
                if (!PharmacyFun._checkPermission(39)) return;
                cmdText = "UPDATE tDrugBill SET BillName=@BillName WHERE BillID=@BillID";
                messText = "Эмийн тооцооны нэр амжилттэй засварлагдлаа.";
            }
            if (DBRes._ParamProcedure(cmdText, CommandType.Text))
            {
                txtBillName.Text = String.Empty;
                DrugBill_Load(sender, e);
                XtraMessageBox.Show(messText, "Эмийн тооцоо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmiBillNameEdit_Click(object sender, EventArgs e)
        {
            if (gridViewDrugBill == null || gridViewDrugBill.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewDrugBill.SelectedRowsCount];
            for (int i = 0; i < gridViewDrugBill.SelectedRowsCount; i++)
            {
                rows[i] = gridViewDrugBill.GetDataRow(gridViewDrugBill.GetSelectedRows()[i]);
            }
            gridViewDrugBill.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                if (!Convert.ToBoolean(row["Status"]))
                {
                    btnCreate.Enabled = true;
                    txtBillName.Enabled = true;

                    btnCreate.Text = "Хадгалах";
                    BillID = Convert.ToInt32(row["BillID"]);
                    txtBillName.Text = row["BillName"].ToString();

                    lookCountInvoiceID.Enabled = false;
                    txtComment.Enabled = false;
                    btnView.Enabled = false;
                    btnCloseBill.Enabled = false;
                    Static.dxV.Dispose();
                    Static.EmptyValidate(txtBillName, "Тооцооны нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
                }
                else XtraMessageBox.Show("Тооцооны нэр засварлах боломжгүй байна.", "Тооцооны нэр засах", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gridViewDrugBill.EndSort();
        }

        private void tsmiCloseBill_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(40)) return;
            if (gridViewDrugBill == null || gridViewDrugBill.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewDrugBill.SelectedRowsCount];
            for (int i = 0; i < gridViewDrugBill.SelectedRowsCount; i++)
            {
                rows[i] = gridViewDrugBill.GetDataRow(gridViewDrugBill.GetSelectedRows()[i]);
            }
            gridViewDrugBill.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                if (!Convert.ToBoolean(row["Status"]))
                {
                    BillID = Convert.ToInt32(row["BillID"]);
                    btnCreate.Enabled = false;
                    txtBillName.Enabled = false;
                    txtBillName.Text = row["BillName"].ToString();
                    lookCountInvoiceID.Enabled = true;
                    txtComment.Enabled = true;
                    btnView.Enabled = true;
                    btnCloseBill.Enabled = true;
                    Static.dxV.Dispose();
                    Static.EmptyValidate(lookCountInvoiceID, "Тооллого сонгоогүй байна.", ConditionOperator.IsNotBlank);
                }
                else XtraMessageBox.Show("Уг тооцооны хаалтыг хийсэн байна.", "Тооцоо хаах", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gridViewDrugBill.EndSort();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            DrugBillView drugbillview = new DrugBillView();
            drugbillview.BillID = BillID;
            drugbillview.CountInvoiceID = Convert.ToInt32(lookCountInvoiceID.EditValue);
            drugbillview.CountNum = lookCountInvoiceID.Text;
            drugbillview.WindowState = FormWindowState.Maximized;
            drugbillview.ShowDialog();
            DataSet ds = new DataSet();
            ds.Tables.Add((drugbillview.gridDrugBillView.DataSource as DataTable).Copy());
            int zorooIluu = 0;
            int zorooDutuu = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                zorooIluu = zorooIluu + Convert.ToInt32(ds.Tables[0].Rows[i]["ZorooIluu"]);
                zorooDutuu = zorooDutuu + Convert.ToInt32(ds.Tables[0].Rows[i]["ZorooDutuu"]);
            }
            txtComment.Text = "илүүдсэн дүн:( " + zorooIluu + " ). дутсан дүн: ( " + zorooDutuu + " ).";
        }

        private void tsmiBillDetailView_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(41)) return;
            if (gridViewDrugBill == null || gridViewDrugBill.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewDrugBill.SelectedRowsCount];
            for (int i = 0; i < gridViewDrugBill.SelectedRowsCount; i++)
            {
                rows[i] = gridViewDrugBill.GetDataRow(gridViewDrugBill.GetSelectedRows()[i]);
            }
            gridViewDrugBill.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) { gridViewDrugBill.EndSort(); return; }
                if (row["CountInvoiceID"] == DBNull.Value) { gridViewDrugBill.EndSort(); return; }
                DrugBillView drugbillview = new DrugBillView();
                drugbillview.BillID = Convert.ToInt32(row["BillID"]);
                drugbillview.CountInvoiceID = Convert.ToInt32(row["CountInvoiceID"]);
                drugbillview.CountNum = row["CountNum"].ToString();
                drugbillview.WindowState = FormWindowState.Maximized;
                drugbillview.ShowDialog();
            }
            gridViewDrugBill.EndSort();
        }

        private void btnCloseBill_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            String[] spPName = new String[] { "BillID", "CountInvoiceID", "CloseDate", "BillComment", "Status" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.Int, SqlDbType.DateTime, SqlDbType.NVarChar, SqlDbType.Bit };
            Object[] spPValue = new Object[] { BillID, lookCountInvoiceID.EditValue, DateTime.Now, txtComment.Text.Trim(), true };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (DBRes._ParamProcedure("UPDATE tDrugBill SET CountInvoiceID=@CountInvoiceID,CloseDate=@CloseDate,BillComment=@BillComment,Status=@Status WHERE BillID=@BillID", CommandType.Text))
            {
                XtraMessageBox.Show("Эмийн тайлант үеийн хаалт амжилттай хийгдлээ.", "Эмийн тооцоо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}