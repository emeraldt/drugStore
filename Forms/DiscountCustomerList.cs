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
    public partial class DiscountCustomerList : DevExpress.XtraEditors.XtraForm
    {
        public DiscountCustomerList()
        {
            InitializeComponent();
        }

        private void DiscountCustomerList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void DiscountCustomerList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static._discountcustomerlist = null;
        }

        private void DiscountCustomerList_Load(object sender, EventArgs e)
        {
            DBRes._FillTable("SELECT ROW_NUMBER() OVER(ORDER BY Firstname ASC)RowNum,* FROM tDiscountCustomer", "DiscountCustomer");
            gridDiscountCustomer.DataSource = DBRes.DS.Tables["DiscountCustomer"];
        }
    }
}