namespace Pharmacy.Forms
{
    partial class Module
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
            this.gridModule = new DevExpress.XtraGrid.GridControl();
            this.gridViewModule = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnModuleID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnModuleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookModuleGroup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookModuleGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridModule
            // 
            this.gridModule.Location = new System.Drawing.Point(2, 2);
            this.gridModule.MainView = this.gridViewModule;
            this.gridModule.Name = "gridModule";
            this.gridModule.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookModuleGroup});
            this.gridModule.Size = new System.Drawing.Size(490, 272);
            this.gridModule.TabIndex = 0;
            this.gridModule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewModule});
            // 
            // gridViewModule
            // 
            this.gridViewModule.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnModuleID,
            this.gridColumnModuleName,
            this.gridColumnGroupID,
            this.gridColumnStatus});
            this.gridViewModule.GridControl = this.gridModule;
            this.gridViewModule.GroupPanelText = "Модуль бүртгэх, засах, устгах, харах хэсэг";
            this.gridViewModule.Name = "gridViewModule";
            this.gridViewModule.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewModule.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewModule_CellValueChanged);
            // 
            // gridColumnModuleID
            // 
            this.gridColumnModuleID.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnModuleID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnModuleID.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnModuleID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnModuleID.Caption = "ID";
            this.gridColumnModuleID.FieldName = "ModuleID";
            this.gridColumnModuleID.Name = "gridColumnModuleID";
            this.gridColumnModuleID.OptionsColumn.AllowEdit = false;
            this.gridColumnModuleID.OptionsColumn.AllowFocus = false;
            this.gridColumnModuleID.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnModuleID.OptionsFilter.AllowFilter = false;
            this.gridColumnModuleID.Visible = true;
            this.gridColumnModuleID.VisibleIndex = 0;
            this.gridColumnModuleID.Width = 55;
            // 
            // gridColumnModuleName
            // 
            this.gridColumnModuleName.Caption = "Нэр";
            this.gridColumnModuleName.FieldName = "ModuleName";
            this.gridColumnModuleName.Name = "gridColumnModuleName";
            this.gridColumnModuleName.Visible = true;
            this.gridColumnModuleName.VisibleIndex = 1;
            this.gridColumnModuleName.Width = 207;
            // 
            // gridColumnGroupID
            // 
            this.gridColumnGroupID.Caption = "Бүлгийн нэр";
            this.gridColumnGroupID.ColumnEdit = this.repositoryItemLookModuleGroup;
            this.gridColumnGroupID.FieldName = "GroupID";
            this.gridColumnGroupID.Name = "gridColumnGroupID";
            this.gridColumnGroupID.Visible = true;
            this.gridColumnGroupID.VisibleIndex = 2;
            this.gridColumnGroupID.Width = 210;
            // 
            // repositoryItemLookModuleGroup
            // 
            this.repositoryItemLookModuleGroup.AutoHeight = false;
            this.repositoryItemLookModuleGroup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookModuleGroup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GroupID", "GroupID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GroupName", "Нэр")});
            this.repositoryItemLookModuleGroup.Name = "repositoryItemLookModuleGroup";
            this.repositoryItemLookModuleGroup.NullText = "";
            this.repositoryItemLookModuleGroup.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.gridModule);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(494, 302);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(2, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(490, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Хадгалах";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(494, 302);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridModule;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(494, 276);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 276);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(494, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 302);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Module";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module";
            this.Load += new System.EventHandler(this.Module_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Module_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookModuleGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridModule;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewModule;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnModuleID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnModuleName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGroupID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookModuleGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}