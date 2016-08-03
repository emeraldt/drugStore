namespace Pharmacy.Forms
{
    partial class CountDetail
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
            this.gridCountDetail = new DevExpress.XtraGrid.GridControl();
            this.gridViewCountDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCountInvoiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPackage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnZoroo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIluuTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDutuuTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBaarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridCountDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCountDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCountDetail
            // 
            this.gridCountDetail.Location = new System.Drawing.Point(2, 2);
            this.gridCountDetail.MainView = this.gridViewCountDetail;
            this.gridCountDetail.Name = "gridCountDetail";
            this.gridCountDetail.Size = new System.Drawing.Size(790, 542);
            this.gridCountDetail.TabIndex = 0;
            this.gridCountDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCountDetail});
            // 
            // gridViewCountDetail
            // 
            this.gridViewCountDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCountID,
            this.gridColumnCountInvoiceID,
            this.gridColumnDrugID,
            this.gridColumnRowNum,
            this.gridColumnName,
            this.gridColumnSize,
            this.gridColumnPackage,
            this.gridColumnPrice,
            this.gridColumnBalance,
            this.gridColumnCount,
            this.gridColumnZoroo,
            this.gridColumnActionDate,
            this.gridColumnStatus,
            this.gridColumnUTotal,
            this.gridColumnTTotal,
            this.gridColumnIluuTotal,
            this.gridColumnDutuuTotal,
            this.gridColumnBaarCode});
            this.gridViewCountDetail.GridControl = this.gridCountDetail;
            this.gridViewCountDetail.Name = "gridViewCountDetail";
            this.gridViewCountDetail.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCountDetail.OptionsView.ShowFooter = true;
            this.gridViewCountDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewCountDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewCountDetail_CellValueChanged);
            // 
            // gridColumnCountID
            // 
            this.gridColumnCountID.Caption = "CountID";
            this.gridColumnCountID.FieldName = "CountID";
            this.gridColumnCountID.Name = "gridColumnCountID";
            // 
            // gridColumnCountInvoiceID
            // 
            this.gridColumnCountInvoiceID.Caption = "CountInvoiceID";
            this.gridColumnCountInvoiceID.FieldName = "CountInvoiceID";
            this.gridColumnCountInvoiceID.Name = "gridColumnCountInvoiceID";
            // 
            // gridColumnDrugID
            // 
            this.gridColumnDrugID.Caption = "DrugID";
            this.gridColumnDrugID.FieldName = "DrugID";
            this.gridColumnDrugID.Name = "gridColumnDrugID";
            // 
            // gridColumnRowNum
            // 
            this.gridColumnRowNum.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnRowNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnRowNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnRowNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnRowNum.Caption = "№";
            this.gridColumnRowNum.FieldName = "RowNum";
            this.gridColumnRowNum.Name = "gridColumnRowNum";
            this.gridColumnRowNum.OptionsColumn.AllowEdit = false;
            this.gridColumnRowNum.OptionsColumn.AllowFocus = false;
            this.gridColumnRowNum.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnRowNum.OptionsFilter.AllowFilter = false;
            this.gridColumnRowNum.Visible = true;
            this.gridColumnRowNum.VisibleIndex = 0;
            this.gridColumnRowNum.Width = 25;
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
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 2;
            this.gridColumnName.Width = 108;
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
            this.gridColumnSize.Visible = true;
            this.gridColumnSize.VisibleIndex = 3;
            this.gridColumnSize.Width = 28;
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
            this.gridColumnPackage.Visible = true;
            this.gridColumnPackage.VisibleIndex = 4;
            this.gridColumnPackage.Width = 63;
            // 
            // gridColumnPrice
            // 
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
            this.gridColumnPrice.VisibleIndex = 5;
            this.gridColumnPrice.Width = 67;
            // 
            // gridColumnBalance
            // 
            this.gridColumnBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBalance.Caption = "Үлдэгдэл";
            this.gridColumnBalance.DisplayFormat.FormatString = "n";
            this.gridColumnBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnBalance.FieldName = "Balance";
            this.gridColumnBalance.Name = "gridColumnBalance";
            this.gridColumnBalance.OptionsColumn.AllowEdit = false;
            this.gridColumnBalance.OptionsColumn.AllowFocus = false;
            this.gridColumnBalance.Visible = true;
            this.gridColumnBalance.VisibleIndex = 6;
            this.gridColumnBalance.Width = 72;
            // 
            // gridColumnCount
            // 
            this.gridColumnCount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCount.Caption = "Тоо";
            this.gridColumnCount.DisplayFormat.FormatString = "n";
            this.gridColumnCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCount.FieldName = "Count";
            this.gridColumnCount.Name = "gridColumnCount";
            this.gridColumnCount.Visible = true;
            this.gridColumnCount.VisibleIndex = 8;
            this.gridColumnCount.Width = 74;
            // 
            // gridColumnZoroo
            // 
            this.gridColumnZoroo.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnZoroo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnZoroo.Caption = "Зөрөө";
            this.gridColumnZoroo.DisplayFormat.FormatString = "n";
            this.gridColumnZoroo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnZoroo.FieldName = "Zoroo";
            this.gridColumnZoroo.Name = "gridColumnZoroo";
            this.gridColumnZoroo.OptionsColumn.AllowEdit = false;
            this.gridColumnZoroo.OptionsColumn.AllowFocus = false;
            this.gridColumnZoroo.Visible = true;
            this.gridColumnZoroo.VisibleIndex = 10;
            this.gridColumnZoroo.Width = 70;
            // 
            // gridColumnActionDate
            // 
            this.gridColumnActionDate.Caption = "ActionDate";
            this.gridColumnActionDate.FieldName = "ActionDate";
            this.gridColumnActionDate.Name = "gridColumnActionDate";
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            // 
            // gridColumnUTotal
            // 
            this.gridColumnUTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnUTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnUTotal.Caption = "Дүн";
            this.gridColumnUTotal.DisplayFormat.FormatString = "n";
            this.gridColumnUTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnUTotal.FieldName = "UTotal";
            this.gridColumnUTotal.Name = "gridColumnUTotal";
            this.gridColumnUTotal.OptionsColumn.AllowEdit = false;
            this.gridColumnUTotal.OptionsColumn.AllowFocus = false;
            this.gridColumnUTotal.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnUTotal.OptionsFilter.AllowFilter = false;
            this.gridColumnUTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UTotal", "₮{0:n2}")});
            this.gridColumnUTotal.Visible = true;
            this.gridColumnUTotal.VisibleIndex = 7;
            this.gridColumnUTotal.Width = 62;
            // 
            // gridColumnTTotal
            // 
            this.gridColumnTTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnTTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnTTotal.Caption = "Дүн";
            this.gridColumnTTotal.DisplayFormat.FormatString = "n";
            this.gridColumnTTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnTTotal.FieldName = "TTotal";
            this.gridColumnTTotal.Name = "gridColumnTTotal";
            this.gridColumnTTotal.OptionsColumn.AllowEdit = false;
            this.gridColumnTTotal.OptionsColumn.AllowFocus = false;
            this.gridColumnTTotal.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnTTotal.OptionsFilter.AllowFilter = false;
            this.gridColumnTTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TTotal", "₮{0:n2}")});
            this.gridColumnTTotal.Visible = true;
            this.gridColumnTTotal.VisibleIndex = 9;
            this.gridColumnTTotal.Width = 58;
            // 
            // gridColumnIluuTotal
            // 
            this.gridColumnIluuTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnIluuTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnIluuTotal.Caption = "Илүү дүн";
            this.gridColumnIluuTotal.DisplayFormat.FormatString = "n";
            this.gridColumnIluuTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnIluuTotal.FieldName = "IluuTotal";
            this.gridColumnIluuTotal.Name = "gridColumnIluuTotal";
            this.gridColumnIluuTotal.OptionsColumn.AllowEdit = false;
            this.gridColumnIluuTotal.OptionsColumn.AllowFocus = false;
            this.gridColumnIluuTotal.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnIluuTotal.OptionsFilter.AllowFilter = false;
            this.gridColumnIluuTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IluuTotal", "₮{0:n2}")});
            this.gridColumnIluuTotal.Visible = true;
            this.gridColumnIluuTotal.VisibleIndex = 11;
            this.gridColumnIluuTotal.Width = 69;
            // 
            // gridColumnDutuuTotal
            // 
            this.gridColumnDutuuTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDutuuTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDutuuTotal.Caption = "Дутуу дүн";
            this.gridColumnDutuuTotal.DisplayFormat.FormatString = "n";
            this.gridColumnDutuuTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnDutuuTotal.FieldName = "DutuuTotal";
            this.gridColumnDutuuTotal.Name = "gridColumnDutuuTotal";
            this.gridColumnDutuuTotal.OptionsColumn.AllowEdit = false;
            this.gridColumnDutuuTotal.OptionsColumn.AllowFocus = false;
            this.gridColumnDutuuTotal.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnDutuuTotal.OptionsFilter.AllowFilter = false;
            this.gridColumnDutuuTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DutuuTotal", "₮{0:n2}")});
            this.gridColumnDutuuTotal.Visible = true;
            this.gridColumnDutuuTotal.VisibleIndex = 12;
            this.gridColumnDutuuTotal.Width = 76;
            // 
            // gridColumnBaarCode
            // 
            this.gridColumnBaarCode.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnBaarCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBaarCode.Caption = "Баар код";
            this.gridColumnBaarCode.FieldName = "BaarCode";
            this.gridColumnBaarCode.Name = "gridColumnBaarCode";
            this.gridColumnBaarCode.OptionsColumn.AllowEdit = false;
            this.gridColumnBaarCode.OptionsColumn.AllowFocus = false;
            this.gridColumnBaarCode.Visible = true;
            this.gridColumnBaarCode.VisibleIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnPrintPreview);
            this.layoutControl1.Controls.Add(this.gridCountDetail);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(794, 572);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(399, 548);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(393, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Хадгалах";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(2, 548);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(393, 22);
            this.btnPrintPreview.StyleController = this.layoutControl1;
            this.btnPrintPreview.TabIndex = 4;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(794, 572);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridCountDetail;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(794, 546);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnPrintPreview;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 546);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(397, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSave;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(397, 546);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(397, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // CountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "CountDetail";
            this.Text = "Тооллогын дэлгэрэнгүй";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CountDetail_FormClosing);
            this.Load += new System.EventHandler(this.CountDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CountDetail_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridCountDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCountDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridCountDetail;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewCountDetail;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCountID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCountInvoiceID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSize;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPackage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBalance;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnZoroo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIluuTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDutuuTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBaarCode;

    }
}