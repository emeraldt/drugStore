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

namespace Pharmacy.ReportsForms
{
    public partial class DrugOrderReport : DevExpress.XtraEditors.XtraForm
    {
        public DrugOrderReport()
        {
            InitializeComponent();
        }

        private void DrugOrderReport_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(dateOgnoo, "Огноо сонгоогүй байна.", ConditionOperator.IsNotBlank);
        }

        private void DrugOrderReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void DrugOrderReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._drugorderreport = null;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY B.Name ASC) AS RowNum, "
                + " A.*,B.Name,B.Size,B.Package,C.Firstname,B.Price FROM tDrugOrder A "
                + " INNER JOIN tDrug B ON(B.DrugID=A.DrugID) "
                + " INNER JOIN tUsers C ON(C.UserID=A.UserID) "
                + " WHERE A.ActionDate>='" + dateOgnoo.Text.Trim() + " 00:00:00' AND "
                + " A.ActionDate<='" + dateOgnoo.Text.Trim() + " 23:59:59'", "DrugOrderReport");
            gridDrugOrderReport.DataSource = DBRes.DS.Tables["DrugOrderReport"];
            btnPrint.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add((gridDrugOrderReport.DataSource as DataTable).Copy());
            Reports.rDrugOrderReport RB = new Reports.rDrugOrderReport();
            DBRes._FillTable("SELECT * FROM tSystemInfo", "SystemInfo");
            RB.xrName.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Companyname"].ToString();
            RB.xrRegion.Text = DBRes.DS.Tables["SystemInfo"].Rows[0]["Region"].ToString();
            RB.xrOgnoo.Text = dateOgnoo.Text + " - ий эмийн захиалга";

            RB.DataSource = ds.Tables[0];

            using (PrintPreviewFormEx form1 = new PrintPreviewFormEx())
            {
                form1.PrintingSystem = RB.PrintingSystem;
                RB.CreateDocument();
                form1.ShowDialog();
            }
        }

        private int RowID()
        {
            int rowId = 0;
            if (gridViewDrugOrderReport == null && gridViewDrugOrderReport.SelectedRowsCount == 0) return 0;
            DataRow[] rows = new DataRow[gridViewDrugOrderReport.SelectedRowsCount];
            for (int i = 0; i < gridViewDrugOrderReport.SelectedRowsCount; i++)
            {
                rows[i] = gridViewDrugOrderReport.GetDataRow(gridViewDrugOrderReport.GetSelectedRows()[i]);
            }
            foreach (DataRow row in rows)
            {
                if (row == null) return 0;
                rowId = Convert.ToInt32(row["DrugOrderID"].ToString());
            }
            gridViewDrugOrderReport.EndSort();
            return rowId;
        }

        private void barDeleteDrug_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(73)) return;
            if (XtraMessageBox.Show("Орлогын падан устгах гэж байна. Устгах уу?", "Падан устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] spPName = new String[] { "DrugOrderID" };
                SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                Object[] spPValue = new Object[] { RowID() };
                if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                if (DBRes._ParamProcedure("DELETE FROM tDrugOrder WHERE DrugOrderID=@DrugOrderID", CommandType.Text))
                    btnView_Click(sender, e);
            }
        }
    }
}