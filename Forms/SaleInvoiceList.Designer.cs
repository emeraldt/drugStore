namespace Pharmacy.Forms
{
    partial class SaleInvoiceList
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
            this.gridSaleInvoice = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.barInvoicePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.barInvoiceEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.barInvoiceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.barInvoiceDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewSaleInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSaleInvoiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSaleInvoiceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCardID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            this.gridSaleDetail = new DevExpress.XtraGrid.GridControl();
            this.gridViewSaleDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1RowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSaleDetailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNameSizePackage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1SumPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1ActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1SaleInvoiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleInvoice)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaleInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaleDetail)).BeginInit();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.gridSaleInvoice);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(844, 572);
            this.splitContainerControl1.SplitterPosition = 311;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridSaleInvoice
            // 
            this.gridSaleInvoice.ContextMenuStrip = this.contextMenuStrip1;
            this.gridSaleInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSaleInvoice.Location = new System.Drawing.Point(0, 0);
            this.gridSaleInvoice.MainView = this.gridViewSaleInvoice;
            this.gridSaleInvoice.Name = "gridSaleInvoice";
            this.gridSaleInvoice.Size = new System.Drawing.Size(311, 572);
            this.gridSaleInvoice.TabIndex = 0;
            this.gridSaleInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSaleInvoice});
            this.gridSaleInvoice.DoubleClick += new System.EventHandler(this.gridSaleInvoice_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barInvoicePrint,
            this.barInvoiceEdit,
            this.barInvoiceDetail,
            this.barInvoiceDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 92);
            // 
            // barInvoicePrint
            // 
            this.barInvoicePrint.Name = "barInvoicePrint";
            this.barInvoicePrint.Size = new System.Drawing.Size(188, 22);
            this.barInvoicePrint.Text = "Падан &хэвлэх";
            this.barInvoicePrint.Click += new System.EventHandler(this.barInvoicePrint_Click);
            // 
            // barInvoiceEdit
            // 
            this.barInvoiceEdit.Name = "barInvoiceEdit";
            this.barInvoiceEdit.Size = new System.Drawing.Size(188, 22);
            this.barInvoiceEdit.Text = "Падан &засварлах";
            this.barInvoiceEdit.Click += new System.EventHandler(this.barInvoiceEdit_Click);
            // 
            // barInvoiceDetail
            // 
            this.barInvoiceDetail.Name = "barInvoiceDetail";
            this.barInvoiceDetail.Size = new System.Drawing.Size(188, 22);
            this.barInvoiceDetail.Text = "Паданы &дэлгэрэнгүй";
            this.barInvoiceDetail.Click += new System.EventHandler(this.barInvoiceDetail_Click);
            // 
            // barInvoiceDelete
            // 
            this.barInvoiceDelete.Name = "barInvoiceDelete";
            this.barInvoiceDelete.Size = new System.Drawing.Size(188, 22);
            this.barInvoiceDelete.Text = "Падан &устгах";
            this.barInvoiceDelete.Click += new System.EventHandler(this.barInvoiceDelete_Click);
            // 
            // gridViewSaleInvoice
            // 
            this.gridViewSaleInvoice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnRowNum,
            this.gridColumnSaleInvoiceID,
            this.gridColumnSaleInvoiceNum,
            this.gridColumnSumPrice,
            this.gridColumnActionDate,
            this.gridColumnCardID,
            this.gridColumnSumDiscount,
            this.gridColumnUserID,
            this.gridColumnStatus});
            this.gridViewSaleInvoice.GridControl = this.gridSaleInvoice;
            this.gridViewSaleInvoice.Name = "gridViewSaleInvoice";
            this.gridViewSaleInvoice.OptionsView.ColumnAutoWidth = false;
            this.gridViewSaleInvoice.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSaleInvoice.OptionsView.ShowFooter = true;
            this.gridViewSaleInvoice.OptionsView.ShowGroupPanel = false;
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
            this.gridColumnRowNum.Visible = true;
            this.gridColumnRowNum.VisibleIndex = 0;
            this.gridColumnRowNum.Width = 35;
            // 
            // gridColumnSaleInvoiceID
            // 
            this.gridColumnSaleInvoiceID.Caption = "SaleInvoiceID";
            this.gridColumnSaleInvoiceID.FieldName = "SaleInvoiceID";
            this.gridColumnSaleInvoiceID.Name = "gridColumnSaleInvoiceID";
            // 
            // gridColumnSaleInvoiceNum
            // 
            this.gridColumnSaleInvoiceNum.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnSaleInvoiceNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSaleInvoiceNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSaleInvoiceNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSaleInvoiceNum.Caption = "Падан №";
            this.gridColumnSaleInvoiceNum.FieldName = "SaleInvoiceNum";
            this.gridColumnSaleInvoiceNum.Name = "gridColumnSaleInvoiceNum";
            this.gridColumnSaleInvoiceNum.OptionsColumn.AllowEdit = false;
            this.gridColumnSaleInvoiceNum.OptionsColumn.AllowFocus = false;
            this.gridColumnSaleInvoiceNum.Visible = true;
            this.gridColumnSaleInvoiceNum.VisibleIndex = 1;
            this.gridColumnSaleInvoiceNum.Width = 100;
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
            this.gridColumnSumPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumPrice", "₮{0:n2}")});
            this.gridColumnSumPrice.Visible = true;
            this.gridColumnSumPrice.VisibleIndex = 2;
            this.gridColumnSumPrice.Width = 90;
            // 
            // gridColumnActionDate
            // 
            this.gridColumnActionDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnActionDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnActionDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnActionDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnActionDate.Caption = "Огноо";
            this.gridColumnActionDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gridColumnActionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnActionDate.FieldName = "ActionDate";
            this.gridColumnActionDate.Name = "gridColumnActionDate";
            this.gridColumnActionDate.OptionsColumn.AllowEdit = false;
            this.gridColumnActionDate.OptionsColumn.AllowFocus = false;
            this.gridColumnActionDate.Visible = true;
            this.gridColumnActionDate.VisibleIndex = 3;
            // 
            // gridColumnCardID
            // 
            this.gridColumnCardID.Caption = "CardID";
            this.gridColumnCardID.FieldName = "CardID";
            this.gridColumnCardID.Name = "gridColumnCardID";
            // 
            // gridColumnSumDiscount
            // 
            this.gridColumnSumDiscount.Caption = "SumDiscount";
            this.gridColumnSumDiscount.FieldName = "SumDiscount";
            this.gridColumnSumDiscount.Name = "gridColumnSumDiscount";
            // 
            // gridColumnUserID
            // 
            this.gridColumnUserID.Caption = "UserID";
            this.gridColumnUserID.FieldName = "UserID";
            this.gridColumnUserID.Name = "gridColumnUserID";
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrintPreview);
            this.layoutControl1.Controls.Add(this.gridSaleDetail);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(528, 572);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(2, 548);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(524, 22);
            this.btnPrintPreview.StyleController = this.layoutControl1;
            this.btnPrintPreview.TabIndex = 4;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // gridSaleDetail
            // 
            this.gridSaleDetail.Location = new System.Drawing.Point(2, 2);
            this.gridSaleDetail.MainView = this.gridViewSaleDetail;
            this.gridSaleDetail.Name = "gridSaleDetail";
            this.gridSaleDetail.Size = new System.Drawing.Size(524, 542);
            this.gridSaleDetail.TabIndex = 0;
            this.gridSaleDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSaleDetail});
            // 
            // gridViewSaleDetail
            // 
            this.gridViewSaleDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1RowNum,
            this.gridColumnSaleDetailID,
            this.gridColumnNameSizePackage,
            this.gridColumnCount,
            this.gridColumnPrice,
            this.gridColumn1SumPrice,
            this.gridColumn1ActionDate,
            this.gridColumn1SaleInvoiceID,
            this.gridColumnDrugID});
            this.gridViewSaleDetail.GridControl = this.gridSaleDetail;
            this.gridViewSaleDetail.Name = "gridViewSaleDetail";
            this.gridViewSaleDetail.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSaleDetail.OptionsView.ShowFooter = true;
            this.gridViewSaleDetail.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1RowNum
            // 
            this.gridColumn1RowNum.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1RowNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1RowNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1RowNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1RowNum.Caption = "№";
            this.gridColumn1RowNum.FieldName = "RowNum";
            this.gridColumn1RowNum.Name = "gridColumn1RowNum";
            this.gridColumn1RowNum.OptionsColumn.AllowEdit = false;
            this.gridColumn1RowNum.OptionsColumn.AllowFocus = false;
            this.gridColumn1RowNum.Visible = true;
            this.gridColumn1RowNum.VisibleIndex = 0;
            this.gridColumn1RowNum.Width = 35;
            // 
            // gridColumnSaleDetailID
            // 
            this.gridColumnSaleDetailID.Caption = "SaleDetailID";
            this.gridColumnSaleDetailID.FieldName = "SaleDetailID";
            this.gridColumnSaleDetailID.Name = "gridColumnSaleDetailID";
            // 
            // gridColumnNameSizePackage
            // 
            this.gridColumnNameSizePackage.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNameSizePackage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNameSizePackage.Caption = "Эмийн нэр";
            this.gridColumnNameSizePackage.FieldName = "NameSizePackage";
            this.gridColumnNameSizePackage.Name = "gridColumnNameSizePackage";
            this.gridColumnNameSizePackage.OptionsColumn.AllowEdit = false;
            this.gridColumnNameSizePackage.OptionsColumn.AllowFocus = false;
            this.gridColumnNameSizePackage.Visible = true;
            this.gridColumnNameSizePackage.VisibleIndex = 1;
            this.gridColumnNameSizePackage.Width = 144;
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
            this.gridColumnCount.Width = 81;
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
            this.gridColumnPrice.Width = 81;
            // 
            // gridColumn1SumPrice
            // 
            this.gridColumn1SumPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1SumPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1SumPrice.Caption = "Нийт дүн";
            this.gridColumn1SumPrice.DisplayFormat.FormatString = "n";
            this.gridColumn1SumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1SumPrice.FieldName = "SumPrice";
            this.gridColumn1SumPrice.Name = "gridColumn1SumPrice";
            this.gridColumn1SumPrice.OptionsColumn.AllowEdit = false;
            this.gridColumn1SumPrice.OptionsColumn.AllowFocus = false;
            this.gridColumn1SumPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumPrice", "₮{0:n2}")});
            this.gridColumn1SumPrice.Visible = true;
            this.gridColumn1SumPrice.VisibleIndex = 4;
            this.gridColumn1SumPrice.Width = 81;
            // 
            // gridColumn1ActionDate
            // 
            this.gridColumn1ActionDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1ActionDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1ActionDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1ActionDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1ActionDate.Caption = "Огноо";
            this.gridColumn1ActionDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gridColumn1ActionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1ActionDate.FieldName = "ActionDate";
            this.gridColumn1ActionDate.Name = "gridColumn1ActionDate";
            this.gridColumn1ActionDate.OptionsColumn.AllowEdit = false;
            this.gridColumn1ActionDate.OptionsColumn.AllowFocus = false;
            this.gridColumn1ActionDate.Visible = true;
            this.gridColumn1ActionDate.VisibleIndex = 5;
            this.gridColumn1ActionDate.Width = 88;
            // 
            // gridColumn1SaleInvoiceID
            // 
            this.gridColumn1SaleInvoiceID.Caption = "SaleInvoiceID";
            this.gridColumn1SaleInvoiceID.FieldName = "SaleInvoiceID";
            this.gridColumn1SaleInvoiceID.Name = "gridColumn1SaleInvoiceID";
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
            this.layoutControlItem1.Control = this.gridSaleDetail;
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
            // SaleInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 572);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "SaleInvoiceList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Зарлагын паданын жагсаалт";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaleInvoiceList_FormClosing);
            this.Load += new System.EventHandler(this.SaleInvoiceList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleInvoiceList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleInvoice)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaleInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaleDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridSaleDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSaleDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleInvoiceID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleInvoiceNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCardID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1RowNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleDetailID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNameSizePackage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1SumPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1ActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1SaleInvoiceID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem barInvoicePrint;
        private System.Windows.Forms.ToolStripMenuItem barInvoiceEdit;
        private System.Windows.Forms.ToolStripMenuItem barInvoiceDetail;
        private System.Windows.Forms.ToolStripMenuItem barInvoiceDelete;
        public DevExpress.XtraGrid.GridControl gridSaleInvoice;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewSaleInvoice;
    }
}