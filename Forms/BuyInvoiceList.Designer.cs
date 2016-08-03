namespace Pharmacy.Forms
{
    partial class BuyInvoiceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyInvoiceList));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gridBuyInvoice = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.barInvoicePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.barInvoicePrintSalePrice = new System.Windows.Forms.ToolStripMenuItem();
            this.barInvoiceEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.barInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.barInvoiceDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewBuyInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBuyInvoiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnInvoiceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBuyInvoiceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSupplierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            this.gridBuyDetail = new DevExpress.XtraGrid.GridControl();
            this.gridViewBuyDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBuyDetailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumPriceDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDateDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNameDrug = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBuyInvoiceIDDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyInvoice)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBuyInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBuyDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(844, 572);
            this.splitContainerControl1.SplitterPosition = 311;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gridBuyInvoice);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(311, 572);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // gridBuyInvoice
            // 
            this.gridBuyInvoice.ContextMenuStrip = this.contextMenuStrip1;
            this.gridBuyInvoice.Location = new System.Drawing.Point(2, 2);
            this.gridBuyInvoice.MainView = this.gridViewBuyInvoice;
            this.gridBuyInvoice.Name = "gridBuyInvoice";
            this.gridBuyInvoice.Size = new System.Drawing.Size(307, 568);
            this.gridBuyInvoice.TabIndex = 0;
            this.gridBuyInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBuyInvoice});
            this.gridBuyInvoice.DoubleClick += new System.EventHandler(this.gridBuyInvoice_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barInvoicePrint,
            this.barInvoicePrintSalePrice,
            this.barInvoiceEdit,
            this.barInvoiceDetail,
            this.barInvoiceDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 136);
            // 
            // barInvoicePrint
            // 
            this.barInvoicePrint.Name = "barInvoicePrint";
            this.barInvoicePrint.Size = new System.Drawing.Size(225, 22);
            this.barInvoicePrint.Text = "Падан &хэвлэх /өртөг үнээр/";
            this.barInvoicePrint.Click += new System.EventHandler(this.barInvoicePrint_Click);
            // 
            // barInvoicePrintSalePrice
            // 
            this.barInvoicePrintSalePrice.Name = "barInvoicePrintSalePrice";
            this.barInvoicePrintSalePrice.Size = new System.Drawing.Size(225, 22);
            this.barInvoicePrintSalePrice.Text = "Падан хэвлэх /зарах үнээр/";
            this.barInvoicePrintSalePrice.Click += new System.EventHandler(this.barInvoicePrintSalePrice_Click);
            // 
            // barInvoiceEdit
            // 
            this.barInvoiceEdit.Name = "barInvoiceEdit";
            this.barInvoiceEdit.Size = new System.Drawing.Size(225, 22);
            this.barInvoiceEdit.Text = "Падан &засварлах";
            this.barInvoiceEdit.Click += new System.EventHandler(this.barInvoiceEdit_Click);
            // 
            // barInvoiceDetail
            // 
            this.barInvoiceDetail.Name = "barInvoiceDetail";
            this.barInvoiceDetail.Size = new System.Drawing.Size(225, 22);
            this.barInvoiceDetail.Text = "Паданы &дэлгэрэнгүй";
            this.barInvoiceDetail.Click += new System.EventHandler(this.gridBuyInvoice_DoubleClick);
            // 
            // barInvoiceDelete
            // 
            this.barInvoiceDelete.Name = "barInvoiceDelete";
            this.barInvoiceDelete.Size = new System.Drawing.Size(225, 22);
            this.barInvoiceDelete.Text = "Падан &устгах";
            this.barInvoiceDelete.Click += new System.EventHandler(this.barInvoiceDelete_Click);
            // 
            // gridViewBuyInvoice
            // 
            this.gridViewBuyInvoice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnBuyInvoiceID,
            this.gridColumnRowNum1,
            this.gridColumnLoan,
            this.gridColumnName,
            this.gridColumnActionDate,
            this.gridColumnSumPrice,
            this.gridColumnInvoiceDate,
            this.gridColumnInvoiceNum,
            this.gridColumnBuyInvoiceNum,
            this.gridColumnSupplierID,
            this.gridColumnStatus});
            this.gridViewBuyInvoice.GridControl = this.gridBuyInvoice;
            this.gridViewBuyInvoice.Name = "gridViewBuyInvoice";
            this.gridViewBuyInvoice.OptionsView.ColumnAutoWidth = false;
            this.gridViewBuyInvoice.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBuyInvoice.OptionsView.ShowFooter = true;
            this.gridViewBuyInvoice.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnBuyInvoiceID
            // 
            this.gridColumnBuyInvoiceID.Caption = "BuyInvoiceID";
            this.gridColumnBuyInvoiceID.FieldName = "BuyInvoiceID";
            this.gridColumnBuyInvoiceID.Name = "gridColumnBuyInvoiceID";
            // 
            // gridColumnRowNum1
            // 
            this.gridColumnRowNum1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnRowNum1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnRowNum1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnRowNum1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnRowNum1.Caption = "№";
            this.gridColumnRowNum1.FieldName = "RowNum";
            this.gridColumnRowNum1.Name = "gridColumnRowNum1";
            this.gridColumnRowNum1.OptionsColumn.AllowEdit = false;
            this.gridColumnRowNum1.OptionsColumn.AllowFocus = false;
            this.gridColumnRowNum1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnRowNum1.OptionsFilter.AllowFilter = false;
            this.gridColumnRowNum1.Visible = true;
            this.gridColumnRowNum1.VisibleIndex = 0;
            this.gridColumnRowNum1.Width = 35;
            // 
            // gridColumnLoan
            // 
            this.gridColumnLoan.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnLoan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnLoan.Caption = "Зээл";
            this.gridColumnLoan.FieldName = "Loan";
            this.gridColumnLoan.Name = "gridColumnLoan";
            this.gridColumnLoan.OptionsColumn.AllowEdit = false;
            this.gridColumnLoan.OptionsColumn.AllowFocus = false;
            this.gridColumnLoan.Visible = true;
            this.gridColumnLoan.VisibleIndex = 1;
            this.gridColumnLoan.Width = 35;
            // 
            // gridColumnName
            // 
            this.gridColumnName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnName.Caption = "Нийлүүлэгч";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.AllowFocus = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 2;
            this.gridColumnName.Width = 120;
            // 
            // gridColumnActionDate
            // 
            this.gridColumnActionDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnActionDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnActionDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnActionDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnActionDate.Caption = "Шивсэн огноо";
            this.gridColumnActionDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gridColumnActionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnActionDate.FieldName = "ActionDate";
            this.gridColumnActionDate.Name = "gridColumnActionDate";
            this.gridColumnActionDate.OptionsColumn.AllowEdit = false;
            this.gridColumnActionDate.OptionsColumn.AllowFocus = false;
            this.gridColumnActionDate.Visible = true;
            this.gridColumnActionDate.VisibleIndex = 3;
            this.gridColumnActionDate.Width = 100;
            // 
            // gridColumnSumPrice
            // 
            this.gridColumnSumPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSumPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSumPrice.Caption = "Нийт дүн";
            this.gridColumnSumPrice.FieldName = "SumPrice";
            this.gridColumnSumPrice.Name = "gridColumnSumPrice";
            this.gridColumnSumPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnSumPrice.OptionsColumn.AllowFocus = false;
            this.gridColumnSumPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumPrice", "₮{0:###,###,###,###.##}")});
            this.gridColumnSumPrice.Visible = true;
            this.gridColumnSumPrice.VisibleIndex = 4;
            this.gridColumnSumPrice.Width = 90;
            // 
            // gridColumnInvoiceDate
            // 
            this.gridColumnInvoiceDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnInvoiceDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnInvoiceDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnInvoiceDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnInvoiceDate.Caption = "Огноо";
            this.gridColumnInvoiceDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gridColumnInvoiceDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnInvoiceDate.FieldName = "InvoiceDate";
            this.gridColumnInvoiceDate.Name = "gridColumnInvoiceDate";
            this.gridColumnInvoiceDate.OptionsColumn.AllowEdit = false;
            this.gridColumnInvoiceDate.OptionsColumn.AllowFocus = false;
            this.gridColumnInvoiceDate.Visible = true;
            this.gridColumnInvoiceDate.VisibleIndex = 5;
            // 
            // gridColumnInvoiceNum
            // 
            this.gridColumnInvoiceNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnInvoiceNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnInvoiceNum.Caption = "Дугаар";
            this.gridColumnInvoiceNum.FieldName = "InvoiceNum";
            this.gridColumnInvoiceNum.Name = "gridColumnInvoiceNum";
            this.gridColumnInvoiceNum.OptionsColumn.AllowEdit = false;
            this.gridColumnInvoiceNum.OptionsColumn.AllowFocus = false;
            this.gridColumnInvoiceNum.Visible = true;
            this.gridColumnInvoiceNum.VisibleIndex = 6;
            this.gridColumnInvoiceNum.Width = 80;
            // 
            // gridColumnBuyInvoiceNum
            // 
            this.gridColumnBuyInvoiceNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnBuyInvoiceNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBuyInvoiceNum.Caption = "Падан №";
            this.gridColumnBuyInvoiceNum.FieldName = "BuyInvoiceNum";
            this.gridColumnBuyInvoiceNum.Name = "gridColumnBuyInvoiceNum";
            this.gridColumnBuyInvoiceNum.OptionsColumn.AllowEdit = false;
            this.gridColumnBuyInvoiceNum.OptionsColumn.AllowFocus = false;
            this.gridColumnBuyInvoiceNum.Visible = true;
            this.gridColumnBuyInvoiceNum.VisibleIndex = 7;
            this.gridColumnBuyInvoiceNum.Width = 100;
            // 
            // gridColumnSupplierID
            // 
            this.gridColumnSupplierID.Caption = "SupplierID";
            this.gridColumnSupplierID.FieldName = "SupplierID";
            this.gridColumnSupplierID.Name = "gridColumnSupplierID";
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
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(311, 572);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridBuyInvoice;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(311, 572);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrintPreview);
            this.layoutControl1.Controls.Add(this.gridBuyDetail);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(528, 572);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(2, 548);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(524, 22);
            this.btnPrintPreview.StyleController = this.layoutControl1;
            this.btnPrintPreview.TabIndex = 5;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // gridBuyDetail
            // 
            this.gridBuyDetail.Location = new System.Drawing.Point(2, 2);
            this.gridBuyDetail.MainView = this.gridViewBuyDetail;
            this.gridBuyDetail.Name = "gridBuyDetail";
            this.gridBuyDetail.Size = new System.Drawing.Size(524, 542);
            this.gridBuyDetail.TabIndex = 4;
            this.gridBuyDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBuyDetail});
            // 
            // gridViewBuyDetail
            // 
            this.gridViewBuyDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnBuyDetailID,
            this.gridColumnRowNum2,
            this.gridColumnCount,
            this.gridColumnPrice,
            this.gridColumnSumPriceDetail,
            this.gridColumnActionDateDetail,
            this.gridColumnNameDrug,
            this.gridColumnBuyInvoiceIDDetail,
            this.gridColumnDrugID});
            this.gridViewBuyDetail.GridControl = this.gridBuyDetail;
            this.gridViewBuyDetail.Name = "gridViewBuyDetail";
            this.gridViewBuyDetail.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBuyDetail.OptionsView.ShowFooter = true;
            this.gridViewBuyDetail.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnBuyDetailID
            // 
            this.gridColumnBuyDetailID.Caption = "BuyDetailID";
            this.gridColumnBuyDetailID.FieldName = "BuyDetailID";
            this.gridColumnBuyDetailID.Name = "gridColumnBuyDetailID";
            // 
            // gridColumnRowNum2
            // 
            this.gridColumnRowNum2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnRowNum2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnRowNum2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnRowNum2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnRowNum2.Caption = "№";
            this.gridColumnRowNum2.FieldName = "RowNum";
            this.gridColumnRowNum2.Name = "gridColumnRowNum2";
            this.gridColumnRowNum2.OptionsColumn.AllowEdit = false;
            this.gridColumnRowNum2.OptionsColumn.AllowFocus = false;
            this.gridColumnRowNum2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnRowNum2.OptionsFilter.AllowFilter = false;
            this.gridColumnRowNum2.Visible = true;
            this.gridColumnRowNum2.VisibleIndex = 0;
            this.gridColumnRowNum2.Width = 35;
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
            this.gridColumnCount.Visible = true;
            this.gridColumnCount.VisibleIndex = 2;
            this.gridColumnCount.Width = 79;
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
            this.gridColumnPrice.Visible = true;
            this.gridColumnPrice.VisibleIndex = 3;
            this.gridColumnPrice.Width = 79;
            // 
            // gridColumnSumPriceDetail
            // 
            this.gridColumnSumPriceDetail.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSumPriceDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSumPriceDetail.Caption = "Нийт дүн";
            this.gridColumnSumPriceDetail.DisplayFormat.FormatString = "n";
            this.gridColumnSumPriceDetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSumPriceDetail.FieldName = "SumPrice";
            this.gridColumnSumPriceDetail.Name = "gridColumnSumPriceDetail";
            this.gridColumnSumPriceDetail.OptionsColumn.AllowEdit = false;
            this.gridColumnSumPriceDetail.OptionsColumn.AllowFocus = false;
            this.gridColumnSumPriceDetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumPrice", "₮{0:n2}")});
            this.gridColumnSumPriceDetail.Visible = true;
            this.gridColumnSumPriceDetail.VisibleIndex = 4;
            this.gridColumnSumPriceDetail.Width = 79;
            // 
            // gridColumnActionDateDetail
            // 
            this.gridColumnActionDateDetail.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnActionDateDetail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnActionDateDetail.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnActionDateDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnActionDateDetail.Caption = "Огноо";
            this.gridColumnActionDateDetail.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gridColumnActionDateDetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnActionDateDetail.FieldName = "ActionDate";
            this.gridColumnActionDateDetail.Name = "gridColumnActionDateDetail";
            this.gridColumnActionDateDetail.OptionsColumn.AllowEdit = false;
            this.gridColumnActionDateDetail.OptionsColumn.AllowFocus = false;
            this.gridColumnActionDateDetail.Visible = true;
            this.gridColumnActionDateDetail.VisibleIndex = 5;
            this.gridColumnActionDateDetail.Width = 84;
            // 
            // gridColumnNameDrug
            // 
            this.gridColumnNameDrug.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNameDrug.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNameDrug.Caption = "Эмийн нэр";
            this.gridColumnNameDrug.FieldName = "Name";
            this.gridColumnNameDrug.Name = "gridColumnNameDrug";
            this.gridColumnNameDrug.OptionsColumn.AllowEdit = false;
            this.gridColumnNameDrug.OptionsColumn.AllowFocus = false;
            this.gridColumnNameDrug.Visible = true;
            this.gridColumnNameDrug.VisibleIndex = 1;
            this.gridColumnNameDrug.Width = 121;
            // 
            // gridColumnBuyInvoiceIDDetail
            // 
            this.gridColumnBuyInvoiceIDDetail.Caption = "BuyInvoiceID";
            this.gridColumnBuyInvoiceIDDetail.FieldName = "BuyInvoiceID";
            this.gridColumnBuyInvoiceIDDetail.Name = "gridColumnBuyInvoiceIDDetail";
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
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(528, 572);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridBuyDetail;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(528, 546);
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
            this.layoutControlItem2.Size = new System.Drawing.Size(528, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // BuyInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 572);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "BuyInvoiceList";
            this.ShowInTaskbar = false;
            this.Text = "Орлогын паданын жагсаалт";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuyInvoiceList_FormClosing);
            this.Load += new System.EventHandler(this.BuyInvoiceList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BuyInvoiceList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyInvoice)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBuyInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBuyDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBuyInvoiceID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBuyInvoiceNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnInvoiceNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSupplierID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLoan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBuyDetailID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPriceDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDateDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNameDrug;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBuyInvoiceIDDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        public DevExpress.XtraGrid.GridControl gridBuyInvoice;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewBuyInvoice;
        public DevExpress.XtraGrid.GridControl gridBuyDetail;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewBuyDetail;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem barInvoicePrint;
        private System.Windows.Forms.ToolStripMenuItem barInvoiceEdit;
        private System.Windows.Forms.ToolStripMenuItem barInvoiceDetail;
        private System.Windows.Forms.ToolStripMenuItem barInvoiceDelete;
        private System.Windows.Forms.ToolStripMenuItem barInvoicePrintSalePrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum2;
    }
}