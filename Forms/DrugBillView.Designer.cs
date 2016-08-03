namespace Pharmacy.Forms
{
    partial class DrugBillView
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            this.gridDrugBillView = new DevExpress.XtraGrid.GridControl();
            this.gridViewDrugBillView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBaarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNameSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBegInv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBuyCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSaleCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEndInv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUldegdelDun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCounting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnToolsonDun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnZorooIluu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnZorooDutuu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.barDate = new DevExpress.XtraBars.BarStaticItem();
            this.barCount = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrugBillView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrugBillView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrintPreview);
            this.layoutControl1.Controls.Add(this.gridDrugBillView);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(894, 547);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(2, 523);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(890, 22);
            this.btnPrintPreview.StyleController = this.layoutControl1;
            this.btnPrintPreview.TabIndex = 5;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // gridDrugBillView
            // 
            this.gridDrugBillView.Location = new System.Drawing.Point(2, 2);
            this.gridDrugBillView.MainView = this.gridViewDrugBillView;
            this.gridDrugBillView.Name = "gridDrugBillView";
            this.gridDrugBillView.Size = new System.Drawing.Size(890, 517);
            this.gridDrugBillView.TabIndex = 4;
            this.gridDrugBillView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDrugBillView});
            // 
            // gridViewDrugBillView
            // 
            this.gridViewDrugBillView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDrugID,
            this.gridColumnBaarCode,
            this.gridColumnNameSize,
            this.gridColumnRowNum,
            this.gridColumnPrice,
            this.gridColumnBegInv,
            this.gridColumnBuyCount,
            this.gridColumnSaleCount,
            this.gridColumnEndInv,
            this.gridColumnUldegdelDun,
            this.gridColumnCounting,
            this.gridColumnToolsonDun,
            this.gridColumnZorooIluu,
            this.gridColumnZorooDutuu});
            this.gridViewDrugBillView.GridControl = this.gridDrugBillView;
            this.gridViewDrugBillView.Name = "gridViewDrugBillView";
            this.gridViewDrugBillView.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDrugBillView.OptionsView.ShowFooter = true;
            this.gridViewDrugBillView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnDrugID
            // 
            this.gridColumnDrugID.Caption = "DrugID";
            this.gridColumnDrugID.FieldName = "DrugID";
            this.gridColumnDrugID.Name = "gridColumnDrugID";
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
            // gridColumnNameSize
            // 
            this.gridColumnNameSize.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNameSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNameSize.Caption = "Эмийн нэр";
            this.gridColumnNameSize.FieldName = "NameSize";
            this.gridColumnNameSize.Name = "gridColumnNameSize";
            this.gridColumnNameSize.OptionsColumn.AllowEdit = false;
            this.gridColumnNameSize.OptionsColumn.AllowFocus = false;
            this.gridColumnNameSize.Visible = true;
            this.gridColumnNameSize.VisibleIndex = 2;
            this.gridColumnNameSize.Width = 127;
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
            this.gridColumnRowNum.Width = 20;
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
            this.gridColumnPrice.VisibleIndex = 3;
            this.gridColumnPrice.Width = 54;
            // 
            // gridColumnBegInv
            // 
            this.gridColumnBegInv.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnBegInv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBegInv.Caption = "Эхний үлдэгдэл";
            this.gridColumnBegInv.DisplayFormat.FormatString = "n";
            this.gridColumnBegInv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnBegInv.FieldName = "BegInv";
            this.gridColumnBegInv.Name = "gridColumnBegInv";
            this.gridColumnBegInv.OptionsColumn.AllowEdit = false;
            this.gridColumnBegInv.OptionsColumn.AllowFocus = false;
            this.gridColumnBegInv.Visible = true;
            this.gridColumnBegInv.VisibleIndex = 4;
            this.gridColumnBegInv.Width = 60;
            // 
            // gridColumnBuyCount
            // 
            this.gridColumnBuyCount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnBuyCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBuyCount.Caption = "Орлого";
            this.gridColumnBuyCount.DisplayFormat.FormatString = "n";
            this.gridColumnBuyCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnBuyCount.FieldName = "BuyCount";
            this.gridColumnBuyCount.Name = "gridColumnBuyCount";
            this.gridColumnBuyCount.OptionsColumn.AllowEdit = false;
            this.gridColumnBuyCount.OptionsColumn.AllowFocus = false;
            this.gridColumnBuyCount.Visible = true;
            this.gridColumnBuyCount.VisibleIndex = 5;
            this.gridColumnBuyCount.Width = 58;
            // 
            // gridColumnSaleCount
            // 
            this.gridColumnSaleCount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSaleCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSaleCount.Caption = "Зарлага";
            this.gridColumnSaleCount.DisplayFormat.FormatString = "n";
            this.gridColumnSaleCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSaleCount.FieldName = "SaleCount";
            this.gridColumnSaleCount.Name = "gridColumnSaleCount";
            this.gridColumnSaleCount.OptionsColumn.AllowEdit = false;
            this.gridColumnSaleCount.OptionsColumn.AllowFocus = false;
            this.gridColumnSaleCount.Visible = true;
            this.gridColumnSaleCount.VisibleIndex = 6;
            this.gridColumnSaleCount.Width = 58;
            // 
            // gridColumnEndInv
            // 
            this.gridColumnEndInv.Caption = "Эцсийн үлдэгдэл";
            this.gridColumnEndInv.DisplayFormat.FormatString = "n";
            this.gridColumnEndInv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnEndInv.FieldName = "EndInv";
            this.gridColumnEndInv.Name = "gridColumnEndInv";
            this.gridColumnEndInv.OptionsColumn.AllowEdit = false;
            this.gridColumnEndInv.OptionsColumn.AllowFocus = false;
            this.gridColumnEndInv.UnboundExpression = "[BegInv]+[BuyCount]-[SaleCount]";
            this.gridColumnEndInv.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnEndInv.Visible = true;
            this.gridColumnEndInv.VisibleIndex = 7;
            this.gridColumnEndInv.Width = 63;
            // 
            // gridColumnUldegdelDun
            // 
            this.gridColumnUldegdelDun.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnUldegdelDun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnUldegdelDun.Caption = "Дүн";
            this.gridColumnUldegdelDun.DisplayFormat.FormatString = "n";
            this.gridColumnUldegdelDun.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnUldegdelDun.FieldName = "UldegdelDun";
            this.gridColumnUldegdelDun.Name = "gridColumnUldegdelDun";
            this.gridColumnUldegdelDun.OptionsColumn.AllowEdit = false;
            this.gridColumnUldegdelDun.OptionsColumn.AllowFocus = false;
            this.gridColumnUldegdelDun.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UldegdelDun", "₮{0:n2}")});
            this.gridColumnUldegdelDun.UnboundExpression = "[Price] * ([BegInv]+[BuyCount]-[SaleCount])";
            this.gridColumnUldegdelDun.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnUldegdelDun.Visible = true;
            this.gridColumnUldegdelDun.VisibleIndex = 8;
            this.gridColumnUldegdelDun.Width = 71;
            // 
            // gridColumnCounting
            // 
            this.gridColumnCounting.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCounting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCounting.Caption = "Тоолсон";
            this.gridColumnCounting.DisplayFormat.FormatString = "n";
            this.gridColumnCounting.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCounting.FieldName = "Counting";
            this.gridColumnCounting.Name = "gridColumnCounting";
            this.gridColumnCounting.OptionsColumn.AllowEdit = false;
            this.gridColumnCounting.OptionsColumn.AllowFocus = false;
            this.gridColumnCounting.Visible = true;
            this.gridColumnCounting.VisibleIndex = 9;
            this.gridColumnCounting.Width = 65;
            // 
            // gridColumnToolsonDun
            // 
            this.gridColumnToolsonDun.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnToolsonDun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnToolsonDun.Caption = "Дүн";
            this.gridColumnToolsonDun.DisplayFormat.FormatString = "n";
            this.gridColumnToolsonDun.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnToolsonDun.FieldName = "ToolsonDun";
            this.gridColumnToolsonDun.Name = "gridColumnToolsonDun";
            this.gridColumnToolsonDun.OptionsColumn.AllowEdit = false;
            this.gridColumnToolsonDun.OptionsColumn.AllowFocus = false;
            this.gridColumnToolsonDun.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ToolsonDun", "₮{0:n2}")});
            this.gridColumnToolsonDun.UnboundExpression = "[Price] * [Counting]";
            this.gridColumnToolsonDun.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnToolsonDun.Visible = true;
            this.gridColumnToolsonDun.VisibleIndex = 10;
            this.gridColumnToolsonDun.Width = 73;
            // 
            // gridColumnZorooIluu
            // 
            this.gridColumnZorooIluu.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnZorooIluu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnZorooIluu.Caption = "Зөрүү (илүү)";
            this.gridColumnZorooIluu.DisplayFormat.FormatString = "n";
            this.gridColumnZorooIluu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnZorooIluu.FieldName = "ZorooIluu";
            this.gridColumnZorooIluu.Name = "gridColumnZorooIluu";
            this.gridColumnZorooIluu.OptionsColumn.AllowEdit = false;
            this.gridColumnZorooIluu.OptionsColumn.AllowFocus = false;
            this.gridColumnZorooIluu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ZorooIluu", "₮{0:n2}")});
            this.gridColumnZorooIluu.Visible = true;
            this.gridColumnZorooIluu.VisibleIndex = 11;
            this.gridColumnZorooIluu.Width = 74;
            // 
            // gridColumnZorooDutuu
            // 
            this.gridColumnZorooDutuu.Caption = "Зөрүү (дутуу)";
            this.gridColumnZorooDutuu.DisplayFormat.FormatString = "n";
            this.gridColumnZorooDutuu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnZorooDutuu.FieldName = "ZorooDutuu";
            this.gridColumnZorooDutuu.Name = "gridColumnZorooDutuu";
            this.gridColumnZorooDutuu.OptionsColumn.AllowEdit = false;
            this.gridColumnZorooDutuu.OptionsColumn.AllowFocus = false;
            this.gridColumnZorooDutuu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ZorooDutuu", "₮{0:n2}")});
            this.gridColumnZorooDutuu.Visible = true;
            this.gridColumnZorooDutuu.VisibleIndex = 12;
            this.gridColumnZorooDutuu.Width = 74;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(894, 547);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridDrugBillView;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(894, 521);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnPrintPreview;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 521);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(894, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barStatus});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barDate,
            this.barCount});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.barStatus;
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Status bar";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barDate),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCount)});
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Status bar";
            // 
            // barDate
            // 
            this.barDate.Caption = "Date";
            this.barDate.Id = 0;
            this.barDate.Name = "barDate";
            this.barDate.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barCount
            // 
            this.barCount.Caption = "Count";
            this.barCount.Id = 1;
            this.barCount.Name = "barCount";
            this.barCount.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(894, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 547);
            this.barDockControlBottom.Size = new System.Drawing.Size(894, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 547);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(894, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 547);
            // 
            // DrugBillView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 572);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "DrugBillView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эмийн тооцоо";
            this.Load += new System.EventHandler(this.DrugBillView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrugBillView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDrugBillView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrugBillView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNameSize;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBegInv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBuyCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCounting;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnZorooIluu;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarStaticItem barDate;
        private DevExpress.XtraBars.BarStaticItem barCount;
        public DevExpress.XtraGrid.GridControl gridDrugBillView;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewDrugBillView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBaarCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEndInv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnZorooDutuu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUldegdelDun;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnToolsonDun;
    }
}