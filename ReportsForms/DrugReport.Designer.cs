namespace Pharmacy.ReportsForms
{
    partial class DrugReport
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
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridDrugBill = new DevExpress.XtraGrid.GridControl();
            this.gridViewDrugBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNameSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBegInv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumPriceBegInv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBuyCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumPriceBuyCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSaleCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumPriceSaleCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBegEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumPriceBegEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnChangePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrugBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrugBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.btnView);
            this.layoutControl1.Controls.Add(this.dateEnd);
            this.layoutControl1.Controls.Add(this.dateStart);
            this.layoutControl1.Controls.Add(this.labelControl2);
            this.layoutControl1.Controls.Add(this.gridDrugBill);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(794, 572);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(2, 548);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(790, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Хэвлэх";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(66, 16);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Эхлэх огноо:";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(427, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(123, 22);
            this.btnView.StyleController = this.layoutControl1;
            this.btnView.TabIndex = 8;
            this.btnView.Text = "Харах";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(285, 3);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEnd.Size = new System.Drawing.Size(135, 20);
            this.dateEnd.StyleController = this.layoutControl1;
            this.dateEnd.TabIndex = 7;
            // 
            // dateStart
            // 
            this.dateStart.EditValue = null;
            this.dateStart.Location = new System.Drawing.Point(75, 3);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStart.Size = new System.Drawing.Size(129, 20);
            this.dateStart.StyleController = this.layoutControl1;
            this.dateStart.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(211, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelControl2.Size = new System.Drawing.Size(70, 16);
            this.labelControl2.StyleController = this.layoutControl1;
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Хүртэл огноо:";
            // 
            // gridDrugBill
            // 
            this.gridDrugBill.Location = new System.Drawing.Point(2, 28);
            this.gridDrugBill.MainView = this.gridViewDrugBill;
            this.gridDrugBill.Name = "gridDrugBill";
            this.gridDrugBill.Size = new System.Drawing.Size(790, 516);
            this.gridDrugBill.TabIndex = 4;
            this.gridDrugBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDrugBill});
            // 
            // gridViewDrugBill
            // 
            this.gridViewDrugBill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDrugID,
            this.gridColumnRowNum,
            this.gridColumnNameSize,
            this.gridColumnBegInv,
            this.gridColumnSumPriceBegInv,
            this.gridColumnBuyCount,
            this.gridColumnSumPriceBuyCount,
            this.gridColumnSaleCount,
            this.gridColumnSumPriceSaleCount,
            this.gridColumnBegEnd,
            this.gridColumnPrice,
            this.gridColumnSumPriceBegEnd,
            this.gridColumnChangePrice});
            this.gridViewDrugBill.GridControl = this.gridDrugBill;
            this.gridViewDrugBill.GroupPanelText = "Эмийн тайлан";
            this.gridViewDrugBill.Name = "gridViewDrugBill";
            this.gridViewDrugBill.OptionsView.ShowFooter = true;
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
            // gridColumnNameSize
            // 
            this.gridColumnNameSize.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNameSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNameSize.Caption = "Эмийн нэр";
            this.gridColumnNameSize.FieldName = "NameSize";
            this.gridColumnNameSize.Name = "gridColumnNameSize";
            this.gridColumnNameSize.OptionsColumn.AllowEdit = false;
            this.gridColumnNameSize.OptionsColumn.AllowFocus = false;
            this.gridColumnNameSize.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnNameSize.OptionsFilter.AllowFilter = false;
            this.gridColumnNameSize.Visible = true;
            this.gridColumnNameSize.VisibleIndex = 1;
            this.gridColumnNameSize.Width = 143;
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
            this.gridColumnBegInv.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnBegInv.OptionsFilter.AllowFilter = false;
            this.gridColumnBegInv.Visible = true;
            this.gridColumnBegInv.VisibleIndex = 2;
            this.gridColumnBegInv.Width = 55;
            // 
            // gridColumnSumPriceBegInv
            // 
            this.gridColumnSumPriceBegInv.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSumPriceBegInv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSumPriceBegInv.Caption = "Дүн";
            this.gridColumnSumPriceBegInv.DisplayFormat.FormatString = "n";
            this.gridColumnSumPriceBegInv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSumPriceBegInv.FieldName = "SumPriceBegInv";
            this.gridColumnSumPriceBegInv.Name = "gridColumnSumPriceBegInv";
            this.gridColumnSumPriceBegInv.OptionsColumn.AllowEdit = false;
            this.gridColumnSumPriceBegInv.OptionsColumn.AllowFocus = false;
            this.gridColumnSumPriceBegInv.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnSumPriceBegInv.OptionsFilter.AllowFilter = false;
            this.gridColumnSumPriceBegInv.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumPriceBegInv", "₮{0:###,###,###,###.##}")});
            this.gridColumnSumPriceBegInv.Visible = true;
            this.gridColumnSumPriceBegInv.VisibleIndex = 3;
            this.gridColumnSumPriceBegInv.Width = 55;
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
            this.gridColumnBuyCount.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnBuyCount.OptionsFilter.AllowFilter = false;
            this.gridColumnBuyCount.Visible = true;
            this.gridColumnBuyCount.VisibleIndex = 4;
            this.gridColumnBuyCount.Width = 55;
            // 
            // gridColumnSumPriceBuyCount
            // 
            this.gridColumnSumPriceBuyCount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSumPriceBuyCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSumPriceBuyCount.Caption = "Дүн";
            this.gridColumnSumPriceBuyCount.DisplayFormat.FormatString = "n";
            this.gridColumnSumPriceBuyCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSumPriceBuyCount.FieldName = "SumPriceBuyCount";
            this.gridColumnSumPriceBuyCount.Name = "gridColumnSumPriceBuyCount";
            this.gridColumnSumPriceBuyCount.OptionsColumn.AllowEdit = false;
            this.gridColumnSumPriceBuyCount.OptionsColumn.AllowFocus = false;
            this.gridColumnSumPriceBuyCount.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnSumPriceBuyCount.OptionsFilter.AllowFilter = false;
            this.gridColumnSumPriceBuyCount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumPriceBuyCount", "₮{0:###,###,###,###.##}")});
            this.gridColumnSumPriceBuyCount.Visible = true;
            this.gridColumnSumPriceBuyCount.VisibleIndex = 5;
            this.gridColumnSumPriceBuyCount.Width = 55;
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
            this.gridColumnSaleCount.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnSaleCount.OptionsFilter.AllowFilter = false;
            this.gridColumnSaleCount.Visible = true;
            this.gridColumnSaleCount.VisibleIndex = 6;
            this.gridColumnSaleCount.Width = 55;
            // 
            // gridColumnSumPriceSaleCount
            // 
            this.gridColumnSumPriceSaleCount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSumPriceSaleCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSumPriceSaleCount.Caption = "Дүн";
            this.gridColumnSumPriceSaleCount.DisplayFormat.FormatString = "n";
            this.gridColumnSumPriceSaleCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSumPriceSaleCount.FieldName = "SumPriceSaleCount";
            this.gridColumnSumPriceSaleCount.Name = "gridColumnSumPriceSaleCount";
            this.gridColumnSumPriceSaleCount.OptionsColumn.AllowEdit = false;
            this.gridColumnSumPriceSaleCount.OptionsColumn.AllowFocus = false;
            this.gridColumnSumPriceSaleCount.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnSumPriceSaleCount.OptionsFilter.AllowFilter = false;
            this.gridColumnSumPriceSaleCount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumPriceSaleCount", "₮{0:###,###,###,###.##}")});
            this.gridColumnSumPriceSaleCount.Visible = true;
            this.gridColumnSumPriceSaleCount.VisibleIndex = 7;
            this.gridColumnSumPriceSaleCount.Width = 55;
            // 
            // gridColumnBegEnd
            // 
            this.gridColumnBegEnd.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnBegEnd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBegEnd.Caption = "Эцсийн үлдэгдэл";
            this.gridColumnBegEnd.DisplayFormat.FormatString = "n";
            this.gridColumnBegEnd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnBegEnd.FieldName = "BegEnd";
            this.gridColumnBegEnd.Name = "gridColumnBegEnd";
            this.gridColumnBegEnd.OptionsColumn.AllowEdit = false;
            this.gridColumnBegEnd.OptionsColumn.AllowFocus = false;
            this.gridColumnBegEnd.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnBegEnd.OptionsFilter.AllowFilter = false;
            this.gridColumnBegEnd.Visible = true;
            this.gridColumnBegEnd.VisibleIndex = 8;
            this.gridColumnBegEnd.Width = 55;
            // 
            // gridColumnPrice
            // 
            this.gridColumnPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPrice.Caption = "Нэгж үнэ";
            this.gridColumnPrice.DisplayFormat.FormatString = "n";
            this.gridColumnPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPrice.FieldName = "Price";
            this.gridColumnPrice.Name = "gridColumnPrice";
            this.gridColumnPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnPrice.OptionsColumn.AllowFocus = false;
            this.gridColumnPrice.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnPrice.OptionsFilter.AllowFilter = false;
            this.gridColumnPrice.Visible = true;
            this.gridColumnPrice.VisibleIndex = 9;
            this.gridColumnPrice.Width = 55;
            // 
            // gridColumnSumPriceBegEnd
            // 
            this.gridColumnSumPriceBegEnd.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSumPriceBegEnd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSumPriceBegEnd.Caption = "Дүн";
            this.gridColumnSumPriceBegEnd.DisplayFormat.FormatString = "n";
            this.gridColumnSumPriceBegEnd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSumPriceBegEnd.FieldName = "SumPriceBegEnd";
            this.gridColumnSumPriceBegEnd.Name = "gridColumnSumPriceBegEnd";
            this.gridColumnSumPriceBegEnd.OptionsColumn.AllowEdit = false;
            this.gridColumnSumPriceBegEnd.OptionsColumn.AllowFocus = false;
            this.gridColumnSumPriceBegEnd.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnSumPriceBegEnd.OptionsFilter.AllowFilter = false;
            this.gridColumnSumPriceBegEnd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumPriceBegEnd", "₮{0:###,###,###,###.##}")});
            this.gridColumnSumPriceBegEnd.Visible = true;
            this.gridColumnSumPriceBegEnd.VisibleIndex = 10;
            this.gridColumnSumPriceBegEnd.Width = 55;
            // 
            // gridColumnChangePrice
            // 
            this.gridColumnChangePrice.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnChangePrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnChangePrice.Caption = "ҮӨА дүн";
            this.gridColumnChangePrice.DisplayFormat.FormatString = "n";
            this.gridColumnChangePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnChangePrice.FieldName = "ChangePrice";
            this.gridColumnChangePrice.Name = "gridColumnChangePrice";
            this.gridColumnChangePrice.OptionsColumn.AllowEdit = false;
            this.gridColumnChangePrice.OptionsColumn.AllowFocus = false;
            this.gridColumnChangePrice.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnChangePrice.OptionsFilter.AllowFilter = false;
            this.gridColumnChangePrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ChangePrice", "₮{0:###,###,###,###.##}")});
            this.gridColumnChangePrice.Visible = true;
            this.gridColumnChangePrice.VisibleIndex = 11;
            this.gridColumnChangePrice.Width = 69;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(794, 572);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridDrugBill;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(794, 520);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateStart;
            this.layoutControlItem3.CustomizationFormText = "Эхлэх огноо:";
            this.layoutControlItem3.Location = new System.Drawing.Point(73, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 3, 2);
            this.layoutControlItem3.Size = new System.Drawing.Size(133, 26);
            this.layoutControlItem3.Text = "Эхлэх огноо:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dateEnd;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(283, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 3, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(139, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnView;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(422, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(133, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(555, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(239, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.labelControl1;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            this.layoutControlItem6.Size = new System.Drawing.Size(73, 26);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.labelControl2;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(206, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            this.layoutControlItem7.Size = new System.Drawing.Size(77, 26);
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnPrint;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 546);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(794, 26);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // DrugReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "DrugReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эмийн тайлан";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrugReport_FormClosing);
            this.Load += new System.EventHandler(this.DrugReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrugReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrugBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrugBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridDrugBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDrugBill;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNameSize;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBegInv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPriceBegInv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBuyCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPriceBuyCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPriceSaleCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBegEnd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPriceBegEnd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnChangePrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
    }
}