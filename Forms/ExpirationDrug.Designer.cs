namespace Pharmacy.Forms
{
    partial class ExpirationDrug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpirationDrug));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtCount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookDrugID = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridExpirationDrug = new DevExpress.XtraGrid.GridControl();
            this.gridViewExpirationDrug = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateSearchOgnoo = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookDrugID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExpirationDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExpirationDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchOgnoo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchOgnoo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtPrice);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.txtCount);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lookDrugID);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(733, 43);
            this.panelControl1.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(332, 13);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrice.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtPrice.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtPrice.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtPrice.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPrice.Properties.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(107, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(305, 16);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(21, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Үнэ:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(598, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Бүртгэх";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(489, 13);
            this.txtCount.Name = "txtCount";
            this.txtCount.Properties.DisplayFormat.FormatString = "n";
            this.txtCount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCount.Properties.EditFormat.FormatString = "n";
            this.txtCount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCount.Properties.Mask.EditMask = "n";
            this.txtCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCount.Size = new System.Drawing.Size(94, 20);
            this.txtCount.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(461, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Тоо:";
            // 
            // lookDrugID
            // 
            this.lookDrugID.Location = new System.Drawing.Point(83, 13);
            this.lookDrugID.Name = "lookDrugID";
            this.lookDrugID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookDrugID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RowNum", 40, "№"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DrugID", "DrugID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameSizePackage", 200, "Эмийн нэр"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", 50, "Үнэ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("InterName", 55, "ОУ нэршил"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendor", 55, "Үйлдвэрлэгч")});
            this.lookDrugID.Properties.NullText = "";
            this.lookDrugID.Properties.PopupFormMinSize = new System.Drawing.Size(400, 200);
            this.lookDrugID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookDrugID.Size = new System.Drawing.Size(194, 20);
            this.lookDrugID.TabIndex = 1;
            this.lookDrugID.EditValueChanged += new System.EventHandler(this.lookDrugID_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Эм сонгох:";
            // 
            // gridExpirationDrug
            // 
            this.gridExpirationDrug.Location = new System.Drawing.Point(5, 73);
            this.gridExpirationDrug.MainView = this.gridViewExpirationDrug;
            this.gridExpirationDrug.Name = "gridExpirationDrug";
            this.gridExpirationDrug.Size = new System.Drawing.Size(733, 414);
            this.gridExpirationDrug.TabIndex = 1;
            this.gridExpirationDrug.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewExpirationDrug});
            this.gridExpirationDrug.DoubleClick += new System.EventHandler(this.gridExpirationDrug_DoubleClick);
            this.gridExpirationDrug.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridExpirationDrug_KeyDown);
            // 
            // gridViewExpirationDrug
            // 
            this.gridViewExpirationDrug.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridViewExpirationDrug.GridControl = this.gridExpirationDrug;
            this.gridViewExpirationDrug.GroupPanelText = "Хугацаа дууссан эмийн бүртгэлийн жагсаалт";
            this.gridViewExpirationDrug.Name = "gridViewExpirationDrug";
            this.gridViewExpirationDrug.OptionsView.ShowAutoFilterRow = true;
            this.gridViewExpirationDrug.OptionsView.ShowFooter = true;
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
            this.gridColumnCount.Width = 58;
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
            this.gridColumnSumPrice.Visible = true;
            this.gridColumnSumPrice.VisibleIndex = 4;
            this.gridColumnSumPrice.Width = 77;
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
            this.gridColumnActionDate.Width = 89;
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
            this.gridColumnNameSizePackage.Width = 266;
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
            this.gridColumnFirstname.Width = 123;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(5, 493);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(733, 23);
            this.btnPrintPreview.TabIndex = 2;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Хайлт хийх огноо:";
            // 
            // dateSearchOgnoo
            // 
            this.dateSearchOgnoo.EditValue = null;
            this.dateSearchOgnoo.Location = new System.Drawing.Point(129, 51);
            this.dateSearchOgnoo.Name = "dateSearchOgnoo";
            this.dateSearchOgnoo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSearchOgnoo.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateSearchOgnoo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSearchOgnoo.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateSearchOgnoo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateSearchOgnoo.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateSearchOgnoo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateSearchOgnoo.Size = new System.Drawing.Size(133, 20);
            this.dateSearchOgnoo.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(270, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 19);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Хайх";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ExpirationDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 522);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateSearchOgnoo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.gridExpirationDrug);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpirationDrug";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хугацаа дууссан эмийн бүртгэл";
            this.Load += new System.EventHandler(this.ExpirationDrug_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExpirationDrug_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookDrugID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExpirationDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExpirationDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchOgnoo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSearchOgnoo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtCount;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookDrugID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridExpirationDrug;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewExpirationDrug;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateSearchOgnoo;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnExpirationDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDrugID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNameSizePackage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFirstname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSumPrice;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
    }
}