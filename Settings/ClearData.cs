using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Pharmacy.Codes;

namespace Pharmacy.Settings
{
    public partial class ClearData : DevExpress.XtraEditors.XtraForm
    {
        public ClearData()
        {
            InitializeComponent();
        }

        private void ClearData_Load(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT * FROM tDrugBill", "DrugBill");
            lookTootsooName.Properties.DataSource = DBRes.DS.Tables["DrugBill"];
            lookTootsooName.Properties.DisplayMember = "BillName";
            lookTootsooName.Properties.ValueMember = "BillID";
            for (int i = 0; i < DBRes.DS.Tables["DrugBill"].Rows.Count; i++)
            {
                if (!Convert.ToBoolean(DBRes.DS.Tables["DrugBill"].Rows[i]["Status"]))
                {
                    txtTootsooName.Text = DBRes.DS.Tables["DrugBill"].Rows[i]["BillName"].ToString();
                    txtTootsooOgnoo1.Text = Convert.ToDateTime(DBRes.DS.Tables["DrugBill"].Rows[i]["ActionDate"]).ToString("yyyy-MM-dd hh:mm:ss");
                }
            }
        }

        private void ClearData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnStartProgram_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Програмыг шинээр эхлүүлэх гэж байгаадаа итгэлтэй байна уу?", "Шинээр эхлүүлэх", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DBRes._ParamProcedure("SetPro", CommandType.StoredProcedure))
                    XtraMessageBox.Show("Програмыг шинээр эхлүүлэх үйлдэл амжилттай хийгдлээ.", "Шинээр эхлүүлэх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearData1_Click(object sender, EventArgs e)
        {
            if (txtTootsooName.Text == String.Empty) return;

        }

        private void lookTootsooName_EditValueChanged(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT ActionDate FROM tDrugBill WHERE BillID=" + lookTootsooName.EditValue, "selDrugBill");
            txtTootsooOgnoo2.Text = Convert.ToDateTime(DBRes.DS.Tables["selDrugBill"].Rows[0]["ActionDate"]).ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void btnClearData2_Click(object sender, EventArgs e)
        {
            if (lookTootsooName.EditValue == null) return;

        }

    }
}