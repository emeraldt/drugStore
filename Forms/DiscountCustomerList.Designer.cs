namespace Pharmacy.Forms
{
    partial class DiscountCustomerList
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
            this.gridDiscountCustomer = new DevExpress.XtraGrid.GridControl();
            this.gridViewDiscountCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRegNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNDNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEMDNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_RowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscountCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiscountCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDiscountCustomer
            // 
            this.gridDiscountCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDiscountCustomer.Location = new System.Drawing.Point(0, 0);
            this.gridDiscountCustomer.MainView = this.gridViewDiscountCustomer;
            this.gridDiscountCustomer.Name = "gridDiscountCustomer";
            this.gridDiscountCustomer.Size = new System.Drawing.Size(744, 522);
            this.gridDiscountCustomer.TabIndex = 2;
            this.gridDiscountCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDiscountCustomer});
            // 
            // gridViewDiscountCustomer
            // 
            this.gridViewDiscountCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCustomerID,
            this.gridColumn_RowNum,
            this.gridColumnLastName,
            this.gridColumnFirstName,
            this.gridColumnRegNum,
            this.gridColumnNDNum,
            this.gridColumnEMDNum,
            this.gridColumnPhone,
            this.gridColumnAddress});
            this.gridViewDiscountCustomer.GridControl = this.gridDiscountCustomer;
            this.gridViewDiscountCustomer.Name = "gridViewDiscountCustomer";
            this.gridViewDiscountCustomer.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDiscountCustomer.OptionsView.ShowGroupPanel = false;
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
            this.gridColumnLastName.Width = 107;
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
            this.gridColumnFirstName.Width = 107;
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
            this.gridColumnRegNum.Width = 71;
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
            this.gridColumnNDNum.Width = 72;
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
            this.gridColumnEMDNum.Width = 66;
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
            this.gridColumnPhone.Width = 67;
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
            this.gridColumnAddress.Width = 150;
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
            this.gridColumn_RowNum.Width = 46;
            // 
            // DiscountCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 522);
            this.Controls.Add(this.gridDiscountCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "DiscountCustomerList";
            this.Text = "Даатгуулагчын жагсаалт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiscountCustomerList_FormClosing);
            this.Load += new System.EventHandler(this.DiscountCustomerList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiscountCustomerList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiscountCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDiscountCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridDiscountCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDiscountCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLastName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRegNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNDNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEMDNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_RowNum;
    }
}