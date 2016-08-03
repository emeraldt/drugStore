namespace Pharmacy.ReportsForms
{
    partial class ExpirationDrugReport
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
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridExpirationDrugReport = new DevExpress.XtraGrid.GridControl();
            this.gridViewExpirationDrugReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnExpirationDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSumPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNameSizePackage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFirstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExpirationDrugReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExpirationDrugReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dateEnd);
            this.layoutControl1.Controls.Add(this.labelControl2);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.btnView);
            this.layoutControl1.Controls.Add(this.dateStart);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.gridExpirationDrugReport);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(784, 562);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(287, 3);
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
            this.labelControl2.Location = new System.Drawing.Point(213, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.StyleController = this.layoutControl1;
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Хүртэл огноо:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(2, 538);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(780, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Хэвлэх";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(430, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(113, 22);
            this.btnView.StyleController = this.layoutControl1;
            this.btnView.TabIndex = 7;
            this.btnView.Text = "Харах";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            this.dateStart.Size = new System.Drawing.Size(131, 20);
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
            // gridExpirationDrugReport
            // 
            this.gridExpirationDrugReport.Location = new System.Drawing.Point(2, 28);
            this.gridExpirationDrugReport.MainView = this.gridViewExpirationDrugReport;
            this.gridExpirationDrugReport.Name = "gridExpirationDrugReport";
            this.gridExpirationDrugReport.Size = new System.Drawing.Size(780, 506);
            this.gridExpirationDrugReport.TabIndex = 4;
            this.gridExpirationDrugReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewExpirationDrugReport});
            // 
            // gridViewExpirationDrugReport
            // 
            this.gridViewExpirationDrugReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnExpirationDrugID,
            this.gridColumnDrugID,
            this.gridColumnRowNum,
            this.gridColumnCount,
            this.gridColumnPrice,
            this.gridColumnSumPrice,
            this.gridColumnActionDate,
            this.gridColumnUserID,
            this.gridColumnNameSizePackage,
            this.gridColumnFirstname});
            this.gridViewExpirationDrugReport.GridControl = this.gridExpirationDrugReport;
            this.gridViewExpirationDrugReport.GroupPanelText = "Хугацаа дууссан эмийн тайлан";
            this.gridViewExpirationDrugReport.Name = "gridViewExpirationDrugReport";
            this.gridViewExpirationDrugReport.OptionsView.ShowFooter = true;
            // 
            // gridColumnExpirationDrugID
            // 
            this.gridColumnExpirationDrugID.Caption = "ExpirationDrugID";
            this.gridColumnExpirationDrugID.FieldName = "ExpirationDrugID";
            this.gridColumnExpirationDrugID.Name = "gridColumnExpirationDrugID";
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
            // gridColumnCount
            // 
            this.gridColumnCount.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.gridColumnCount.Width = 68;
            // 
            // gridColumnPrice
            // 
            this.gridColumnPrice.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.gridColumnPrice.Width = 67;
            // 
            // gridColumnSumPrice
            // 
            this.gridColumnSumPrice.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnSumPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.gridColumnSumPrice.VisibleIndex = 4;
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
            this.gridColumnActionDate.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnActionDate.OptionsFilter.AllowFilter = false;
            this.gridColumnActionDate.Visible = true;
            this.gridColumnActionDate.VisibleIndex = 5;
            this.gridColumnActionDate.Width = 102;
            // 
            // gridColumnUserID
            // 
            this.gridColumnUserID.Caption = "UserID";
            this.gridColumnUserID.FieldName = "UserID";
            this.gridColumnUserID.Name = "gridColumnUserID";
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
            this.gridColumnNameSizePackage.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnNameSizePackage.OptionsFilter.AllowFilter = false;
            this.gridColumnNameSizePackage.Visible = true;
            this.gridColumnNameSizePackage.VisibleIndex = 1;
            this.gridColumnNameSizePackage.Width = 280;
            // 
            // gridColumnFirstname
            // 
            this.gridColumnFirstname.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnFirstname.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnFirstname.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnFirstname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnFirstname.Caption = "Бүртгэсэн ажилтан";
            this.gridColumnFirstname.FieldName = "Firstname";
            this.gridColumnFirstname.Name = "gridColumnFirstname";
            this.gridColumnFirstname.OptionsColumn.AllowEdit = false;
            this.gridColumnFirstname.OptionsColumn.AllowFocus = false;
            this.gridColumnFirstname.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnFirstname.OptionsFilter.AllowFilter = false;
            this.gridColumnFirstname.Visible = true;
            this.gridColumnFirstname.VisibleIndex = 6;
            this.gridColumnFirstname.Width = 120;
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
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(784, 562);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridExpirationDrugReport;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(784, 510);
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
            this.layoutControlItem3.Size = new System.Drawing.Size(135, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnView;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(425, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(123, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(548, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(236, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnPrint;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 536);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(784, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.labelControl2;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(208, 0);
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
            this.layoutControlItem7.Location = new System.Drawing.Point(285, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 3, 2);
            this.layoutControlItem7.Size = new System.Drawing.Size(140, 26);
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // ExpirationDrugReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "ExpirationDrugReport";
            this.Text = "Хугацаа дууссан эмийн тайлан";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpirationDrugReport_FormClosing);
            this.Load += new System.EventHandler(this.ExpirationDrugReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExpirationDrugReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExpirationDrugReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExpirationDrugReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridExpirationDrugReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewExpirationDrugReport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnExpirationDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNameSizePackage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFirstname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
    }
}