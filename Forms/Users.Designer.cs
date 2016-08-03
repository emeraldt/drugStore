namespace Pharmacy.Forms
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chbChangePassword = new DevExpress.XtraEditors.CheckEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookUserGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridUser = new DevExpress.XtraGrid.GridControl();
            this.gridViewUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFirstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbChangePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUserGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chbChangePassword);
            this.panelControl1.Controls.Add(this.txtPassword);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtUsername);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lookUserGroup);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtFirstName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(484, 73);
            this.panelControl1.TabIndex = 0;
            // 
            // chbChangePassword
            // 
            this.chbChangePassword.Location = new System.Drawing.Point(453, 41);
            this.chbChangePassword.Name = "chbChangePassword";
            this.chbChangePassword.Properties.Caption = "";
            this.chbChangePassword.Size = new System.Drawing.Size(24, 19);
            this.chbChangePassword.TabIndex = 8;
            this.chbChangePassword.Visible = false;
            this.chbChangePassword.CheckedChanged += new System.EventHandler(this.chbChangePassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(315, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(132, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(267, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Нууц үг:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(315, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(244, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Нэвтрэх нэр:";
            // 
            // lookUserGroup
            // 
            this.lookUserGroup.Location = new System.Drawing.Point(81, 41);
            this.lookUserGroup.Name = "lookUserGroup";
            this.lookUserGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUserGroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GroupID", "GroupID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Нэр"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Role", "Role", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lookUserGroup.Properties.NullText = "";
            this.lookUserGroup.Size = new System.Drawing.Size(147, 20);
            this.lookUserGroup.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Бүлэг:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(81, 15);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(147, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(53, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Нэр:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(288, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Бүртгэх";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridUser
            // 
            this.gridUser.Location = new System.Drawing.Point(5, 84);
            this.gridUser.MainView = this.gridViewUser;
            this.gridUser.Name = "gridUser";
            this.gridUser.Size = new System.Drawing.Size(484, 203);
            this.gridUser.TabIndex = 10;
            this.gridUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUser});
            this.gridUser.DoubleClick += new System.EventHandler(this.gridUser_DoubleClick);
            this.gridUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridUser_KeyDown);
            // 
            // gridViewUser
            // 
            this.gridViewUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnUserID,
            this.gridColumnFirstname,
            this.gridColumnUsername,
            this.gridColumnPassword,
            this.gridColumnGroupID,
            this.gridColumnName,
            this.gridColumnStatus});
            this.gridViewUser.GridControl = this.gridUser;
            this.gridViewUser.Name = "gridViewUser";
            this.gridViewUser.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnUserID
            // 
            this.gridColumnUserID.Caption = "UserID";
            this.gridColumnUserID.FieldName = "UserID";
            this.gridColumnUserID.Name = "gridColumnUserID";
            // 
            // gridColumnFirstname
            // 
            this.gridColumnFirstname.Caption = "Нэр";
            this.gridColumnFirstname.FieldName = "Firstname";
            this.gridColumnFirstname.Name = "gridColumnFirstname";
            this.gridColumnFirstname.OptionsColumn.AllowEdit = false;
            this.gridColumnFirstname.OptionsColumn.AllowFocus = false;
            this.gridColumnFirstname.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnFirstname.OptionsFilter.AllowFilter = false;
            this.gridColumnFirstname.Visible = true;
            this.gridColumnFirstname.VisibleIndex = 0;
            // 
            // gridColumnUsername
            // 
            this.gridColumnUsername.Caption = "Нэвтрэх нэр";
            this.gridColumnUsername.FieldName = "Username";
            this.gridColumnUsername.Name = "gridColumnUsername";
            this.gridColumnUsername.OptionsColumn.AllowEdit = false;
            this.gridColumnUsername.OptionsColumn.AllowFocus = false;
            this.gridColumnUsername.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnUsername.OptionsFilter.AllowFilter = false;
            this.gridColumnUsername.Visible = true;
            this.gridColumnUsername.VisibleIndex = 1;
            // 
            // gridColumnPassword
            // 
            this.gridColumnPassword.Caption = "Password";
            this.gridColumnPassword.FieldName = "Password";
            this.gridColumnPassword.Name = "gridColumnPassword";
            // 
            // gridColumnGroupID
            // 
            this.gridColumnGroupID.Caption = "GroupID";
            this.gridColumnGroupID.FieldName = "GroupID";
            this.gridColumnGroupID.Name = "gridColumnGroupID";
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Бүлэг";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.AllowFocus = false;
            this.gridColumnName.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnName.OptionsFilter.AllowFilter = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 2;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(414, 293);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Хаах";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Users
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(494, 322);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridUser);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хэрэглэгчийн мэдээлэл";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbChangePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUserGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit chbChangePassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUserGroup;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUser;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFirstname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUsername;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPassword;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGroupID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
    }
}