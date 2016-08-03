namespace Pharmacy.ReportsForms
{
    partial class SaleReport
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
            this.combSelect = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.gridSaleInvoice = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.barInvoicePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewSaleInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnSaleInvoiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSaleInvoiceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCardID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleInvoice)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaleInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.combSelect);
            this.layoutControl1.Controls.Add(this.labelControl3);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.dateEnd);
            this.layoutControl1.Controls.Add(this.labelControl2);
            this.layoutControl1.Controls.Add(this.dateStart);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.btnView);
            this.layoutControl1.Controls.Add(this.gridSaleInvoice);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(794, 572);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // combSelect
            // 
            this.combSelect.Location = new System.Drawing.Point(472, 3);
            this.combSelect.Name = "combSelect";
            this.combSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combSelect.Properties.Items.AddRange(new object[] {
            "Бүгийг харах",
            "Зөвхөн хөнгөлөлтгүй",
            "Зөвхөн хөнгөлөлттэй",
            "Зарлага паданаар"});
            this.combSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.combSelect.Size = new System.Drawing.Size(100, 20);
            this.combSelect.StyleController = this.layoutControl1;
            this.combSelect.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(428, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.StyleController = this.layoutControl1;
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Сонгох:";
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(2, 548);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(790, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Хэвлэх";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(286, 3);
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
            this.dateEnd.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(212, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelControl2.Size = new System.Drawing.Size(70, 16);
            this.labelControl2.StyleController = this.layoutControl1;
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Хүртэл огноо:";
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
            this.dateStart.Size = new System.Drawing.Size(130, 20);
            this.dateStart.StyleController = this.layoutControl1;
            this.dateStart.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(66, 16);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Эхлэх огноо:";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(579, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(77, 22);
            this.btnView.StyleController = this.layoutControl1;
            this.btnView.TabIndex = 9;
            this.btnView.Text = "Харах";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // gridSaleInvoice
            // 
            this.gridSaleInvoice.ContextMenuStrip = this.contextMenuStrip1;
            this.gridSaleInvoice.Location = new System.Drawing.Point(2, 28);
            this.gridSaleInvoice.MainView = this.gridViewSaleInvoice;
            this.gridSaleInvoice.Name = "gridSaleInvoice";
            this.gridSaleInvoice.Size = new System.Drawing.Size(790, 516);
            this.gridSaleInvoice.TabIndex = 4;
            this.gridSaleInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSaleInvoice});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barInvoicePrint});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // barInvoicePrint
            // 
            this.barInvoicePrint.Name = "barInvoicePrint";
            this.barInvoicePrint.Size = new System.Drawing.Size(152, 22);
            this.barInvoicePrint.Text = "Падан &хэвлэх";
            this.barInvoicePrint.Click += new System.EventHandler(this.barInvoicePrint_Click);
            // 
            // gridViewSaleInvoice
            // 
            this.gridViewSaleInvoice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnSaleInvoiceID,
            this.gridColumnRowNum,
            this.gridColumnSaleInvoiceNum,
            this.gridColumnSumPrice,
            this.gridColumnActionDate,
            this.gridColumnUserID,
            this.gridColumnCardID,
            this.gridColumnSumDiscount,
            this.gridColumnCardName});
            this.gridViewSaleInvoice.GridControl = this.gridSaleInvoice;
            this.gridViewSaleInvoice.GroupPanelText = "Зарлагын тайлан /талоноор/";
            this.gridViewSaleInvoice.Name = "gridViewSaleInvoice";
            this.gridViewSaleInvoice.OptionsView.ShowFooter = true;
            // 
            // gridColumnSaleInvoiceID
            // 
            this.gridColumnSaleInvoiceID.Caption = "SaleInvoiceID";
            this.gridColumnSaleInvoiceID.FieldName = "SaleInvoiceID";
            this.gridColumnSaleInvoiceID.Name = "gridColumnSaleInvoiceID";
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
            // gridColumnSaleInvoiceNum
            // 
            this.gridColumnSaleInvoiceNum.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnSaleInvoiceNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSaleInvoiceNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSaleInvoiceNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSaleInvoiceNum.Caption = "Талон №";
            this.gridColumnSaleInvoiceNum.FieldName = "SaleInvoiceNum";
            this.gridColumnSaleInvoiceNum.Name = "gridColumnSaleInvoiceNum";
            this.gridColumnSaleInvoiceNum.OptionsColumn.AllowEdit = false;
            this.gridColumnSaleInvoiceNum.OptionsColumn.AllowFocus = false;
            this.gridColumnSaleInvoiceNum.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnSaleInvoiceNum.OptionsFilter.AllowFilter = false;
            this.gridColumnSaleInvoiceNum.Visible = true;
            this.gridColumnSaleInvoiceNum.VisibleIndex = 1;
            this.gridColumnSaleInvoiceNum.Width = 128;
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
            this.gridColumnSumPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumPrice", "₮{0:n2}")});
            this.gridColumnSumPrice.Visible = true;
            this.gridColumnSumPrice.VisibleIndex = 2;
            this.gridColumnSumPrice.Width = 128;
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
            this.gridColumnActionDate.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnActionDate.OptionsFilter.AllowFilter = false;
            this.gridColumnActionDate.Visible = true;
            this.gridColumnActionDate.VisibleIndex = 3;
            this.gridColumnActionDate.Width = 128;
            // 
            // gridColumnUserID
            // 
            this.gridColumnUserID.Caption = "UserID";
            this.gridColumnUserID.FieldName = "UserID";
            this.gridColumnUserID.Name = "gridColumnUserID";
            // 
            // gridColumnCardID
            // 
            this.gridColumnCardID.Caption = "CardID";
            this.gridColumnCardID.FieldName = "CardID";
            this.gridColumnCardID.Name = "gridColumnCardID";
            // 
            // gridColumnSumDiscount
            // 
            this.gridColumnSumDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSumDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSumDiscount.Caption = "Хөнгөлөлтийн дүн";
            this.gridColumnSumDiscount.DisplayFormat.FormatString = "n";
            this.gridColumnSumDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSumDiscount.FieldName = "SumDiscount";
            this.gridColumnSumDiscount.Name = "gridColumnSumDiscount";
            this.gridColumnSumDiscount.OptionsColumn.AllowEdit = false;
            this.gridColumnSumDiscount.OptionsColumn.AllowFocus = false;
            this.gridColumnSumDiscount.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnSumDiscount.OptionsFilter.AllowFilter = false;
            this.gridColumnSumDiscount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumDiscount", "₮{0:n2}")});
            this.gridColumnSumDiscount.Visible = true;
            this.gridColumnSumDiscount.VisibleIndex = 5;
            this.gridColumnSumDiscount.Width = 128;
            // 
            // gridColumnCardName
            // 
            this.gridColumnCardName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCardName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCardName.Caption = "Карт нэр";
            this.gridColumnCardName.FieldName = "CardName";
            this.gridColumnCardName.Name = "gridColumnCardName";
            this.gridColumnCardName.OptionsColumn.AllowEdit = false;
            this.gridColumnCardName.OptionsColumn.AllowFocus = false;
            this.gridColumnCardName.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnCardName.OptionsFilter.AllowFilter = false;
            this.gridColumnCardName.Visible = true;
            this.gridColumnCardName.VisibleIndex = 4;
            this.gridColumnCardName.Width = 128;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(794, 572);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridSaleInvoice;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(794, 520);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.labelControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(73, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateStart;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(73, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 3, 2);
            this.layoutControlItem3.Size = new System.Drawing.Size(134, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dateEnd;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(284, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 3, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(139, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelControl2;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(207, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(77, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnView;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(574, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.layoutControlItem6.Size = new System.Drawing.Size(87, 26);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnPrint;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 546);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(794, 26);
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(661, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(133, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.labelControl3;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(423, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 5, 2);
            this.layoutControlItem8.Size = new System.Drawing.Size(47, 26);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.combSelect;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(470, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 3, 2);
            this.layoutControlItem9.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem9.Text = "layoutControlItem9";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextToControlDistance = 0;
            this.layoutControlItem9.TextVisible = false;
            // 
            // SaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "SaleReport";
            this.Text = "Зарлагын тайлан";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaleReport_FormClosing);
            this.Load += new System.EventHandler(this.SaleReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.combSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleInvoice)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaleInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridSaleInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSaleInvoice;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleInvoiceID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleInvoiceNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCardID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCardName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
        private DevExpress.XtraEditors.ComboBoxEdit combSelect;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem barInvoicePrint;
    }
}