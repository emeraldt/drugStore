using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Pharmacy.Settings
{
    public partial class SoftAbout : DevExpress.XtraEditors.XtraForm
    {
        public SoftAbout()
        {
            InitializeComponent();
        }

        private void SoftAbout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}