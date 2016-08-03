namespace Pharmacy.Forms
{
    partial class DrugBalanceView
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barAccountingPeriod = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbBalanceZero = new DevExpress.XtraEditors.CheckEdit();
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            this.gridDrugBalance = new DevExpress.XtraGrid.GridControl();
            this.gridViewDrugBalance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBaarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPackage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBegInv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBuyCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSaleCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbBalanceZero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrugBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrugBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barAccountingPeriod});
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barAccountingPeriod)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barAccountingPeriod
            // 
            this.barAccountingPeriod.Caption = "TailantUe";
            this.barAccountingPeriod.Id = 0;
            this.barAccountingPeriod.Name = "barAccountingPeriod";
            this.barAccountingPeriod.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(844, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 547);
            this.barDockControlBottom.Size = new System.Drawing.Size(844, 25);
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
            this.barDockControlRight.Location = new System.Drawing.Point(844, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 547);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbBalanceZero);
            this.layoutControl1.Controls.Add(this.btnPrintPreview);
            this.layoutControl1.Controls.Add(this.gridDrugBalance);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(844, 547);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbBalanceZero
            // 
            this.cbBalanceZero.Location = new System.Drawing.Point(2, 523);
            this.cbBalanceZero.MenuManager = this.barManager1;
            this.cbBalanceZero.Name = "cbBalanceZero";
            this.cbBalanceZero.Properties.Caption = "Үлдэгдэл 0 бол харуулахгүй";
            this.cbBalanceZero.Size = new System.Drawing.Size(167, 19);
            this.cbBalanceZero.StyleController = this.layoutControl1;
            this.cbBalanceZero.TabIndex = 6;
            this.cbBalanceZero.CheckedChanged += new System.EventHandler(this.cbBalanceZero_CheckedChanged);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(173, 523);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(669, 22);
            this.btnPrintPreview.StyleController = this.layoutControl1;
            this.btnPrintPreview.TabIndex = 5;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // gridDrugBalance
            // 
            this.gridDrugBalance.Location = new System.Drawing.Point(2, 2);
            this.gridDrugBalance.MainView = this.gridViewDrugBalance;
            this.gridDrugBalance.MenuManager = this.barManager1;
            this.gridDrugBalance.Name = "gridDrugBalance";
            this.gridDrugBalance.Size = new System.Drawing.Size(840, 517);
            this.gridDrugBalance.TabIndex = 4;
            this.gridDrugBalance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDrugBalance});
            // 
            // gridViewDrugBalance
            // 
            this.gridViewDrugBalance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDrugID,
            this.gridColumnRowNum,
            this.gridColumnBaarCode,
            this.gridColumnName,
            this.gridColumnSize,
            this.gridColumnPackage,
            this.gridColumnPrice,
            this.gridColumnBegInv,
            this.gridColumnBuyCount,
            this.gridColumnSaleCount,
            this.gridColumnBalance,
            this.gridColumnSumTotal});
            this.gridViewDrugBalance.GridControl = this.gridDrugBalance;
            this.gridViewDrugBalance.GroupPanelText = "Эмийн одоогийн үлдэгдлийг тайлант үеийн завсараар харна";
            this.gridViewDrugBalance.Name = "gridViewDrugBalance";
            this.gridViewDrugBalance.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDrugBalance.OptionsView.ShowFooter = true;
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
            this.gridColumnRowNum.Width = 35;
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
            // gridColumnName
            // 
            this.gridColumnName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnName.Caption = "Нэр";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.AllowFocus = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 2;
            this.gridColumnName.Width = 196;
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
            this.gridColumnSize.Width = 48;
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
            this.gridColumnPackage.Width = 55;
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
            this.gridColumnPrice.Visible = true;
            this.gridColumnPrice.VisibleIndex = 5;
            this.gridColumnPrice.Width = 65;
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
            this.gridColumnBegInv.VisibleIndex = 6;
            this.gridColumnBegInv.Width = 81;
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
            this.gridColumnBuyCount.VisibleIndex = 7;
            this.gridColumnBuyCount.Width = 72;
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
            this.gridColumnSaleCount.VisibleIndex = 8;
            this.gridColumnSaleCount.Width = 66;
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
            this.gridColumnBalance.VisibleIndex = 9;
            this.gridColumnBalance.Width = 73;
            // 
            // gridColumnSumTotal
            // 
            this.gridColumnSumTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSumTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSumTotal.Caption = "Нийт дүн";
            this.gridColumnSumTotal.DisplayFormat.FormatString = "n";
            this.gridColumnSumTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSumTotal.FieldName = "SumTotal";
            this.gridColumnSumTotal.Name = "gridColumnSumTotal";
            this.gridColumnSumTotal.OptionsColumn.AllowEdit = false;
            this.gridColumnSumTotal.OptionsColumn.AllowFocus = false;
            this.gridColumnSumTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumTotal", "₮{0:n2}")});
            this.gridColumnSumTotal.Visible = true;
            this.gridColumnSumTotal.VisibleIndex = 10;
            this.gridColumnSumTotal.Width = 93;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(844, 547);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridDrugBalance;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(844, 521);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnPrintPreview;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(171, 521);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(673, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbBalanceZero;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 521);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(171, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // DrugBalanceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 572);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "DrugBalanceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эмийн үдэгдэл";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrugBalanceView_FormClosing);
            this.Load += new System.EventHandler(this.DrugBalanceView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrugBalanceView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbBalanceZero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrugBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrugBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridDrugBalance;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDrugBalance;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarStaticItem barAccountingPeriod;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSize;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPackage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBegInv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBuyCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBalance;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBaarCode;
        private DevExpress.XtraEditors.CheckEdit cbBalanceZero;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}