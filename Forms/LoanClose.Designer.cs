namespace Pharmacy.Forms
{
    partial class LoanClose
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
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.chbLoan = new DevExpress.XtraEditors.CheckEdit();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLoanClose = new DevExpress.XtraGrid.GridControl();
            this.gridViewLoanClose = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBuyInvoiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBuyInvoiceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnInvoiceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSupplierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFirstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbLoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoanClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoanClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dateEnd);
            this.layoutControl1.Controls.Add(this.labelControl2);
            this.layoutControl1.Controls.Add(this.btnView);
            this.layoutControl1.Controls.Add(this.chbLoan);
            this.layoutControl1.Controls.Add(this.dateStart);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.gridLoanClose);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(794, 572);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
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
            this.dateEnd.Size = new System.Drawing.Size(136, 20);
            this.dateEnd.StyleController = this.layoutControl1;
            this.dateEnd.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(212, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.StyleController = this.layoutControl1;
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Хүртэл огноо:";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(531, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(110, 22);
            this.btnView.StyleController = this.layoutControl1;
            this.btnView.TabIndex = 8;
            this.btnView.Text = "Хайх";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // chbLoan
            // 
            this.chbLoan.Location = new System.Drawing.Point(426, 3);
            this.chbLoan.Name = "chbLoan";
            this.chbLoan.Properties.Caption = "зээлээр авсан";
            this.chbLoan.Size = new System.Drawing.Size(98, 19);
            this.chbLoan.StyleController = this.layoutControl1;
            this.chbLoan.TabIndex = 7;
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
            this.labelControl1.Location = new System.Drawing.Point(5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Эхлэх огноо:";
            // 
            // gridLoanClose
            // 
            this.gridLoanClose.Location = new System.Drawing.Point(2, 28);
            this.gridLoanClose.MainView = this.gridViewLoanClose;
            this.gridLoanClose.Name = "gridLoanClose";
            this.gridLoanClose.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
            this.gridLoanClose.Size = new System.Drawing.Size(790, 542);
            this.gridLoanClose.TabIndex = 4;
            this.gridLoanClose.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLoanClose});
            // 
            // gridViewLoanClose
            // 
            this.gridViewLoanClose.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnBuyInvoiceID,
            this.gridColumnRowNum,
            this.gridColumnBuyInvoiceNum,
            this.gridColumnInvoiceNum,
            this.gridColumnInvoiceDate,
            this.gridColumnSumPrice,
            this.gridColumnActionDate,
            this.gridColumnSupplierID,
            this.gridColumnLoan,
            this.gridColumnStatus,
            this.gridColumnUserID,
            this.gridColumnName,
            this.gridColumnFirstname,
            this.gridColumn1});
            this.gridViewLoanClose.GridControl = this.gridLoanClose;
            this.gridViewLoanClose.GroupPanelText = "Зээлээр авсан паданы эргэн төлөлт";
            this.gridViewLoanClose.Name = "gridViewLoanClose";
            this.gridViewLoanClose.OptionsView.ShowFooter = true;
            // 
            // gridColumnBuyInvoiceID
            // 
            this.gridColumnBuyInvoiceID.Caption = "BuyInvoiceID";
            this.gridColumnBuyInvoiceID.FieldName = "BuyInvoiceID";
            this.gridColumnBuyInvoiceID.Name = "gridColumnBuyInvoiceID";
            // 
            // gridColumnBuyInvoiceNum
            // 
            this.gridColumnBuyInvoiceNum.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnBuyInvoiceNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBuyInvoiceNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnBuyInvoiceNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBuyInvoiceNum.Caption = "Падан №";
            this.gridColumnBuyInvoiceNum.FieldName = "BuyInvoiceNum";
            this.gridColumnBuyInvoiceNum.Name = "gridColumnBuyInvoiceNum";
            this.gridColumnBuyInvoiceNum.OptionsColumn.AllowEdit = false;
            this.gridColumnBuyInvoiceNum.OptionsColumn.AllowFocus = false;
            this.gridColumnBuyInvoiceNum.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnBuyInvoiceNum.OptionsFilter.AllowFilter = false;
            this.gridColumnBuyInvoiceNum.Visible = true;
            this.gridColumnBuyInvoiceNum.VisibleIndex = 1;
            this.gridColumnBuyInvoiceNum.Width = 138;
            // 
            // gridColumnInvoiceNum
            // 
            this.gridColumnInvoiceNum.Caption = "InvoiceNum";
            this.gridColumnInvoiceNum.FieldName = "InvoiceNum";
            this.gridColumnInvoiceNum.Name = "gridColumnInvoiceNum";
            // 
            // gridColumnInvoiceDate
            // 
            this.gridColumnInvoiceDate.Caption = "InvoiceDate";
            this.gridColumnInvoiceDate.FieldName = "InvoiceDate";
            this.gridColumnInvoiceDate.Name = "gridColumnInvoiceDate";
            // 
            // gridColumnSumPrice
            // 
            this.gridColumnSumPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSumPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSumPrice.Caption = "Ний дүн";
            this.gridColumnSumPrice.FieldName = "SumPrice";
            this.gridColumnSumPrice.Name = "gridColumnSumPrice";
            this.gridColumnSumPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnSumPrice.OptionsColumn.AllowFocus = false;
            this.gridColumnSumPrice.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnSumPrice.OptionsFilter.AllowFilter = false;
            this.gridColumnSumPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumPrice", "₮{0:###,###,###,###.##}")});
            this.gridColumnSumPrice.Visible = true;
            this.gridColumnSumPrice.VisibleIndex = 2;
            this.gridColumnSumPrice.Width = 77;
            // 
            // gridColumnActionDate
            // 
            this.gridColumnActionDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnActionDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnActionDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnActionDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnActionDate.Caption = "Огноо";
            this.gridColumnActionDate.DisplayFormat.FormatString = "yyyy-MM-dd hh:mm:ss";
            this.gridColumnActionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnActionDate.FieldName = "ActionDate";
            this.gridColumnActionDate.Name = "gridColumnActionDate";
            this.gridColumnActionDate.OptionsColumn.AllowEdit = false;
            this.gridColumnActionDate.OptionsColumn.AllowFocus = false;
            this.gridColumnActionDate.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnActionDate.OptionsFilter.AllowFilter = false;
            this.gridColumnActionDate.Visible = true;
            this.gridColumnActionDate.VisibleIndex = 3;
            this.gridColumnActionDate.Width = 117;
            // 
            // gridColumnSupplierID
            // 
            this.gridColumnSupplierID.Caption = "SupplierID";
            this.gridColumnSupplierID.FieldName = "SupplierID";
            this.gridColumnSupplierID.Name = "gridColumnSupplierID";
            // 
            // gridColumnLoan
            // 
            this.gridColumnLoan.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnLoan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnLoan.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnLoan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnLoan.Caption = "Зээл";
            this.gridColumnLoan.FieldName = "Loan";
            this.gridColumnLoan.Name = "gridColumnLoan";
            this.gridColumnLoan.OptionsColumn.AllowEdit = false;
            this.gridColumnLoan.OptionsColumn.AllowFocus = false;
            this.gridColumnLoan.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnLoan.OptionsFilter.AllowFilter = false;
            this.gridColumnLoan.Visible = true;
            this.gridColumnLoan.VisibleIndex = 4;
            this.gridColumnLoan.Width = 86;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            // 
            // gridColumnUserID
            // 
            this.gridColumnUserID.Caption = "UserID";
            this.gridColumnUserID.FieldName = "UserID";
            this.gridColumnUserID.Name = "gridColumnUserID";
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
            this.gridColumnName.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnName.OptionsFilter.AllowFilter = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 5;
            this.gridColumnName.Width = 117;
            // 
            // gridColumnFirstname
            // 
            this.gridColumnFirstname.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnFirstname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnFirstname.Caption = "Орлогодсон ажилтан";
            this.gridColumnFirstname.FieldName = "Firstname";
            this.gridColumnFirstname.Name = "gridColumnFirstname";
            this.gridColumnFirstname.OptionsColumn.AllowEdit = false;
            this.gridColumnFirstname.OptionsColumn.AllowFocus = false;
            this.gridColumnFirstname.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnFirstname.OptionsFilter.AllowFilter = false;
            this.gridColumnFirstname.Visible = true;
            this.gridColumnFirstname.VisibleIndex = 6;
            this.gridColumnFirstname.Width = 131;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "төлөлт";
            this.gridColumn1.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.gridColumn1.FieldName = "BuyInvoiceID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 71;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Caption = "төлөлт";
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit1_Click);
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
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(794, 572);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridLoanClose;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(794, 546);
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
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 5, 2);
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
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chbLoan;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(424, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 3, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(102, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnView;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(526, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(646, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(148, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.labelControl2;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(207, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 5, 2);
            this.layoutControlItem6.Size = new System.Drawing.Size(77, 26);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dateEnd;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(284, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 3, 2);
            this.layoutControlItem7.Size = new System.Drawing.Size(140, 26);
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
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
            // LoanClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "LoanClose";
            this.Text = "Зээл төлөлт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoanClose_FormClosing);
            this.Load += new System.EventHandler(this.LoanClose_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoanClose_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbLoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoanClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoanClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridLoanClose;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLoanClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.CheckEdit chbLoan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBuyInvoiceID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBuyInvoiceNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnInvoiceNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSupplierID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLoan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFirstname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
    }
}