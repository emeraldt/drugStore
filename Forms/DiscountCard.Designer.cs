namespace Pharmacy.Forms
{
    partial class DiscountCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountCard));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscountProcent = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCardnum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRegnum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLastname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridDiscountCard = new DevExpress.XtraGrid.GridControl();
            this.gridViewDiscountCard = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_RowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCardID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRegNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCardNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountProcent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardnum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegnum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscountCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiscountCard)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.txtAddress);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txtDiscountProcent);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txtCardnum);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtPhone);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtRegnum);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtFirstname);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtLastname);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(584, 130);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(395, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Бүртгэх";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(373, 69);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(167, 20);
            this.txtAddress.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(340, 72);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Хаяг:";
            // 
            // txtDiscountProcent
            // 
            this.txtDiscountProcent.Location = new System.Drawing.Point(373, 43);
            this.txtDiscountProcent.Name = "txtDiscountProcent";
            this.txtDiscountProcent.Properties.Mask.EditMask = "d";
            this.txtDiscountProcent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscountProcent.Size = new System.Drawing.Size(167, 20);
            this.txtDiscountProcent.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(265, 46);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(102, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Хөнгөлөлтийн хувь:";
            // 
            // txtCardnum
            // 
            this.txtCardnum.Location = new System.Drawing.Point(373, 17);
            this.txtCardnum.Name = "txtCardnum";
            this.txtCardnum.Size = new System.Drawing.Size(167, 20);
            this.txtCardnum.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(285, 20);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(82, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Картын дугаар:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(78, 95);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Mask.EditMask = "d";
            this.txtPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPhone.Size = new System.Drawing.Size(167, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(44, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Утас:";
            // 
            // txtRegnum
            // 
            this.txtRegnum.Location = new System.Drawing.Point(78, 69);
            this.txtRegnum.Name = "txtRegnum";
            this.txtRegnum.Size = new System.Drawing.Size(167, 20);
            this.txtRegnum.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Регистр:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(78, 43);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(167, 20);
            this.txtFirstname.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(50, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Нэр:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(78, 17);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(167, 20);
            this.txtLastname.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Овог:";
            // 
            // gridDiscountCard
            // 
            this.gridDiscountCard.Location = new System.Drawing.Point(5, 141);
            this.gridDiscountCard.MainView = this.gridViewDiscountCard;
            this.gridDiscountCard.Name = "gridDiscountCard";
            this.gridDiscountCard.Size = new System.Drawing.Size(584, 246);
            this.gridDiscountCard.TabIndex = 1;
            this.gridDiscountCard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDiscountCard});
            this.gridDiscountCard.DoubleClick += new System.EventHandler(this.gridDiscountCard_DoubleClick);
            this.gridDiscountCard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridDiscountCard_KeyDown);
            // 
            // gridViewDiscountCard
            // 
            this.gridViewDiscountCard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_RowNum,
            this.gridColumnCardID,
            this.gridColumnLastName,
            this.gridColumnFirstName,
            this.gridColumnRegNum,
            this.gridColumnPhone,
            this.gridColumnCardNum,
            this.gridColumnDiscount,
            this.gridColumnAddress});
            this.gridViewDiscountCard.GridControl = this.gridDiscountCard;
            this.gridViewDiscountCard.Name = "gridViewDiscountCard";
            this.gridViewDiscountCard.OptionsView.ColumnAutoWidth = false;
            this.gridViewDiscountCard.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDiscountCard.OptionsView.ShowGroupPanel = false;
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
            // gridColumnCardID
            // 
            this.gridColumnCardID.Caption = "CardID";
            this.gridColumnCardID.FieldName = "CardID";
            this.gridColumnCardID.Name = "gridColumnCardID";
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
            this.gridColumnLastName.Width = 130;
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
            this.gridColumnFirstName.Width = 130;
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
            this.gridColumnRegNum.Width = 100;
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
            this.gridColumnPhone.VisibleIndex = 4;
            this.gridColumnPhone.Width = 90;
            // 
            // gridColumnCardNum
            // 
            this.gridColumnCardNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCardNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCardNum.Caption = "Карт №";
            this.gridColumnCardNum.FieldName = "CardNum";
            this.gridColumnCardNum.Name = "gridColumnCardNum";
            this.gridColumnCardNum.OptionsColumn.AllowEdit = false;
            this.gridColumnCardNum.OptionsColumn.AllowFocus = false;
            this.gridColumnCardNum.Visible = true;
            this.gridColumnCardNum.VisibleIndex = 5;
            this.gridColumnCardNum.Width = 130;
            // 
            // gridColumnDiscount
            // 
            this.gridColumnDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDiscount.Caption = "Хувь";
            this.gridColumnDiscount.FieldName = "Discount";
            this.gridColumnDiscount.Name = "gridColumnDiscount";
            this.gridColumnDiscount.OptionsColumn.AllowEdit = false;
            this.gridColumnDiscount.OptionsColumn.AllowFocus = false;
            this.gridColumnDiscount.Visible = true;
            this.gridColumnDiscount.VisibleIndex = 6;
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
            this.gridColumnAddress.Width = 200;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(514, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Хаах";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(5, 393);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(120, 23);
            this.btnPrintPreview.TabIndex = 6;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // DiscountCard
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(594, 422);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridDiscountCard);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscountCard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хөнгөлөлтийн карт";
            this.Load += new System.EventHandler(this.DiscountCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountProcent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardnum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegnum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscountCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiscountCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtDiscountProcent;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtCardnum;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtRegnum;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFirstname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLastname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridDiscountCard;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDiscountCard;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCardID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLastName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRegNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCardNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAddress;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_RowNum;
    }
}