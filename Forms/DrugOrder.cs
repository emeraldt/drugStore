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
    public partial class DrugOrder : DevExpress.XtraEditors.XtraForm
    {
        public DrugOrder()
        {
            InitializeComponent();
        }

        private void DrugOrder_Load(object sender, EventArgs e)
        {
            if (!PharmacyFun.DrugBillV("drugBalance")) return;
            DBRes._FillTable("SELECT 0 RowNum,0 DrugID,'' Name,'' Size,'' Package,'' Price,0 Balance FROM tDrugOrder WHERE DrugOrderID=0", "DrugOrderFill");
            DBRes._FillTable("SELECT * FROM tDrugOrder WHERE ActionDate>='" + DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00' AND "
                + " ActionDate<='" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59'", "DrugOrder");
            for (int i = 0; i < DBRes.DS.Tables["drugBalance"].Rows.Count; i++)
            {
                bool a = false;
                for (int j = 0; j < DBRes.DS.Tables["DrugOrder"].Rows.Count; j++)
                {

                    if (Convert.ToInt32(DBRes.DS.Tables["drugBalance"].Rows[i]["DrugID"]) == Convert.ToInt32(DBRes.DS.Tables["DrugOrder"].Rows[j]["DrugID"]))
                        a = true;
                }
                if (!a)
                {
                    DBRes.DS.Tables["DrugOrderFill"].Rows.Add(
                        Convert.ToInt32(DBRes.DS.Tables["drugBalance"].Rows[i]["RowNum"]),
                        Convert.ToInt32(DBRes.DS.Tables["drugBalance"].Rows[i]["DrugID"]),
                        DBRes.DS.Tables["drugBalance"].Rows[i]["Name"].ToString(),
                        DBRes.DS.Tables["drugBalance"].Rows[i]["Size"].ToString(),
                        DBRes.DS.Tables["drugBalance"].Rows[i]["Package"].ToString(),
                        DBRes.DS.Tables["drugBalance"].Rows[i]["Price"].ToString(),
                        Convert.ToInt32(DBRes.DS.Tables["drugBalance"].Rows[i]["Balance"])
                        );
                }
            }
            gridDrugOrder.DataSource = DBRes.DS.Tables["DrugOrderFill"];
        }

        private void DrugOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void DrugOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._drugorder = null;
        }

        private void repositoryItemHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            int DrugID = 0;
            if (gridViewDrugOrder == null || gridViewDrugOrder.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewDrugOrder.SelectedRowsCount];
            for (int i = 0; i < gridViewDrugOrder.SelectedRowsCount; i++)
            {
                rows[i] = gridViewDrugOrder.GetDataRow(gridViewDrugOrder.GetSelectedRows()[i]);
            }
            gridViewDrugOrder.BeginSort();
            foreach (DataRow row in rows)
            {
                if (row == null) return;
                DrugID = Convert.ToInt32(row["DrugID"]);
            }
            gridViewDrugOrder.EndSort();
            if (XtraMessageBox.Show("Уг эмийг энэ өдрийн захиалгаруу оруулах уу?", "Эмийн захиалга", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataSet ds = new DataSet();
                ds.Tables.Add((gridDrugOrder.DataSource as DataTable).Copy());
                String[] spPName = new String[] { "DrugID", "ActionDate", "UserID" };
                SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.DateTime, SqlDbType.Int };
                Object[] spPValue = new Object[] { DrugID, DateTime.Now, DBRes.mUserID };
                if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                if (DBRes._ParamProcedure("INSERT INTO tDrugOrder VALUES(@DrugID,@ActionDate,@UserID)", CommandType.Text))
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        if (Convert.ToInt32(ds.Tables[0].Rows[i]["DrugID"]) == DrugID)
                            ds.Tables[0].Rows[i].Delete();
                    }
                    gridDrugOrder.DataSource = ds.Tables[0];
                }
            }
        }
    }
}