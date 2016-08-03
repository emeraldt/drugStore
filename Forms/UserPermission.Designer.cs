namespace Pharmacy.Forms
{
    partial class UserPermission
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridUserPermission = new DevExpress.XtraGrid.GridControl();
            this.gridViewUserPermission = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnModuleID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnModuleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPermission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFirstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.gridUserPermission);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(594, 472);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(2, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(590, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Хадгалах";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridUserPermission
            // 
            this.gridUserPermission.Location = new System.Drawing.Point(2, 2);
            this.gridUserPermission.MainView = this.gridViewUserPermission;
            this.gridUserPermission.Name = "gridUserPermission";
            this.gridUserPermission.Size = new System.Drawing.Size(590, 442);
            this.gridUserPermission.TabIndex = 4;
            this.gridUserPermission.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUserPermission});
            // 
            // gridViewUserPermission
            // 
            this.gridViewUserPermission.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnUserID,
            this.gridColumnModuleID,
            this.gridColumnModuleName,
            this.gridColumnPermission,
            this.gridColumnFirstname,
            this.gridColumnGroupName,
            this.gridColumnStatus});
            this.gridViewUserPermission.GridControl = this.gridUserPermission;
            this.gridViewUserPermission.GroupPanelText = "Хэрэглэгчийн эрхийн тохируулага хийх хэсэг";
            this.gridViewUserPermission.Name = "gridViewUserPermission";
            this.gridViewUserPermission.OptionsView.ShowGroupPanel = false;
            this.gridViewUserPermission.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewUserPermission_CellValueChanged);
            // 
            // gridColumnUserID
            // 
            this.gridColumnUserID.Caption = "UserID";
            this.gridColumnUserID.FieldName = "UserID";
            this.gridColumnUserID.Name = "gridColumnUserID";
            // 
            // gridColumnModuleID
            // 
            this.gridColumnModuleID.Caption = "ModuleID";
            this.gridColumnModuleID.FieldName = "ModuleID";
            this.gridColumnModuleID.Name = "gridColumnModuleID";
            // 
            // gridColumnModuleName
            // 
            this.gridColumnModuleName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnModuleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnModuleName.Caption = "Эрхийн нэр";
            this.gridColumnModuleName.FieldName = "ModuleName";
            this.gridColumnModuleName.Name = "gridColumnModuleName";
            this.gridColumnModuleName.OptionsColumn.AllowEdit = false;
            this.gridColumnModuleName.OptionsColumn.AllowFocus = false;
            this.gridColumnModuleName.Visible = true;
            this.gridColumnModuleName.VisibleIndex = 0;
            this.gridColumnModuleName.Width = 443;
            // 
            // gridColumnPermission
            // 
            this.gridColumnPermission.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPermission.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPermission.Caption = "Эрх";
            this.gridColumnPermission.FieldName = "Permission";
            this.gridColumnPermission.Name = "gridColumnPermission";
            this.gridColumnPermission.Visible = true;
            this.gridColumnPermission.VisibleIndex = 1;
            this.gridColumnPermission.Width = 129;
            // 
            // gridColumnFirstname
            // 
            this.gridColumnFirstname.Caption = "Хэрэглэгч";
            this.gridColumnFirstname.FieldName = "Firstname";
            this.gridColumnFirstname.Name = "gridColumnFirstname";
            // 
            // gridColumnGroupName
            // 
            this.gridColumnGroupName.Caption = "Модулын бүлэг";
            this.gridColumnGroupName.FieldName = "GroupName";
            this.gridColumnGroupName.Name = "gridColumnGroupName";
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(594, 472);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridUserPermission;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(594, 446);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 446);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(594, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // UserPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 472);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserPermission";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хэрэглэгчийн эрх";
            this.Load += new System.EventHandler(this.UserPermission_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserPermission_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUserPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridUserPermission;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserPermission;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnModuleID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnModuleName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPermission;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFirstname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGroupName;
    }
}