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
    public partial class ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            Static.dxV.Dispose();
            Static.EmptyValidate(txtOldPass, "Хуучин нууц үг оруулна уу", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtNewPass, "Шинэ нууц үг оруулна уу", ConditionOperator.IsNotBlank);
            Static.EmptyValidate(txtRePass, "Шинэ нууц үгээ давтан оруулна уу", ConditionOperator.IsNotBlank);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!PharmacyFun._checkPermission(37)) return;
            if (!Static.dxV.Validate()) return;
            try
            {
                if (txtNewPass.Text.Trim() != txtRePass.Text.Trim()) throw new Exception("Давтан оруулсан нууц үг буруу байна.");
                DBRes._FillTable("SELECT * FROM tUsers WHERE UserID=" + DBRes.mUserID, "Users");
                string oldPass = DBRes.DS.Tables["Users"].Rows[0]["Password"].ToString();
                if (Static.GetMd5Sum(txtOldPass.Text.Trim()) == oldPass)
                {
                    String[] spPName = new String[] { "UserID", "Password" };
                    SqlDbType[] spPSDBType = new SqlDbType[] { SqlDbType.Int, SqlDbType.NVarChar };
                    Object[] spPValue = new Object[] { DBRes.mUserID, Static.GetMd5Sum(txtRePass.Text.Trim()) };
                    if (!Static._spParameterAdd(spPName, spPSDBType, spPValue)) { XtraMessageBox.Show("Бичлэг буруу байна.", "Алдаа"); return; }
                    if (DBRes._ParamProcedure("UPDATE tUsers SET Password=@Password WHERE UserID=@UserID", CommandType.Text))
                    {
                        XtraMessageBox.Show("Нууц үг солих үйлдэл амжилттай хийгдлээ.", "Нууц үг солих", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else throw new Exception("Нууц үг солих явцад алдаа гарлаа.");
                }
                else throw new Exception("Хуучин нууц үг буруу байна.");
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Нууц үг солих", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}