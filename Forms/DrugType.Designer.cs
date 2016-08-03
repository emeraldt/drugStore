namespace Pharmacy.Forms
{
    partial class DrugType
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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtShotname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridType = new DevExpress.XtraGrid.GridControl();
            this.gridViewType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_RowNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnShot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShotname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewType)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.txtShotname);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(484, 70);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(378, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Бүртгэх";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtShotname
            // 
            this.txtShotname.Location = new System.Drawing.Point(83, 40);
            this.txtShotname.Name = "txtShotname";
            this.txtShotname.Size = new System.Drawing.Size(281, 20);
            this.txtShotname.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Товчлол:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 20);
            this.txtName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Нэр:";
            // 
            // gridType
            // 
            this.gridType.Location = new System.Drawing.Point(5, 81);
            this.gridType.MainView = this.gridViewType;
            this.gridType.Name = "gridType";
            this.gridType.Size = new System.Drawing.Size(484, 206);
            this.gridType.TabIndex = 1;
            this.gridType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewType});
            this.gridType.DoubleClick += new System.EventHandler(this.gridType_DoubleClick);
            this.gridType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridType_KeyDown);
            // 
            // gridViewType
            // 
            this.gridViewType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_RowNum,
            this.gridColumnTypeID,
            this.gridColumnName,
            this.gridColumnShot});
            this.gridViewType.GridControl = this.gridType;
            this.gridViewType.Name = "gridViewType";
            this.gridViewType.OptionsView.ShowAutoFilterRow = true;
            this.gridViewType.OptionsView.ShowGroupPanel = false;
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
            // gridColumnTypeID
            // 
            this.gridColumnTypeID.Caption = "TypeID";
            this.gridColumnTypeID.FieldName = "TypeID";
            this.gridColumnTypeID.Name = "gridColumnTypeID";
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
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 293;
            // 
            // gridColumnShot
            // 
            this.gridColumnShot.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnShot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnShot.Caption = "Товчлол";
            this.gridColumnShot.FieldName = "Shot";
            this.gridColumnShot.Name = "gridColumnShot";
            this.gridColumnShot.OptionsColumn.AllowEdit = false;
            this.gridColumnShot.OptionsColumn.AllowFocus = false;
            this.gridColumnShot.Visible = true;
            this.gridColumnShot.VisibleIndex = 2;
            this.gridColumnShot.Width = 133;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(414, 293);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Хаах";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(5, 293);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(120, 23);
            this.btnPrintPreview.TabIndex = 5;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // DrugType
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(494, 322);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridType);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrugType";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эмийн төрөл";
            this.Load += new System.EventHandler(this.DrugType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShotname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtShotname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewType;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnShot;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_RowNum;
    }
}