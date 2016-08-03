namespace Pharmacy.Forms
{
    partial class DiscountCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountCustomer));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtEMDNum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNDDNum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRegNum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridDiscountCustomer = new DevExpress.XtraGrid.GridControl();
            this.gridViewDiscountCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_RowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRegNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNDNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEMDNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMDNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNDDNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscountCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiscountCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.txtAddress);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txtPhone);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txtEMDNum);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtNDDNum);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtRegNum);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtFirstName);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtLastName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(584, 133);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(403, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Бүртгэх";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(363, 68);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(330, 71);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Хаяг:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(363, 42);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Mask.EditMask = "d";
            this.txtPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPhone.Properties.MaxLength = 8;
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(329, 45);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Утас:";
            // 
            // txtEMDNum
            // 
            this.txtEMDNum.Location = new System.Drawing.Point(363, 16);
            this.txtEMDNum.Name = "txtEMDNum";
            this.txtEMDNum.Size = new System.Drawing.Size(200, 20);
            this.txtEMDNum.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(314, 19);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "ЭМД №:";
            // 
            // txtNDDNum
            // 
            this.txtNDDNum.Location = new System.Drawing.Point(83, 94);
            this.txtNDDNum.Name = "txtNDDNum";
            this.txtNDDNum.Size = new System.Drawing.Size(200, 20);
            this.txtNDDNum.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(34, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "НДД №:";
            // 
            // txtRegNum
            // 
            this.txtRegNum.Location = new System.Drawing.Point(83, 68);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.Size = new System.Drawing.Size(200, 20);
            this.txtRegNum.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Регистр:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(83, 42);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(56, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Нэр:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(83, 16);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(49, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Овог:";
            // 
            // gridDiscountCustomer
            // 
            this.gridDiscountCustomer.Location = new System.Drawing.Point(5, 144);
            this.gridDiscountCustomer.MainView = this.gridViewDiscountCustomer;
            this.gridDiscountCustomer.Name = "gridDiscountCustomer";
            this.gridDiscountCustomer.Size = new System.Drawing.Size(584, 243);
            this.gridDiscountCustomer.TabIndex = 1;
            this.gridDiscountCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDiscountCustomer});
            this.gridDiscountCustomer.DoubleClick += new System.EventHandler(this.gridDiscountCustomer_DoubleClick);
            this.gridDiscountCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridDiscountCustomer_KeyDown);
            // 
            // gridViewDiscountCustomer
            // 
            this.gridViewDiscountCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_RowNum,
            this.gridColumnCustomerID,
            this.gridColumnLastName,
            this.gridColumnFirstName,
            this.gridColumnRegNum,
            this.gridColumnNDNum,
            this.gridColumnEMDNum,
            this.gridColumnPhone,
            this.gridColumnAddress});
            this.gridViewDiscountCustomer.GridControl = this.gridDiscountCustomer;
            this.gridViewDiscountCustomer.Name = "gridViewDiscountCustomer";
            this.gridViewDiscountCustomer.OptionsView.ColumnAutoWidth = false;
            this.gridViewDiscountCustomer.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDiscountCustomer.OptionsView.ShowGroupPanel = false;
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
            this.gridColumn_RowNum.Visible = true;
            this.gridColumn_RowNum.VisibleIndex = 0;
            this.gridColumn_RowNum.Width = 40;
            // 
            // gridColumnCustomerID
            // 
            this.gridColumnCustomerID.Caption = "CustomerID";
            this.gridColumnCustomerID.FieldName = "CustomerID";
            this.gridColumnCustomerID.Name = "gridColumnCustomerID";
            // 
            // gridColumnLastName
            // 
            this.gridColumnLastName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnLastName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnLastName.Caption = "Овог";
            this.gridColumnLastName.FieldName = "LastName";
            this.gridColumnLastName.Name = "gridColumnLastName";
            this.gridColumnLastName.OptionsColumn.AllowEdit = false;
            this.gridColumnLastName.OptionsColumn.AllowFocus = false;
            this.gridColumnLastName.Visible = true;
            this.gridColumnLastName.VisibleIndex = 1;
            this.gridColumnLastName.Width = 150;
            // 
            // gridColumnFirstName
            // 
            this.gridColumnFirstName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnFirstName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnFirstName.Caption = "Нэр";
            this.gridColumnFirstName.FieldName = "FirstName";
            this.gridColumnFirstName.Name = "gridColumnFirstName";
            this.gridColumnFirstName.OptionsColumn.AllowEdit = false;
            this.gridColumnFirstName.OptionsColumn.AllowFocus = false;
            this.gridColumnFirstName.Visible = true;
            this.gridColumnFirstName.VisibleIndex = 2;
            this.gridColumnFirstName.Width = 150;
            // 
            // gridColumnRegNum
            // 
            this.gridColumnRegNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnRegNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnRegNum.Caption = "Регистр";
            this.gridColumnRegNum.FieldName = "RegNum";
            this.gridColumnRegNum.Name = "gridColumnRegNum";
            this.gridColumnRegNum.OptionsColumn.AllowEdit = false;
            this.gridColumnRegNum.OptionsColumn.AllowFocus = false;
            this.gridColumnRegNum.Visible = true;
            this.gridColumnRegNum.VisibleIndex = 3;
            this.gridColumnRegNum.Width = 90;
            // 
            // gridColumnNDNum
            // 
            this.gridColumnNDNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNDNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNDNum.Caption = "НДД №";
            this.gridColumnNDNum.FieldName = "NDNum";
            this.gridColumnNDNum.Name = "gridColumnNDNum";
            this.gridColumnNDNum.OptionsColumn.AllowEdit = false;
            this.gridColumnNDNum.OptionsColumn.AllowFocus = false;
            this.gridColumnNDNum.Visible = true;
            this.gridColumnNDNum.VisibleIndex = 4;
            this.gridColumnNDNum.Width = 90;
            // 
            // gridColumnEMDNum
            // 
            this.gridColumnEMDNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnEMDNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnEMDNum.Caption = "ЭМД №";
            this.gridColumnEMDNum.FieldName = "EMDNum";
            this.gridColumnEMDNum.Name = "gridColumnEMDNum";
            this.gridColumnEMDNum.OptionsColumn.AllowEdit = false;
            this.gridColumnEMDNum.OptionsColumn.AllowFocus = false;
            this.gridColumnEMDNum.Visible = true;
            this.gridColumnEMDNum.VisibleIndex = 5;
            this.gridColumnEMDNum.Width = 90;
            // 
            // gridColumnPhone
            // 
            this.gridColumnPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPhone.Caption = "Утас";
            this.gridColumnPhone.FieldName = "Phone";
            this.gridColumnPhone.Name = "gridColumnPhone";
            this.gridColumnPhone.OptionsColumn.AllowEdit = false;
            this.gridColumnPhone.OptionsColumn.AllowFocus = false;
            this.gridColumnPhone.Visible = true;
            this.gridColumnPhone.VisibleIndex = 6;
            this.gridColumnPhone.Width = 90;
            // 
            // gridColumnAddress
            // 
            this.gridColumnAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnAddress.Caption = "Хаяг";
            this.gridColumnAddress.FieldName = "Address";
            this.gridColumnAddress.Name = "gridColumnAddress";
            this.gridColumnAddress.OptionsColumn.AllowEdit = false;
            this.gridColumnAddress.OptionsColumn.AllowFocus = false;
            this.gridColumnAddress.Visible = true;
            this.gridColumnAddress.VisibleIndex = 7;
            this.gridColumnAddress.Width = 500;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(514, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Хаах";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(5, 393);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(120, 23);
            this.btnPrintPreview.TabIndex = 8;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // DiscountCustomer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(594, 422);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridDiscountCustomer);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscountCustomer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Даатгуулагч";
            this.Load += new System.EventHandler(this.DiscountCustomer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiscountCustomer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMDNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNDDNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscountCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiscountCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtEMDNum;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtNDDNum;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridDiscountCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDiscountCustomer;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLastName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRegNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNDNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEMDNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAddress;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        public DevExpress.XtraEditors.TextEdit txtRegNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_RowNum;
    }
}