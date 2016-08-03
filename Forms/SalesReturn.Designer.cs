namespace Pharmacy.Forms
{
    partial class SalesReturn
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lookSaleInvoice = new DevExpress.XtraEditors.LookUpEdit();
            this.gridSale = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.barReturnAddDrug = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewSale = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnSaleDetailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNameSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSaleInvoiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridSaleReturn = new DevExpress.XtraGrid.GridControl();
            this.gridViewSaleReturn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBuyDetailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNameSizeRet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCountRet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPriceRet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumPriceRet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDateRet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBuyInvoiceIDRet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDrugIDRet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookSaleInvoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSale)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaleReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(744, 522);
            this.splitContainerControl1.SplitterPosition = 360;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lookSaleInvoice);
            this.layoutControl1.Controls.Add(this.gridSale);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(360, 522);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lookSaleInvoice
            // 
            this.lookSaleInvoice.Location = new System.Drawing.Point(63, 2);
            this.lookSaleInvoice.Name = "lookSaleInvoice";
            this.lookSaleInvoice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookSaleInvoice.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SaleInvoiceID", "SaleInvoiceID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SaleInvoiceNum", "Талон №"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SumPrice", "Нийт дүн"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActionDate", "Огноо", 20, DevExpress.Utils.FormatType.DateTime, "yyyy-MM-dd hh:mm:ss", true, DevExpress.Utils.HorzAlignment.Default)});
            this.lookSaleInvoice.Properties.NullText = "";
            this.lookSaleInvoice.Properties.PopupFormMinSize = new System.Drawing.Size(400, 200);
            this.lookSaleInvoice.Size = new System.Drawing.Size(295, 20);
            this.lookSaleInvoice.StyleController = this.layoutControl1;
            this.lookSaleInvoice.TabIndex = 5;
            this.lookSaleInvoice.EditValueChanged += new System.EventHandler(this.lookSaleInvoice_EditValueChanged);
            // 
            // gridSale
            // 
            this.gridSale.ContextMenuStrip = this.contextMenuStrip1;
            this.gridSale.Location = new System.Drawing.Point(2, 26);
            this.gridSale.MainView = this.gridViewSale;
            this.gridSale.Name = "gridSale";
            this.gridSale.Size = new System.Drawing.Size(356, 494);
            this.gridSale.TabIndex = 4;
            this.gridSale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSale});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barReturnAddDrug});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 26);
            // 
            // barReturnAddDrug
            // 
            this.barReturnAddDrug.Name = "barReturnAddDrug";
            this.barReturnAddDrug.Size = new System.Drawing.Size(253, 22);
            this.barReturnAddDrug.Text = "Буцаалтын жагсаалтруу оруулах";
            this.barReturnAddDrug.Click += new System.EventHandler(this.barReturnAddDrug_Click);
            // 
            // gridViewSale
            // 
            this.gridViewSale.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnSaleDetailID,
            this.gridColumnRowNum,
            this.gridColumnNameSize,
            this.gridColumnCount,
            this.gridColumnPrice,
            this.gridColumnSumPrice,
            this.gridColumnActionDate,
            this.gridColumnSaleInvoiceID,
            this.gridColumnDrugID});
            this.gridViewSale.GridControl = this.gridSale;
            this.gridViewSale.GroupPanelText = "Борлуулсан эмийн жагсаалтын хэсэг";
            this.gridViewSale.Name = "gridViewSale";
            // 
            // gridColumnSaleDetailID
            // 
            this.gridColumnSaleDetailID.Caption = "SaleDetailID";
            this.gridColumnSaleDetailID.FieldName = "SaleDetailID";
            this.gridColumnSaleDetailID.Name = "gridColumnSaleDetailID";
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
            this.gridColumnNameSize.Width = 109;
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
            this.gridColumnCount.OptionsColumn.AllowEdit = false;
            this.gridColumnCount.OptionsColumn.AllowFocus = false;
            this.gridColumnCount.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnCount.OptionsFilter.AllowFilter = false;
            this.gridColumnCount.Visible = true;
            this.gridColumnCount.VisibleIndex = 2;
            this.gridColumnCount.Width = 40;
            // 
            // gridColumnPrice
            // 
            this.gridColumnPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPrice.Caption = "Үнэ";
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
            this.gridColumnPrice.Width = 51;
            // 
            // gridColumnSumPrice
            // 
            this.gridColumnSumPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSumPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSumPrice.Caption = "Нийт дүн";
            this.gridColumnSumPrice.DisplayFormat.FormatString = "n";
            this.gridColumnSumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSumPrice.FieldName = "SumPrice";
            this.gridColumnSumPrice.Name = "gridColumnSumPrice";
            this.gridColumnSumPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnSumPrice.OptionsColumn.AllowFocus = false;
            this.gridColumnSumPrice.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnSumPrice.OptionsFilter.AllowFilter = false;
            this.gridColumnSumPrice.Visible = true;
            this.gridColumnSumPrice.VisibleIndex = 4;
            this.gridColumnSumPrice.Width = 76;
            // 
            // gridColumnActionDate
            // 
            this.gridColumnActionDate.Caption = "ActionDate";
            this.gridColumnActionDate.FieldName = "ActionDate";
            this.gridColumnActionDate.Name = "gridColumnActionDate";
            // 
            // gridColumnSaleInvoiceID
            // 
            this.gridColumnSaleInvoiceID.Caption = "SaleInvoiceID";
            this.gridColumnSaleInvoiceID.Name = "gridColumnSaleInvoiceID";
            // 
            // gridColumnDrugID
            // 
            this.gridColumnDrugID.Caption = "DrugID";
            this.gridColumnDrugID.FieldName = "DrugID";
            this.gridColumnDrugID.Name = "gridColumnDrugID";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(360, 522);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridSale;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(360, 498);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lookSaleInvoice;
            this.layoutControlItem3.CustomizationFormText = "Талоны №:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem3.Text = "Талоны №:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.btnSave);
            this.layoutControl2.Controls.Add(this.gridSaleReturn);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(379, 522);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(2, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(375, 22);
            this.btnSave.StyleController = this.layoutControl2;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Хадгалах";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridSaleReturn
            // 
            this.gridSaleReturn.Location = new System.Drawing.Point(2, 2);
            this.gridSaleReturn.MainView = this.gridViewSaleReturn;
            this.gridSaleReturn.Name = "gridSaleReturn";
            this.gridSaleReturn.Size = new System.Drawing.Size(375, 492);
            this.gridSaleReturn.TabIndex = 4;
            this.gridSaleReturn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSaleReturn});
            // 
            // gridViewSaleReturn
            // 
            this.gridViewSaleReturn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnBuyDetailID,
            this.gridColumnNameSizeRet,
            this.gridColumnCountRet,
            this.gridColumnPriceRet,
            this.gridColumnSumPriceRet,
            this.gridColumnSalePrice,
            this.gridColumnActionDateRet,
            this.gridColumnBuyInvoiceIDRet,
            this.gridColumnDrugIDRet,
            this.gridColumnStatus});
            this.gridViewSaleReturn.GridControl = this.gridSaleReturn;
            this.gridViewSaleReturn.GroupPanelText = "Буцаасан эмийн жагсаалтын хэсэг";
            this.gridViewSaleReturn.Name = "gridViewSaleReturn";
            this.gridViewSaleReturn.OptionsView.ShowFooter = true;
            // 
            // gridColumnBuyDetailID
            // 
            this.gridColumnBuyDetailID.Caption = "BuyDetailID";
            this.gridColumnBuyDetailID.FieldName = "BuyDetailID";
            this.gridColumnBuyDetailID.Name = "gridColumnBuyDetailID";
            // 
            // gridColumnNameSizeRet
            // 
            this.gridColumnNameSizeRet.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNameSizeRet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNameSizeRet.Caption = "Эмийн нэр";
            this.gridColumnNameSizeRet.FieldName = "NameSize";
            this.gridColumnNameSizeRet.Name = "gridColumnNameSizeRet";
            this.gridColumnNameSizeRet.OptionsColumn.AllowEdit = false;
            this.gridColumnNameSizeRet.OptionsColumn.AllowFocus = false;
            this.gridColumnNameSizeRet.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnNameSizeRet.OptionsFilter.AllowFilter = false;
            this.gridColumnNameSizeRet.Visible = true;
            this.gridColumnNameSizeRet.VisibleIndex = 0;
            this.gridColumnNameSizeRet.Width = 136;
            // 
            // gridColumnCountRet
            // 
            this.gridColumnCountRet.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCountRet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCountRet.Caption = "Тоо";
            this.gridColumnCountRet.DisplayFormat.FormatString = "n";
            this.gridColumnCountRet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCountRet.FieldName = "Count";
            this.gridColumnCountRet.Name = "gridColumnCountRet";
            this.gridColumnCountRet.OptionsColumn.AllowEdit = false;
            this.gridColumnCountRet.OptionsColumn.AllowFocus = false;
            this.gridColumnCountRet.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnCountRet.OptionsFilter.AllowFilter = false;
            this.gridColumnCountRet.Visible = true;
            this.gridColumnCountRet.VisibleIndex = 1;
            this.gridColumnCountRet.Width = 42;
            // 
            // gridColumnPriceRet
            // 
            this.gridColumnPriceRet.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPriceRet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPriceRet.Caption = "Үнэ";
            this.gridColumnPriceRet.DisplayFormat.FormatString = "n";
            this.gridColumnPriceRet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPriceRet.FieldName = "Price";
            this.gridColumnPriceRet.Name = "gridColumnPriceRet";
            this.gridColumnPriceRet.OptionsColumn.AllowEdit = false;
            this.gridColumnPriceRet.OptionsColumn.AllowFocus = false;
            this.gridColumnPriceRet.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnPriceRet.OptionsFilter.AllowFilter = false;
            this.gridColumnPriceRet.Visible = true;
            this.gridColumnPriceRet.VisibleIndex = 2;
            this.gridColumnPriceRet.Width = 44;
            // 
            // gridColumnSumPriceRet
            // 
            this.gridColumnSumPriceRet.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSumPriceRet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSumPriceRet.Caption = "Нийт дүн";
            this.gridColumnSumPriceRet.DisplayFormat.FormatString = "n";
            this.gridColumnSumPriceRet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSumPriceRet.FieldName = "SumPrice";
            this.gridColumnSumPriceRet.Name = "gridColumnSumPriceRet";
            this.gridColumnSumPriceRet.OptionsColumn.AllowEdit = false;
            this.gridColumnSumPriceRet.OptionsColumn.AllowFocus = false;
            this.gridColumnSumPriceRet.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnSumPriceRet.OptionsFilter.AllowFilter = false;
            this.gridColumnSumPriceRet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumPrice", "₮{0:n2}")});
            this.gridColumnSumPriceRet.Visible = true;
            this.gridColumnSumPriceRet.VisibleIndex = 3;
            this.gridColumnSumPriceRet.Width = 70;
            // 
            // gridColumnSalePrice
            // 
            this.gridColumnSalePrice.Caption = "SalePrice";
            this.gridColumnSalePrice.FieldName = "SalePrice";
            this.gridColumnSalePrice.Name = "gridColumnSalePrice";
            // 
            // gridColumnActionDateRet
            // 
            this.gridColumnActionDateRet.Caption = "ActionDate";
            this.gridColumnActionDateRet.FieldName = "ActionDate";
            this.gridColumnActionDateRet.Name = "gridColumnActionDateRet";
            // 
            // gridColumnBuyInvoiceIDRet
            // 
            this.gridColumnBuyInvoiceIDRet.Caption = "BuyInvoiceID";
            this.gridColumnBuyInvoiceIDRet.FieldName = "BuyInvoiceID";
            this.gridColumnBuyInvoiceIDRet.Name = "gridColumnBuyInvoiceIDRet";
            // 
            // gridColumnDrugIDRet
            // 
            this.gridColumnDrugIDRet.Caption = "DrugID";
            this.gridColumnDrugIDRet.FieldName = "DrugID";
            this.gridColumnDrugIDRet.Name = "gridColumnDrugIDRet";
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(379, 522);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridSaleReturn;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(379, 496);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSave;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 496);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(379, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // SalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 522);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "SalesReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Борлуулалтын буцаалт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesReturn_FormClosing);
            this.Load += new System.EventHandler(this.SalesReturn_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalesReturn_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookSaleInvoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSale)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaleReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraGrid.GridControl gridSale;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSale;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridSaleReturn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSaleReturn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit lookSaleInvoice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleDetailID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNameSize;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleInvoiceID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem barReturnAddDrug;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBuyDetailID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCountRet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPriceRet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPriceRet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDateRet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBuyInvoiceIDRet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugIDRet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNameSizeRet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSalePrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
    }
}