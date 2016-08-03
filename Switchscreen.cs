using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Pharmacy
{
    public partial class Switchscreen : DevExpress.XtraEditors.XtraForm
    {
        public Switchscreen()
        {
            InitializeComponent();
        }

        private void Switchscreen_Load(object sender, EventArgs e)
        {
            Codes.DBRes._FillTable("SELECT A.*,(B.Name)PrinterName  FROM tSystemInfo A INNER JOIN tPrinter B ON(B.PrintID=A.PrinterID)", "SystemInfo");
            if (!Convert.ToBoolean(Codes.DBRes.DS.Tables["SystemInfo"].Rows[0]["NDDiscount"]))
            {
                btnDiscountPos.Visible = false;
                this.ClientSize = new System.Drawing.Size(376, 230);
            }
        }

        private void btnNormalPos_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Codes.Static.MainVal = true;
            this.DialogResult = DialogResult.Abort;
        }

        private void btnDiscountPos_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

    }
}