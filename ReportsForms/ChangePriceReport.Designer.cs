namespace Pharmacy.ReportsForms
{
    partial class ChangePriceReport
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
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridChangePrice = new DevExpress.XtraGrid.GridControl();
            this.gridViewChangePrice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnChangePriceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNameSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnOldPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNewPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnZoruuTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChangePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChangePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.btnView);
            this.layoutControl1.Controls.Add(this.dateEnd);
            this.layoutControl1.Controls.Add(this.labelControl2);
            this.layoutControl1.Controls.Add(this.dateStart);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.gridChangePrice);
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
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Хэвлэх";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(429, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(116, 22);
            this.btnView.StyleController = this.layoutControl1;
            this.btnView.TabIndex = 9;
            this.btnView.Text = "Харах";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            // gridChangePrice
            // 
            this.gridChangePrice.Location = new System.Drawing.Point(2, 28);
            this.gridChangePrice.MainView = this.gridViewChangePrice;
            this.gridChangePrice.Name = "gridChangePrice";
            this.gridChangePrice.Size = new System.Drawing.Size(790, 516);
            this.gridChangePrice.TabIndex = 4;
            this.gridChangePrice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChangePrice});
            // 
            // gridViewChangePrice
            // 
            this.gridViewChangePrice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnChangePriceID,
            this.gridColumnRowNum,
            this.gridColumnNameSize,
            this.gridColumnCount,
            this.gridColumnOldPrice,
            this.gridColumnNewPrice,
            this.gridColumnUOA,
            this.gridColumnZoruuTotal,
            this.gridColumnActionDate,
            this.gridColumnDrugID,
            this.gridColumnUserID});
            this.gridViewChangePrice.GridControl = this.gridChangePrice;
            this.gridViewChangePrice.GroupPanelText = "Үнэ өөрчөлтийн тайлан";
            this.gridViewChangePrice.Name = "gridViewChangePrice";
            this.gridViewChangePrice.OptionsView.ShowFooter = true;
            // 
            // gridColumnChangePriceID
            // 
            this.gridColumnChangePriceID.Caption = "ChangePriceID";
            this.gridColumnChangePriceID.FieldName = "ChangePriceID";
            this.gridColumnChangePriceID.Name = "gridColumnChangePriceID";
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
            this.gridColumnRowNum.Width = 31;
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
            this.gridColumnNameSize.Width = 242;
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
            this.gridColumnCount.Width = 104;
            // 
            // gridColumnOldPrice
            // 
            this.gridColumnOldPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnOldPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnOldPrice.Caption = "Хуучин үнэ";
            this.gridColumnOldPrice.DisplayFormat.FormatString = "n";
            this.gridColumnOldPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnOldPrice.FieldName = "OldPrice";
            this.gridColumnOldPrice.Name = "gridColumnOldPrice";
            this.gridColumnOldPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnOldPrice.OptionsColumn.AllowFocus = false;
            this.gridColumnOldPrice.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnOldPrice.OptionsFilter.AllowFilter = false;
            this.gridColumnOldPrice.Visible = true;
            this.gridColumnOldPrice.VisibleIndex = 3;
            this.gridColumnOldPrice.Width = 103;
            // 
            // gridColumnNewPrice
            // 
            this.gridColumnNewPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNewPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNewPrice.Caption = "Шинэ үнэ";
            this.gridColumnNewPrice.DisplayFormat.FormatString = "n";
            this.gridColumnNewPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnNewPrice.FieldName = "NewPrice";
            this.gridColumnNewPrice.Name = "gridColumnNewPrice";
            this.gridColumnNewPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnNewPrice.OptionsColumn.AllowFocus = false;
            this.gridColumnNewPrice.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnNewPrice.OptionsFilter.AllowFilter = false;
            this.gridColumnNewPrice.Visible = true;
            this.gridColumnNewPrice.VisibleIndex = 4;
            this.gridColumnNewPrice.Width = 101;
            // 
            // gridColumnUOA
            // 
            this.gridColumnUOA.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnUOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnUOA.Caption = "ҮӨА";
            this.gridColumnUOA.DisplayFormat.FormatString = "n";
            this.gridColumnUOA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnUOA.FieldName = "UOA";
            this.gridColumnUOA.Name = "gridColumnUOA";
            this.gridColumnUOA.OptionsColumn.AllowEdit = false;
            this.gridColumnUOA.OptionsColumn.AllowFocus = false;
            this.gridColumnUOA.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnUOA.OptionsFilter.AllowFilter = false;
            this.gridColumnUOA.UnboundExpression = "[NewPrice]-[OldPrice]";
            this.gridColumnUOA.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumnUOA.Visible = true;
            this.gridColumnUOA.VisibleIndex = 5;
            this.gridColumnUOA.Width = 92;
            // 
            // gridColumnZoruuTotal
            // 
            this.gridColumnZoruuTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnZoruuTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnZoruuTotal.Caption = "Зөрүү дүн";
            this.gridColumnZoruuTotal.DisplayFormat.FormatString = "n";
            this.gridColumnZoruuTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnZoruuTotal.FieldName = "ZoruuTotal";
            this.gridColumnZoruuTotal.Name = "gridColumnZoruuTotal";
            this.gridColumnZoruuTotal.OptionsColumn.AllowEdit = false;
            this.gridColumnZoruuTotal.OptionsColumn.AllowFocus = false;
            this.gridColumnZoruuTotal.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnZoruuTotal.OptionsFilter.AllowFilter = false;
            this.gridColumnZoruuTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ZoruuTotal", "₮{0:###,###,###,###.##}")});
            this.gridColumnZoruuTotal.UnboundExpression = "[Count] * [UOA]";
            this.gridColumnZoruuTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnZoruuTotal.Visible = true;
            this.gridColumnZoruuTotal.VisibleIndex = 6;
            this.gridColumnZoruuTotal.Width = 99;
            // 
            // gridColumnActionDate
            // 
            this.gridColumnActionDate.Caption = "ActionDate";
            this.gridColumnActionDate.FieldName = "ActionDate";
            this.gridColumnActionDate.Name = "gridColumnActionDate";
            // 
            // gridColumnDrugID
            // 
            this.gridColumnDrugID.Caption = "DrugID";
            this.gridColumnDrugID.FieldName = "DrugID";
            this.gridColumnDrugID.Name = "gridColumnDrugID";
            // 
            // gridColumnUserID
            // 
            this.gridColumnUserID.Caption = "UserID";
            this.gridColumnUserID.FieldName = "UserID";
            this.gridColumnUserID.Name = "gridColumnUserID";
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
            this.layoutControlItem6,
            this.emptySpaceItem1,
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
            this.layoutControlItem1.Control = this.gridChangePrice;
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
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dateEnd;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(284, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 3, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(140, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnView;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(424, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.layoutControlItem6.Size = new System.Drawing.Size(126, 26);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(550, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(244, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
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
            // ChangePriceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "ChangePriceReport";
            this.Text = "Үнэ өөрчлөлтийн тайлан";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePriceReport_FormClosing);
            this.Load += new System.EventHandler(this.ChangePriceReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangePriceReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChangePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChangePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridChangePrice;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChangePrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnChangePriceID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnOldPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNewPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNameSize;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserID;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUOA;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnZoruuTotal;
    }
}