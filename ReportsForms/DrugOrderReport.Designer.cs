namespace Pharmacy.ReportsForms
{
    partial class DrugOrderReport
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
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.dateOgnoo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridDrugOrderReport = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.barDeleteDrug = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewDrugOrderReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDrugOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPackage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFirstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateOgnoo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOgnoo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrugOrderReport)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrugOrderReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.btnView);
            this.layoutControl1.Controls.Add(this.dateOgnoo);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.gridDrugOrderReport);
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
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Захиалга хэвлэх";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(177, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(104, 22);
            this.btnView.StyleController = this.layoutControl1;
            this.btnView.TabIndex = 7;
            this.btnView.Text = "Хайх";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dateOgnoo
            // 
            this.dateOgnoo.EditValue = null;
            this.dateOgnoo.Location = new System.Drawing.Point(44, 3);
            this.dateOgnoo.Name = "dateOgnoo";
            this.dateOgnoo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOgnoo.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateOgnoo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOgnoo.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateOgnoo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateOgnoo.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateOgnoo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateOgnoo.Size = new System.Drawing.Size(129, 20);
            this.dateOgnoo.StyleController = this.layoutControl1;
            this.dateOgnoo.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Огноо:";
            // 
            // gridDrugOrderReport
            // 
            this.gridDrugOrderReport.ContextMenuStrip = this.contextMenuStrip1;
            this.gridDrugOrderReport.Location = new System.Drawing.Point(2, 28);
            this.gridDrugOrderReport.MainView = this.gridViewDrugOrderReport;
            this.gridDrugOrderReport.Name = "gridDrugOrderReport";
            this.gridDrugOrderReport.Size = new System.Drawing.Size(790, 516);
            this.gridDrugOrderReport.TabIndex = 4;
            this.gridDrugOrderReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDrugOrderReport});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barDeleteDrug});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 26);
            // 
            // barDeleteDrug
            // 
            this.barDeleteDrug.Name = "barDeleteDrug";
            this.barDeleteDrug.Size = new System.Drawing.Size(171, 22);
            this.barDeleteDrug.Text = "Захиалгаас &устгах";
            this.barDeleteDrug.Click += new System.EventHandler(this.barDeleteDrug_Click);
            // 
            // gridViewDrugOrderReport
            // 
            this.gridViewDrugOrderReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDrugOrderID,
            this.gridColumnDrugID,
            this.gridColumnActionDate,
            this.gridColumnUserID,
            this.gridColumnRowNum,
            this.gridColumnName,
            this.gridColumnSize,
            this.gridColumnPackage,
            this.gridColumnPrice,
            this.gridColumnFirstname});
            this.gridViewDrugOrderReport.GridControl = this.gridDrugOrderReport;
            this.gridViewDrugOrderReport.GroupPanelText = "Эмийн захиалгын тайлан";
            this.gridViewDrugOrderReport.Name = "gridViewDrugOrderReport";
            // 
            // gridColumnDrugOrderID
            // 
            this.gridColumnDrugOrderID.Caption = "DrugOrderID";
            this.gridColumnDrugOrderID.FieldName = "DrugOrderID";
            this.gridColumnDrugOrderID.Name = "gridColumnDrugOrderID";
            // 
            // gridColumnDrugID
            // 
            this.gridColumnDrugID.Caption = "DrugID";
            this.gridColumnDrugID.FieldName = "DrugID";
            this.gridColumnDrugID.Name = "gridColumnDrugID";
            // 
            // gridColumnActionDate
            // 
            this.gridColumnActionDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnActionDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnActionDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnActionDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnActionDate.Caption = "Захиалсан огноо";
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
            this.gridColumnActionDate.Width = 107;
            // 
            // gridColumnUserID
            // 
            this.gridColumnUserID.Caption = "UserID";
            this.gridColumnUserID.FieldName = "UserID";
            this.gridColumnUserID.Name = "gridColumnUserID";
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
            // gridColumnName
            // 
            this.gridColumnName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnName.Caption = "Эмийн нэр";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.AllowFocus = false;
            this.gridColumnName.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnName.OptionsFilter.AllowFilter = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 257;
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
            this.gridColumnSize.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnSize.OptionsFilter.AllowFilter = false;
            this.gridColumnSize.Visible = true;
            this.gridColumnSize.VisibleIndex = 2;
            this.gridColumnSize.Width = 64;
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
            this.gridColumnPackage.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnPackage.OptionsFilter.AllowFilter = false;
            this.gridColumnPackage.Visible = true;
            this.gridColumnPackage.VisibleIndex = 3;
            this.gridColumnPackage.Width = 67;
            // 
            // gridColumnPrice
            // 
            this.gridColumnPrice.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.gridColumnPrice.VisibleIndex = 4;
            this.gridColumnPrice.Width = 83;
            // 
            // gridColumnFirstname
            // 
            this.gridColumnFirstname.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnFirstname.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnFirstname.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnFirstname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnFirstname.Caption = "Захиалсан ажилтан";
            this.gridColumnFirstname.FieldName = "Firstname";
            this.gridColumnFirstname.Name = "gridColumnFirstname";
            this.gridColumnFirstname.OptionsColumn.AllowEdit = false;
            this.gridColumnFirstname.OptionsColumn.AllowFocus = false;
            this.gridColumnFirstname.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnFirstname.OptionsFilter.AllowFilter = false;
            this.gridColumnFirstname.Visible = true;
            this.gridColumnFirstname.VisibleIndex = 6;
            this.gridColumnFirstname.Width = 159;
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
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(794, 572);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridDrugOrderReport;
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
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 2, 5, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(42, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateOgnoo;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(42, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 3, 2);
            this.layoutControlItem3.Size = new System.Drawing.Size(133, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnView;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(175, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(108, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(283, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(511, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnPrint;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 546);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(794, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // DrugOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "DrugOrderReport";
            this.Text = "Эмийн захиалгын тайлан";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrugOrderReport_FormClosing);
            this.Load += new System.EventHandler(this.DrugOrderReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrugOrderReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateOgnoo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOgnoo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrugOrderReport)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrugOrderReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridDrugOrderReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDrugOrderReport;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.DateEdit dateOgnoo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSize;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPackage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFirstname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem barDeleteDrug;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
    }
}