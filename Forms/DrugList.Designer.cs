namespace Pharmacy.Forms
{
    partial class DrugList
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridType = new DevExpress.XtraGrid.GridControl();
            this.gridViewType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_RowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnShot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridDrug = new DevExpress.XtraGrid.GridControl();
            this.gridViewDrug = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1RowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDrugName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPackage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBaarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnInterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnVendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIsDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDrugTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridType);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(744, 522);
            this.splitContainerControl1.SplitterPosition = 228;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridType
            // 
            this.gridType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridType.Location = new System.Drawing.Point(0, 0);
            this.gridType.MainView = this.gridViewType;
            this.gridType.Name = "gridType";
            this.gridType.Size = new System.Drawing.Size(228, 522);
            this.gridType.TabIndex = 0;
            this.gridType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewType});
            this.gridType.DoubleClick += new System.EventHandler(this.gridType_DoubleClick);
            // 
            // gridViewType
            // 
            this.gridViewType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnTypeID,
            this.gridColumn_RowNum,
            this.gridColumnName,
            this.gridColumnShot});
            this.gridViewType.GridControl = this.gridType;
            this.gridViewType.Name = "gridViewType";
            this.gridViewType.OptionsView.ColumnAutoWidth = false;
            this.gridViewType.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnTypeID
            // 
            this.gridColumnTypeID.Caption = "TypeID";
            this.gridColumnTypeID.FieldName = "TypeID";
            this.gridColumnTypeID.Name = "gridColumnTypeID";
            // 
            // gridColumn_RowNum
            // 
            this.gridColumn_RowNum.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_RowNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_RowNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_RowNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_RowNum.Caption = "№";
            this.gridColumn_RowNum.FieldName = "RowNum";
            this.gridColumn_RowNum.Name = "gridColumn_RowNum";
            this.gridColumn_RowNum.OptionsColumn.AllowEdit = false;
            this.gridColumn_RowNum.OptionsColumn.AllowFocus = false;
            this.gridColumn_RowNum.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn_RowNum.OptionsFilter.AllowFilter = false;
            this.gridColumn_RowNum.Visible = true;
            this.gridColumn_RowNum.VisibleIndex = 0;
            this.gridColumn_RowNum.Width = 40;
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
            this.gridColumnName.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnName.OptionsFilter.AllowFilter = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 200;
            // 
            // gridColumnShot
            // 
            this.gridColumnShot.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnShot.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnShot.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnShot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnShot.Caption = "Товчлол";
            this.gridColumnShot.FieldName = "Shot";
            this.gridColumnShot.Name = "gridColumnShot";
            this.gridColumnShot.OptionsColumn.AllowEdit = false;
            this.gridColumnShot.OptionsColumn.AllowFocus = false;
            this.gridColumnShot.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnShot.OptionsFilter.AllowFilter = false;
            this.gridColumnShot.Visible = true;
            this.gridColumnShot.VisibleIndex = 2;
            this.gridColumnShot.Width = 60;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridDrug);
            this.layoutControl1.Controls.Add(this.btnPrintPreview);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(511, 522);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridDrug
            // 
            this.gridDrug.Location = new System.Drawing.Point(2, 2);
            this.gridDrug.MainView = this.gridViewDrug;
            this.gridDrug.Name = "gridDrug";
            this.gridDrug.Size = new System.Drawing.Size(507, 492);
            this.gridDrug.TabIndex = 0;
            this.gridDrug.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDrug});
            this.gridDrug.DoubleClick += new System.EventHandler(this.gridDrug_DoubleClick);
            this.gridDrug.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridDrug_KeyDown);
            // 
            // gridViewDrug
            // 
            this.gridViewDrug.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDrugID,
            this.gridColumn1RowNum,
            this.gridColumnDrugName,
            this.gridColumnSize,
            this.gridColumnUnitName,
            this.gridColumnPrice,
            this.gridColumnPackage,
            this.gridColumnTypeName,
            this.gridColumnBaarCode,
            this.gridColumnInterName,
            this.gridColumnVendor,
            this.gridColumnIsDiscount,
            this.gridColumnComment,
            this.gridColumnDrugTypeID,
            this.gridColumnUnitID});
            this.gridViewDrug.GridControl = this.gridDrug;
            this.gridViewDrug.Name = "gridViewDrug";
            this.gridViewDrug.OptionsView.ColumnAutoWidth = false;
            this.gridViewDrug.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDrug.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnDrugID
            // 
            this.gridColumnDrugID.Caption = "DrugID";
            this.gridColumnDrugID.FieldName = "DrugID";
            this.gridColumnDrugID.Name = "gridColumnDrugID";
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
            this.gridColumn1RowNum.Width = 40;
            // 
            // gridColumnDrugName
            // 
            this.gridColumnDrugName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDrugName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDrugName.Caption = "Нэр";
            this.gridColumnDrugName.FieldName = "Name";
            this.gridColumnDrugName.Name = "gridColumnDrugName";
            this.gridColumnDrugName.OptionsColumn.AllowEdit = false;
            this.gridColumnDrugName.OptionsColumn.AllowFocus = false;
            this.gridColumnDrugName.Visible = true;
            this.gridColumnDrugName.VisibleIndex = 1;
            this.gridColumnDrugName.Width = 180;
            // 
            // gridColumnSize
            // 
            this.gridColumnSize.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSize.Caption = "Тун";
            this.gridColumnSize.FieldName = "Size";
            this.gridColumnSize.Name = "gridColumnSize";
            this.gridColumnSize.OptionsColumn.AllowEdit = false;
            this.gridColumnSize.OptionsColumn.AllowFocus = false;
            this.gridColumnSize.Visible = true;
            this.gridColumnSize.VisibleIndex = 2;
            this.gridColumnSize.Width = 50;
            // 
            // gridColumnUnitName
            // 
            this.gridColumnUnitName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnUnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnUnitName.Caption = "Хэмжих нэгж";
            this.gridColumnUnitName.FieldName = "Unit";
            this.gridColumnUnitName.Name = "gridColumnUnitName";
            this.gridColumnUnitName.OptionsColumn.AllowEdit = false;
            this.gridColumnUnitName.OptionsColumn.AllowFocus = false;
            this.gridColumnUnitName.Visible = true;
            this.gridColumnUnitName.VisibleIndex = 3;
            this.gridColumnUnitName.Width = 80;
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
            this.gridColumnPrice.VisibleIndex = 4;
            this.gridColumnPrice.Width = 100;
            // 
            // gridColumnPackage
            // 
            this.gridColumnPackage.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPackage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPackage.Caption = "Савлалт";
            this.gridColumnPackage.FieldName = "Package";
            this.gridColumnPackage.Name = "gridColumnPackage";
            this.gridColumnPackage.OptionsColumn.AllowEdit = false;
            this.gridColumnPackage.OptionsColumn.AllowFocus = false;
            this.gridColumnPackage.Visible = true;
            this.gridColumnPackage.VisibleIndex = 5;
            this.gridColumnPackage.Width = 120;
            // 
            // gridColumnTypeName
            // 
            this.gridColumnTypeName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnTypeName.Caption = "Төрлийн нэр";
            this.gridColumnTypeName.FieldName = "Type";
            this.gridColumnTypeName.Name = "gridColumnTypeName";
            this.gridColumnTypeName.OptionsColumn.AllowEdit = false;
            this.gridColumnTypeName.OptionsColumn.AllowFocus = false;
            this.gridColumnTypeName.Visible = true;
            this.gridColumnTypeName.VisibleIndex = 6;
            this.gridColumnTypeName.Width = 130;
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
            this.gridColumnBaarCode.VisibleIndex = 7;
            this.gridColumnBaarCode.Width = 150;
            // 
            // gridColumnInterName
            // 
            this.gridColumnInterName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnInterName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnInterName.Caption = "ОУ нэршил";
            this.gridColumnInterName.FieldName = "InterName";
            this.gridColumnInterName.Name = "gridColumnInterName";
            this.gridColumnInterName.OptionsColumn.AllowEdit = false;
            this.gridColumnInterName.OptionsColumn.AllowFocus = false;
            this.gridColumnInterName.Visible = true;
            this.gridColumnInterName.VisibleIndex = 8;
            this.gridColumnInterName.Width = 200;
            // 
            // gridColumnVendor
            // 
            this.gridColumnVendor.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnVendor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnVendor.Caption = "Үйлдвэрлэгч";
            this.gridColumnVendor.FieldName = "Vendor";
            this.gridColumnVendor.Name = "gridColumnVendor";
            this.gridColumnVendor.OptionsColumn.AllowEdit = false;
            this.gridColumnVendor.OptionsColumn.AllowFocus = false;
            this.gridColumnVendor.Visible = true;
            this.gridColumnVendor.VisibleIndex = 9;
            this.gridColumnVendor.Width = 200;
            // 
            // gridColumnIsDiscount
            // 
            this.gridColumnIsDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnIsDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnIsDiscount.Caption = "Хөнгөлөлт";
            this.gridColumnIsDiscount.FieldName = "IsDiscount";
            this.gridColumnIsDiscount.Name = "gridColumnIsDiscount";
            this.gridColumnIsDiscount.OptionsColumn.AllowEdit = false;
            this.gridColumnIsDiscount.OptionsColumn.AllowFocus = false;
            this.gridColumnIsDiscount.Visible = true;
            this.gridColumnIsDiscount.VisibleIndex = 10;
            // 
            // gridColumnComment
            // 
            this.gridColumnComment.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnComment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnComment.Caption = "Тайлбар";
            this.gridColumnComment.FieldName = "Comment";
            this.gridColumnComment.Name = "gridColumnComment";
            this.gridColumnComment.OptionsColumn.AllowEdit = false;
            this.gridColumnComment.OptionsColumn.AllowFocus = false;
            this.gridColumnComment.Visible = true;
            this.gridColumnComment.VisibleIndex = 11;
            this.gridColumnComment.Width = 500;
            // 
            // gridColumnDrugTypeID
            // 
            this.gridColumnDrugTypeID.Caption = "TypeID";
            this.gridColumnDrugTypeID.FieldName = "TypeID";
            this.gridColumnDrugTypeID.Name = "gridColumnDrugTypeID";
            // 
            // gridColumnUnitID
            // 
            this.gridColumnUnitID.Caption = "UnitID";
            this.gridColumnUnitID.FieldName = "UnitID";
            this.gridColumnUnitID.Name = "gridColumnUnitID";
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(2, 498);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(507, 22);
            this.btnPrintPreview.StyleController = this.layoutControl1;
            this.btnPrintPreview.TabIndex = 4;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(511, 522);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridDrug;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(511, 496);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnPrintPreview;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 496);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(511, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // DrugList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 522);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "DrugList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эмийн мэдээлэл";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrugList_FormClosing);
            this.Load += new System.EventHandler(this.DrugList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrugList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnShot;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSize;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBaarCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnInterName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnVendor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPackage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUnitID;
        public DevExpress.XtraGrid.GridControl gridDrug;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewDrug;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_RowNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1RowNum;
    }
}