namespace Pharmacy.Forms
{
    partial class Count
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCreateCount = new DevExpress.XtraEditors.SimpleButton();
            this.txtCountName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridCount = new DevExpress.XtraGrid.GridControl();
            this.gridViewCount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCountInvoiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCountNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCreateCount);
            this.panelControl1.Controls.Add(this.txtCountName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(684, 41);
            this.panelControl1.TabIndex = 0;
            // 
            // btnCreateCount
            // 
            this.btnCreateCount.Location = new System.Drawing.Point(548, 9);
            this.btnCreateCount.Name = "btnCreateCount";
            this.btnCreateCount.Size = new System.Drawing.Size(120, 23);
            this.btnCreateCount.TabIndex = 2;
            this.btnCreateCount.Text = "Үүсгэх";
            this.btnCreateCount.Click += new System.EventHandler(this.btnCreateCount_Click);
            // 
            // txtCountName
            // 
            this.txtCountName.Location = new System.Drawing.Point(103, 10);
            this.txtCountName.Name = "txtCountName";
            this.txtCountName.Size = new System.Drawing.Size(437, 20);
            this.txtCountName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Тооллогын нэр:";
            // 
            // gridCount
            // 
            this.gridCount.Location = new System.Drawing.Point(5, 52);
            this.gridCount.MainView = this.gridViewCount;
            this.gridCount.Name = "gridCount";
            this.gridCount.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
            this.gridCount.Size = new System.Drawing.Size(684, 266);
            this.gridCount.TabIndex = 1;
            this.gridCount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCount});
            this.gridCount.DoubleClick += new System.EventHandler(this.gridCount_DoubleClick);
            this.gridCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridCount_KeyDown);
            // 
            // gridViewCount
            // 
            this.gridViewCount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCountInvoiceID,
            this.gridColumnRowNum,
            this.gridColumnCountNum,
            this.gridColumnCountName,
            this.gridColumnActionDate,
            this.gridColumnStatus,
            this.gridColumnLink});
            this.gridViewCount.GridControl = this.gridCount;
            this.gridViewCount.Name = "gridViewCount";
            this.gridViewCount.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCount.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnCountInvoiceID
            // 
            this.gridColumnCountInvoiceID.Caption = "CountInvoiceID";
            this.gridColumnCountInvoiceID.FieldName = "CountInvoiceID";
            this.gridColumnCountInvoiceID.Name = "gridColumnCountInvoiceID";
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
            // gridColumnCountNum
            // 
            this.gridColumnCountNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCountNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCountNum.Caption = "Дугаар";
            this.gridColumnCountNum.FieldName = "CountNum";
            this.gridColumnCountNum.Name = "gridColumnCountNum";
            this.gridColumnCountNum.OptionsColumn.AllowEdit = false;
            this.gridColumnCountNum.OptionsColumn.AllowFocus = false;
            this.gridColumnCountNum.Visible = true;
            this.gridColumnCountNum.VisibleIndex = 1;
            this.gridColumnCountNum.Width = 109;
            // 
            // gridColumnCountName
            // 
            this.gridColumnCountName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCountName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCountName.Caption = "Нэр";
            this.gridColumnCountName.FieldName = "CountName";
            this.gridColumnCountName.Name = "gridColumnCountName";
            this.gridColumnCountName.OptionsColumn.AllowEdit = false;
            this.gridColumnCountName.OptionsColumn.AllowFocus = false;
            this.gridColumnCountName.Visible = true;
            this.gridColumnCountName.VisibleIndex = 2;
            this.gridColumnCountName.Width = 269;
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
            this.gridColumnActionDate.Visible = true;
            this.gridColumnActionDate.VisibleIndex = 3;
            this.gridColumnActionDate.Width = 109;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            // 
            // gridColumnLink
            // 
            this.gridColumnLink.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnLink.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnLink.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnLink.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnLink.Caption = "дэлгэрэнгүй";
            this.gridColumnLink.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.gridColumnLink.FieldName = "CountInvoiceID";
            this.gridColumnLink.Name = "gridColumnLink";
            this.gridColumnLink.Visible = true;
            this.gridColumnLink.VisibleIndex = 4;
            this.gridColumnLink.Width = 144;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Caption = "дэлгэрэнгүй";
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.Click += new System.EventHandler(this.repositoryItemHyperLinkEdit1_Click);
            // 
            // Count
            // 
            this.AcceptButton = this.btnCreateCount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 322);
            this.Controls.Add(this.gridCount);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Count";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тооллогын мэдээлэл";
            this.Load += new System.EventHandler(this.Count_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Count_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCreateCount;
        private DevExpress.XtraEditors.TextEdit txtCountName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridCount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCountInvoiceID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCountNum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCountName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLink;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRowNum;
    }
}