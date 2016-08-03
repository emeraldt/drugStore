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
using Microsoft.Win32;

namespace Pharmacy.Settings
{
    public partial class ConfigSetting : DevExpress.XtraEditors.XtraForm
    {
        public ConfigSetting()
        {
            InitializeComponent();
        }

        private void ConfigSetting_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtServername, "Not server name", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtDatabasename, "Not database name", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtUsername, "Not user name", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtPassword, "Not password", ConditionOperator.IsNotBlank);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            const string userRoot = @"HKEY_CURRENT_USER\Software\Super_Assist_Systems\Pharmacy";
            Registry.SetValue(userRoot, "RegServerName", txtServername.Text.Trim());
            Registry.SetValue(userRoot, "RegDatabaseName", txtDatabasename.Text.Trim());
            Registry.SetValue(userRoot, "RegUserName", txtUsername.Text.Trim());
            Registry.SetValue(userRoot, "RegPassword", Static._StrEnc(txtPassword.Text.Trim()));
            if (DBRes._SetConnection() == 1)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            else XtraMessageBox.Show("Not connected !!!", "System error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}