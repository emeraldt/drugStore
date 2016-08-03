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
    public partial class DrugBalanceView : DevExpress.XtraEditors.XtraForm
    {
        public DrugBalanceView()
        {
            InitializeComponent();
        }

        private void DrugBalanceView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._durgbalanceview = null;
        }

        private void DrugBalanceView_Load(object sender, EventArgs e)
        {
            barAccountingPeriod.Caption = "Эмийн тооцооны тайлант үе: " + Convert.ToDateTime(PharmacyFun._startDateAccountPeriod()).ToString("yyyy-MM-dd hh:mm:ss") + " - ээс одоо.";
            if (!PharmacyFun.DrugBillV("drugBalance")) return;
            gridDrugBalance.DataSource = DBRes.DS.Tables["drugBalance"];
        }

        private void cbBalanceZero_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBalanceZero.Checked)
                gridViewDrugBalance.ActiveFilter.NonColumnFilter = "[Balance] <> 0";
            else gridViewDrugBalance.ActiveFilter.Clear();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(53)) return;
            // Check whether or not the XtraGrid control can be previewed. 
            if (!gridDrugBalance.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error");
                return;
            }
            // Opens the Preview window. 
            gridDrugBalance.ShowPrintPreview();
        }

        private void DrugBalanceView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

    }
}