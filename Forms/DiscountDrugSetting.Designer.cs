namespace Pharmacy.Forms
{
    partial class DiscountDrugSetting
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
            this.btnDiscountDrugAdd = new DevExpress.XtraEditors.SimpleButton();
            this.lblDiscountDrugInfo = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridNoDiscount = new DevExpress.XtraGrid.GridControl();
            this.gridViewNoDiscount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.gridDiscount = new DevExpress.XtraGrid.GridControl();
            this.gridViewDiscount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDisDrugID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDrugIDDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNameDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPriceDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lookDiscountDrug = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNoDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookDiscountDrug.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDiscountDrugAdd);
            this.layoutControl1.Controls.Add(this.lblDiscountDrugInfo);
            this.layoutControl1.Controls.Add(this.splitContainerControl1);
            this.layoutControl1.Controls.Add(this.lookDiscountDrug);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(744, 522);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDiscountDrugAdd
            // 
            this.btnDiscountDrugAdd.Location = new System.Drawing.Point(286, 2);
            this.btnDiscountDrugAdd.Name = "btnDiscountDrugAdd";
            this.btnDiscountDrugAdd.Size = new System.Drawing.Size(23, 22);
            this.btnDiscountDrugAdd.StyleController = this.layoutControl1;
            this.btnDiscountDrugAdd.TabIndex = 6;
            this.btnDiscountDrugAdd.Text = "F1";
            this.btnDiscountDrugAdd.ToolTip = "Хөнгөлөлттэй эм бүртгэх";
            this.btnDiscountDrugAdd.Click += new System.EventHandler(this.btnDiscountDrugAdd_Click);
            // 
            // lblDiscountDrugInfo
            // 
            this.lblDiscountDrugInfo.Location = new System.Drawing.Point(313, 6);
            this.lblDiscountDrugInfo.Name = "lblDiscountDrugInfo";
            this.lblDiscountDrugInfo.Size = new System.Drawing.Size(83, 13);
            this.lblDiscountDrugInfo.StyleController = this.layoutControl1;
            this.lblDiscountDrugInfo.TabIndex = 3;
            this.lblDiscountDrugInfo.Text = "Эмийн мэдээлэл:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 28);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(740, 492);
            this.splitContainerControl1.SplitterPosition = 368;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.btnAdd);
            this.layoutControl2.Controls.Add(this.gridNoDiscount);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(368, 492);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(2, 468);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(364, 22);
            this.btnAdd.StyleController = this.layoutControl2;
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Оруулах  >>";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridNoDiscount
            // 
            this.gridNoDiscount.Location = new System.Drawing.Point(2, 2);
            this.gridNoDiscount.MainView = this.gridViewNoDiscount;
            this.gridNoDiscount.Name = "gridNoDiscount";
            this.gridNoDiscount.Size = new System.Drawing.Size(364, 462);
            this.gridNoDiscount.TabIndex = 4;
            this.gridNoDiscount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNoDiscount});
            // 
            // gridViewNoDiscount
            // 
            this.gridViewNoDiscount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDrugID,
            this.gridColumnRowNum,
            this.gridColumnName,
            this.gridColumnPrice});
            this.gridViewNoDiscount.GridControl = this.gridNoDiscount;
            this.gridViewNoDiscount.GroupPanelText = "Хөнгөлөлттэй эмтэй холбоогүй эм";
            this.gridViewNoDiscount.Name = "gridViewNoDiscount";
            this.gridViewNoDiscount.OptionsView.ShowAutoFilterRow = true;
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
            // gridColumnName
            // 
            this.gridColumnName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnName.Caption = "Эмийн нэр";
            this.gridColumnName.FieldName = "NameSizePackage";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.AllowFocus = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 223;
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
            this.gridColumnPrice.VisibleIndex = 2;
            this.gridColumnPrice.Width = 88;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(368, 492);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridNoDiscount;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(368, 466);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnAdd;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 466);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(368, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.btnDelete);
            this.layoutControl3.Controls.Add(this.gridDiscount);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup3;
            this.layoutControl3.Size = new System.Drawing.Size(367, 492);
            this.layoutControl3.TabIndex = 0;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(2, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(363, 22);
            this.btnDelete.StyleController = this.layoutControl3;
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "<<  Буцаах";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridDiscount
            // 
            this.gridDiscount.Location = new System.Drawing.Point(2, 2);
            this.gridDiscount.MainView = this.gridViewDiscount;
            this.gridDiscount.Name = "gridDiscount";
            this.gridDiscount.Size = new System.Drawing.Size(363, 462);
            this.gridDiscount.TabIndex = 4;
            this.gridDiscount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDiscount});
            // 
            // gridViewDiscount
            // 
            this.gridViewDiscount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDisDrugID,
            this.gridColumnDrugIDDiscount,
            this.gridColumnNameDiscount,
            this.gridColumnPriceDiscount,
            this.gridColumnRowNum1});
            this.gridViewDiscount.GridControl = this.gridDiscount;
            this.gridViewDiscount.GroupPanelText = "Хөнгөлөлттэй эмтэй холбогдсон эм";
            this.gridViewDiscount.Name = "gridViewDiscount";
            this.gridViewDiscount.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumnDisDrugID
            // 
            this.gridColumnDisDrugID.Caption = "DisDrugID";
            this.gridColumnDisDrugID.FieldName = "DisDrugID";
            this.gridColumnDisDrugID.Name = "gridColumnDisDrugID";
            // 
            // gridColumnDrugIDDiscount
            // 
            this.gridColumnDrugIDDiscount.Caption = "DrugID";
            this.gridColumnDrugIDDiscount.FieldName = "DrugID";
            this.gridColumnDrugIDDiscount.Name = "gridColumnDrugIDDiscount";
            // 
            // gridColumnNameDiscount
            // 
            this.gridColumnNameDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNameDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNameDiscount.Caption = "Эмийн нэр";
            this.gridColumnNameDiscount.FieldName = "NameSizePackage";
            this.gridColumnNameDiscount.Name = "gridColumnNameDiscount";
            this.gridColumnNameDiscount.OptionsColumn.AllowEdit = false;
            this.gridColumnNameDiscount.OptionsColumn.AllowFocus = false;
            this.gridColumnNameDiscount.Visible = true;
            this.gridColumnNameDiscount.VisibleIndex = 1;
            this.gridColumnNameDiscount.Width = 238;
            // 
            // gridColumnPriceDiscount
            // 
            this.gridColumnPriceDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPriceDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPriceDiscount.Caption = "Үнэ";
            this.gridColumnPriceDiscount.DisplayFormat.FormatString = "n";
            this.gridColumnPriceDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPriceDiscount.FieldName = "Price";
            this.gridColumnPriceDiscount.Name = "gridColumnPriceDiscount";
            this.gridColumnPriceDiscount.OptionsColumn.AllowEdit = false;
            this.gridColumnPriceDiscount.OptionsColumn.AllowFocus = false;
            this.gridColumnPriceDiscount.Visible = true;
            this.gridColumnPriceDiscount.VisibleIndex = 2;
            this.gridColumnPriceDiscount.Width = 72;
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
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup3.Size = new System.Drawing.Size(367, 492);
            this.layoutControlGroup3.Text = "layoutControlGroup3";
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridDiscount;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(367, 466);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnDelete;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 466);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(367, 26);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // lookDiscountDrug
            // 
            this.lookDiscountDrug.Location = new System.Drawing.Point(94, 2);
            this.lookDiscountDrug.Name = "lookDiscountDrug";
            this.lookDiscountDrug.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookDiscountDrug.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DiscountDrugID", "DiscountDrugID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FileNum", 10, "Файл №"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 50, "Нэр"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Үнэ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Package", 10, "Савлалт"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaxSize", 10, "Дээд хязгаар")});
            this.lookDiscountDrug.Properties.NullText = "";
            this.lookDiscountDrug.Properties.PopupFormMinSize = new System.Drawing.Size(600, 300);
            this.lookDiscountDrug.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookDiscountDrug.Size = new System.Drawing.Size(188, 20);
            this.lookDiscountDrug.StyleController = this.layoutControl1;
            this.lookDiscountDrug.TabIndex = 1;
            this.lookDiscountDrug.EditValueChanged += new System.EventHandler(this.lookDiscountDrug_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(744, 522);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.splitContainerControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(744, 496);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.lookDiscountDrug;
            this.layoutControlItem7.CustomizationFormText = "Хөнгөлөлттэй эм:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(284, 26);
            this.layoutControlItem7.Text = "Хөнгөлөлттэй эм:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.lblDiscountDrugInfo;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(311, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 6, 2);
            this.layoutControlItem8.Size = new System.Drawing.Size(87, 26);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(398, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(346, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnDiscountDrugAdd;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(284, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(27, 26);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // DiscountDrugSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 522);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "DiscountDrugSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хөнгөлөлттэй эмийн тохиргоо";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiscountDrugSetting_FormClosing);
            this.Load += new System.EventHandler(this.DiscountDrugSetting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiscountDrugSetting_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNoDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNoDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookDiscountDrug.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit lookDiscountDrug;
        private DevExpress.XtraEditors.LabelControl lblDiscountDrugInfo;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl gridNoDiscount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNoDiscount;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.GridControl gridDiscount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDiscount;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDisDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugIDDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNameDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPriceDiscount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnDiscountDrugAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum1;
    }
}