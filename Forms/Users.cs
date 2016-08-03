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

namespace Pharmacy.Forms
{
    public partial class Users : DevExpress.XtraEditors.XtraForm
    {
        private int UserID;
        public Users()
        {
            InitializeComponent();
        }

        private void checkvalidate()
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtFirstName, "Хэрэглэгчийн нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(lookUserGroup, "Хэрэглэгчийн бүлэг сонгоогүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtUsername, "Хэрэглэгчийн нэр оруулаагүй байна.", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtPassword, "Нууц үг оруулаагүй байна.", ConditionOperator.IsNotBlank);
        }

        private void Users_Load(object sender, EventArgs e)
        {
            checkvalidate();

            DBRes._FillTable("SELECT * FROM tUserGroup WHERE Role<>1", "UserGroup");
            lookUserGroup.Properties.DataSource = DBRes.DS.Tables["UserGroup"];
            lookUserGroup.Properties.ValueMember = "GroupID";
            lookUserGroup.Properties.DisplayMember = "Name";

            DBRes._FillTable("SELECT A.*,B.Name FROM tUsers A INNER JOIN tUserGroup B WITH(NOLOCK) ON(B.GroupID=A.GroupID) WHERE A.Status<>1", "Users");
            gridUser.DataSource = DBRes.DS.Tables["Users"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridUser_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewUser == null || gridViewUser.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridViewUser.SelectedRowsCount];
            for (int i = 0; i < gridViewUser.SelectedRowsCount; i++)
            {
                rows[i] = gridViewUser.GetDataRow(gridViewUser.GetSelectedRows()[i]);
            }
            gridViewUser.BeginSort();
            foreach (DataRow row in rows)
            {
                btnSave.Text = "Хадгалах";
                UserID = Convert.ToInt32(row["UserID"]);
                txtFirstName.Text = row["Firstname"].ToString();
                txtUsername.Text = row["Username"].ToString();
                lookUserGroup.EditValue = Convert.ToInt32(row["GroupID"]);

                txtPassword.Text = String.Empty;
                txtPassword.Enabled = false;
                chbChangePassword.Visible = true;
            }
            gridViewUser.EndSort();
            gridUser.Enabled = false;
            checkvalidate();
        }

        private void chbChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbChangePassword.Checked)
                txtPassword.Enabled = true;
            else
            {
                txtPassword.Enabled = false;
                txtPassword.Text = String.Empty;
            }
            checkvalidate();
        }

        private void gridUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (!PharmacyFun._checkPermission(36)) return;
                DataRow[] rows;
                if (gridViewUser != null && gridViewUser.SelectedRowsCount != 0)
                {
                    if (XtraMessageBox.Show("Уг хэрэглэгчийн мэдээлэлийг устгах гэж байгаадаа итгэлтэй байна уу?", "Устгах", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rows = new DataRow[gridViewUser.SelectedRowsCount];
                        for (int i = 0; i < gridViewUser.SelectedRowsCount; i++)
                        {
                            rows[i] = gridViewUser.GetDataRow(gridViewUser.GetSelectedRows()[i]);
                        }
                        foreach (DataRow row in rows)
                        {
                            String[] spPName = new String[] { "UserID" };
                            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int };
                            Object[] spPValue = new Object[] { Convert.ToInt32(row["UserID"]) };
                            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                            if (DBRes._ParamProcedure("DELETE FROM tUsers WHERE UserID=@UserID", CommandType.Text))
                                row.Delete();
                            else XtraMessageBox.Show("Хэрэглэгч устгах үед алдаа гарлаа.", "Хэрэглэгч устгах", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Static.dxV.Validate()) return;
            String[] spPName = new String[] { "UserID", "Firstname", "Username", "Password", "GroupID", "Status" };
            SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.NVarChar, SqlDbType.TinyInt, SqlDbType.TinyInt };
            Object[] spPValue = new Object[] { UserID, txtFirstName.Text.Trim(), txtUsername.Text.Trim(), Static.GetMd5Sum(txtPassword.Text.Trim()), lookUserGroup.EditValue, "0" };
            if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
            if (btnSave.Text == "Бүртгэх")
            {
                if (!PharmacyFun._checkPermission(34)) return;
                if (DBRes._ParamProcedure("INSERT INTO tUsers (Firstname,Username,Password,GroupID,Status)"
                    + " VALUES(@Firstname,@Username,@Password,@GroupID,@Status)", CommandType.Text))
                {
                    txtFirstName.Focus();
                    txtFirstName.Text = String.Empty;
                    lookUserGroup.EditValue = 0;
                    txtUsername.Text = String.Empty;
                    txtPassword.Text = String.Empty;
                    Users_Load(sender, e);
                }
                else XtraMessageBox.Show("Хэрэглэгч бүртгэх үед алдаа гарлаа.", "Хэрэглэгч бүртгэх", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!PharmacyFun._checkPermission(35)) return;
                string cmdText = "";
                if (chbChangePassword.Checked) { cmdText = "UPDATE tUsers SET Firstname=@Firstname,Username=@Username,Password=@Password,GroupID=@GroupID WHERE UserID=@UserID"; }
                else { cmdText = "UPDATE tUsers SET Firstname=@Firstname,Username=@Username,GroupID=@GroupID WHERE UserID=@UserID"; }
                if (DBRes._ParamProcedure(cmdText, CommandType.Text))
                {
                    txtFirstName.Focus();
                    txtFirstName.Text = String.Empty;
                    lookUserGroup.EditValue = 0;
                    txtUsername.Text = String.Empty;
                    txtPassword.Text = String.Empty;
                    txtPassword.Enabled = true;
                    chbChangePassword.Visible = false;

                    btnSave.Text = "Бүртгэх";

                    gridUser.Enabled = true;

                    Users_Load(sender, e);
                }
                else XtraMessageBox.Show("Хэрэглэгч бүртгэх үед алдаа гарлаа.", "Хэрэглэгч бүртгэх", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}