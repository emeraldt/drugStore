namespace Pharmacy.Forms
{
    partial class DrugOrder
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
            this.gridDrugOrder = new DevExpress.XtraGrid.GridControl();
            this.gridViewDrugOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_RowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPackage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrugOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrugOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridDrugOrder);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(794, 572);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridDrugOrder
            // 
            this.gridDrugOrder.Location = new System.Drawing.Point(2, 2);
            this.gridDrugOrder.MainView = this.gridViewDrugOrder;
            this.gridDrugOrder.Name = "gridDrugOrder";
            this.gridDrugOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
            this.gridDrugOrder.Size = new System.Drawing.Size(790, 568);
            this.gridDrugOrder.TabIndex = 4;
            this.gridDrugOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDrugOrder});
            // 
            // gridViewDrugOrder
            // 
            this.gridViewDrugOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_RowNum,
            this.gridColumnDrugID,
            this.gridColumnName,
            this.gridColumnSize,
            this.gridColumnPackage,
            this.gridColumnPrice,
            this.gridColumnBalance,
            this.gridColumn1});
            this.gridViewDrugOrder.GridControl = this.gridDrugOrder;
            this.gridViewDrugOrder.GroupPanelText = "Эмийн захиалгын цонх";
            this.gridViewDrugOrder.Name = "gridViewDrugOrder";
            // 
            // gridColumn_RowNum
            // 
            this.gridColumn_RowNum.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_RowNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_RowNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_RowNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_RowNum.Caption = "№";
            this.gridColumn_RowNum.FieldName = "RowNum";
            this.gridColumn_RowNum.Name = "gridColumn_RowNum";
            this.gridColumn_RowNum.OptionsColumn.AllowEdit = false;
            this.gridColumn_RowNum.OptionsColumn.AllowFocus = false;
            this.gridColumn_RowNum.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn_RowNum.OptionsFilter.AllowFilter = false;
            this.gridColumn_RowNum.Visible = true;
            this.gridColumn_RowNum.VisibleIndex = 0;
            this.gridColumn_RowNum.Width = 40;
            // 
            // gridColumnDrugID
            // 
            this.gridColumnDrugID.Caption = "DrugID";
            this.gridColumnDrugID.FieldName = "DrugID";
            this.gridColumnDrugID.Name = "gridColumnDrugID";
            // 
            // gridColumnName
            // 
            this.gridColumnName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnName.Caption = "Эмийн нэр";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.AllowFocus = false;
            this.gridColumnName.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnName.OptionsFilter.AllowFilter = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 263;
            // 
            // gridColumnSize
            // 
            this.gridColumnSize.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnSize.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSize.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSize.Caption = "Тун";
            this.gridColumnSize.FieldName = "Size";
            this.gridColumnSize.Name = "gridColumnSize";
            this.gridColumnSize.OptionsColumn.AllowEdit = false;
            this.gridColumnSize.OptionsColumn.AllowFocus = false;
            this.gridColumnSize.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnSize.OptionsFilter.AllowFilter = false;
            this.gridColumnSize.Visible = true;
            this.gridColumnSize.VisibleIndex = 2;
            this.gridColumnSize.Width = 74;
            // 
            // gridColumnPackage
            // 
            this.gridColumnPackage.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPackage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPackage.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPackage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPackage.Caption = "Савлалт";
            this.gridColumnPackage.FieldName = "Package";
            this.gridColumnPackage.Name = "gridColumnPackage";
            this.gridColumnPackage.OptionsColumn.AllowEdit = false;
            this.gridColumnPackage.OptionsColumn.AllowFocus = false;
            this.gridColumnPackage.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnPackage.OptionsFilter.AllowFilter = false;
            this.gridColumnPackage.Visible = true;
            this.gridColumnPackage.VisibleIndex = 3;
            this.gridColumnPackage.Width = 74;
            // 
            // gridColumnPrice
            // 
            this.gridColumnPrice.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPrice.Caption = "Зарах үнэ";
            this.gridColumnPrice.DisplayFormat.FormatString = "n";
            this.gridColumnPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPrice.FieldName = "Price";
            this.gridColumnPrice.Name = "gridColumnPrice";
            this.gridColumnPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnPrice.OptionsColumn.AllowFocus = false;
            this.gridColumnPrice.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnPrice.OptionsFilter.AllowFilter = false;
            this.gridColumnPrice.Visible = true;
            this.gridColumnPrice.VisibleIndex = 4;
            this.gridColumnPrice.Width = 93;
            // 
            // gridColumnBalance
            // 
            this.gridColumnBalance.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBalance.Caption = "Үлдэглэд";
            this.gridColumnBalance.DisplayFormat.FormatString = "n";
            this.gridColumnBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnBalance.FieldName = "Balance";
            this.gridColumnBalance.Name = "gridColumnBalance";
            this.gridColumnBalance.OptionsColumn.AllowEdit = false;
            this.gridColumnBalance.OptionsColumn.AllowFocus = false;
            this.gridColumnBalance.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnBalance.OptionsFilter.AllowFilter = false;
            this.gridColumnBalance.Visible = true;
            this.gridColumnBalance.VisibleIndex = 5;
            this.gridColumnBalance.Width = 112;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "зариалах";
            this.gridColumn1.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.gridColumn1.FieldName = "DrugID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 116;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Caption = "зариалах";
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit1_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(794, 572);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridDrugOrder;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(794, 572);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // DrugOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "DrugOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эмийн захиалга";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrugOrder_FormClosing);
            this.Load += new System.EventHandler(this.DrugOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrugOrder_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDrugOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrugOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridDrugOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDrugOrder;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSize;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPackage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBalance;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_RowNum;
    }
}