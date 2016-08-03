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

namespace Pharmacy
{
    public partial class Loginscreen : DevExpress.XtraEditors.XtraForm
    {
        public Loginscreen()
        {
            InitializeComponent();
        }

        private void Loginscreen_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtUsername, "Хэрэглэгчийн нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtPassword, "Нууц үг оруулаагүй байна.", ConditionOperator.IsNotBlank);
        }

        private void Loginscreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.F12)
                SAS.ShowKeyWindow.ShowWindow("Pharmacy");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            if (DBRes._SetConnection() == 0)
                DBRes._SetConnection();
            if (Login(txtUsername.Text.Trim(), Static.GetMd5Sum(txtPassword.Text.Trim())))
            {
                DBRes.mUser = txtUsername.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
                XtraMessageBox.Show("Хэрэглэгчийн нэвтрэх нууц үг буруу байна.", "Нэвтрэх алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool Login(string uname, string pass)
        {
            string cmdText = "SELECT A.*,B.Role FROM tUsers A INNER JOIN tUserGroup B ON(B.GroupID=A.GroupID) WHERE A.Username=@Username AND Password=@Password";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdText, DBRes.sql_conn);
            cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = uname;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = pass;
            System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Users");
            if (ds.Tables["Users"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["Users"].Rows.Count; i++)
                {
                    DBRes.mUserID = ds.Tables["Users"].Rows[i]["UserID"].ToString();
                    DBRes.mRole = Convert.ToInt32(ds.Tables["Users"].Rows[i]["Role"]);
                }
                return true;
            }
            else return false;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtUsername.Text.Trim() != String.Empty)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPassword.Text.Trim() != String.Empty)
                btnLogin_Click(sender, e);
        }

    }
}