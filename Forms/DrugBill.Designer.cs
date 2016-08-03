namespace Pharmacy.Forms
{
    partial class DrugBill
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.btnCloseBill = new DevExpress.XtraEditors.SimpleButton();
            this.txtComment = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookCountInvoiceID = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.txtBillName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridDrugBill = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBillNameEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCloseBill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiBillDetailView = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewDrugBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBillID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBillName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCountInvoiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCloseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBillComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCountNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barBillNameEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barCloseBill = new DevExpress.XtraBars.BarButtonItem();
            this.barBillDetailView = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCountInvoiceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrugBill)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrugBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.btnCreate);
            this.panelControl1.Controls.Add(this.txtBillName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(683, 222);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnView);
            this.panelControl2.Controls.Add(this.btnCloseBill);
            this.panelControl2.Controls.Add(this.txtComment);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.lookCountInvoiceID);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(26, 56);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(622, 152);
            this.panelControl2.TabIndex = 3;
            // 
            // btnView
            // 
            this.btnView.Appearance.Options.UseTextOptions = true;
            this.btnView.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnView.Enabled = false;
            this.btnView.Location = new System.Drawing.Point(480, 29);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(120, 40);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "Урьдчилсан байдлаар харах";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCloseBill
            // 
            this.btnCloseBill.Enabled = false;
            this.btnCloseBill.Location = new System.Drawing.Point(480, 85);
            this.btnCloseBill.Name = "btnCloseBill";
            this.btnCloseBill.Size = new System.Drawing.Size(120, 40);
            this.btnCloseBill.TabIndex = 7;
            this.btnCloseBill.Text = "Тооцоо хаах";
            this.btnCloseBill.Click += new System.EventHandler(this.btnCloseBill_Click);
            // 
            // txtComment
            // 
            this.txtComment.Enabled = false;
            this.txtComment.Location = new System.Drawing.Point(123, 45);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(333, 96);
            this.txtComment.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(71, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Тайлбар:";
            // 
            // lookCountInvoiceID
            // 
            this.lookCountInvoiceID.Enabled = false;
            this.lookCountInvoiceID.Location = new System.Drawing.Point(123, 19);
            this.lookCountInvoiceID.Name = "lookCountInvoiceID";
            this.lookCountInvoiceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCountInvoiceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountInvoiceID", "Тооллого №", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountNum", "Дугаар"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountName", "Нэр")});
            this.lookCountInvoiceID.Properties.NullText = "";
            this.lookCountInvoiceID.Size = new System.Drawing.Size(333, 20);
            this.lookCountInvoiceID.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Тооллого сонгох:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(528, 18);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Үүсгэх";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBillName
            // 
            this.txtBillName.Location = new System.Drawing.Point(106, 20);
            this.txtBillName.Name = "txtBillName";
            this.txtBillName.Size = new System.Drawing.Size(416, 20);
            this.txtBillName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Тооцооны нэр:";
            // 
            // gridDrugBill
            // 
            this.gridDrugBill.ContextMenuStrip = this.contextMenuStrip1;
            this.gridDrugBill.Location = new System.Drawing.Point(5, 233);
            this.gridDrugBill.MainView = this.gridViewDrugBill;
            this.gridDrugBill.Name = "gridDrugBill";
            this.gridDrugBill.Size = new System.Drawing.Size(683, 248);
            this.gridDrugBill.TabIndex = 1;
            this.gridDrugBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDrugBill});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBillNameEdit,
            this.toolStripSeparator1,
            this.tsmiCloseBill,
            this.toolStripSeparator2,
            this.tsmiBillDetailView});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(236, 82);
            // 
            // tsmiBillNameEdit
            // 
            this.tsmiBillNameEdit.Name = "tsmiBillNameEdit";
            this.tsmiBillNameEdit.Size = new System.Drawing.Size(235, 22);
            this.tsmiBillNameEdit.Text = "Тооцооны нэр засах";
            this.tsmiBillNameEdit.Click += new System.EventHandler(this.tsmiBillNameEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // tsmiCloseBill
            // 
            this.tsmiCloseBill.Name = "tsmiCloseBill";
            this.tsmiCloseBill.Size = new System.Drawing.Size(235, 22);
            this.tsmiCloseBill.Text = "Тооцоо хаах";
            this.tsmiCloseBill.Click += new System.EventHandler(this.tsmiCloseBill_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // tsmiBillDetailView
            // 
            this.tsmiBillDetailView.Name = "tsmiBillDetailView";
            this.tsmiBillDetailView.Size = new System.Drawing.Size(235, 22);
            this.tsmiBillDetailView.Text = "Тооцооны дэлгэрэнгүй харах";
            this.tsmiBillDetailView.Click += new System.EventHandler(this.tsmiBillDetailView_Click);
            // 
            // gridViewDrugBill
            // 
            this.gridViewDrugBill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnBillID,
            this.gridColumnBillName,
            this.gridColumnActionDate,
            this.gridColumnCountInvoiceID,
            this.gridColumnCloseDate,
            this.gridColumnBillComment,
            this.gridColumnStatus,
            this.gridColumnCountNum});
            this.gridViewDrugBill.GridControl = this.gridDrugBill;
            this.gridViewDrugBill.Name = "gridViewDrugBill";
            this.gridViewDrugBill.OptionsView.ColumnAutoWidth = false;
            this.gridViewDrugBill.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnBillID
            // 
            this.gridColumnBillID.Caption = "BillID";
            this.gridColumnBillID.FieldName = "BillID";
            this.gridColumnBillID.Name = "gridColumnBillID";
            // 
            // gridColumnBillName
            // 
            this.gridColumnBillName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnBillName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBillName.Caption = "Тооцооны нэр";
            this.gridColumnBillName.FieldName = "BillName";
            this.gridColumnBillName.Name = "gridColumnBillName";
            this.gridColumnBillName.OptionsColumn.AllowEdit = false;
            this.gridColumnBillName.OptionsColumn.AllowFocus = false;
            this.gridColumnBillName.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnBillName.OptionsFilter.AllowFilter = false;
            this.gridColumnBillName.Visible = true;
            this.gridColumnBillName.VisibleIndex = 0;
            this.gridColumnBillName.Width = 190;
            // 
            // gridColumnActionDate
            // 
            this.gridColumnActionDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnActionDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnActionDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnActionDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnActionDate.Caption = "Үүсгэсэн";
            this.gridColumnActionDate.DisplayFormat.FormatString = "yyyy-MM-dd hh:mm:ss";
            this.gridColumnActionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnActionDate.FieldName = "ActionDate";
            this.gridColumnActionDate.Name = "gridColumnActionDate";
            this.gridColumnActionDate.OptionsColumn.AllowEdit = false;
            this.gridColumnActionDate.OptionsColumn.AllowFocus = false;
            this.gridColumnActionDate.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnActionDate.OptionsFilter.AllowFilter = false;
            this.gridColumnActionDate.Visible = true;
            this.gridColumnActionDate.VisibleIndex = 1;
            this.gridColumnActionDate.Width = 120;
            // 
            // gridColumnCountInvoiceID
            // 
            this.gridColumnCountInvoiceID.Caption = "CountInvoiceID";
            this.gridColumnCountInvoiceID.FieldName = "CountInvoiceID";
            this.gridColumnCountInvoiceID.Name = "gridColumnCountInvoiceID";
            // 
            // gridColumnCloseDate
            // 
            this.gridColumnCloseDate.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnCloseDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCloseDate.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCloseDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCloseDate.Caption = "Хаасан огноо";
            this.gridColumnCloseDate.DisplayFormat.FormatString = "yyyy-MM-dd hh:mm:ss";
            this.gridColumnCloseDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnCloseDate.FieldName = "CloseDate";
            this.gridColumnCloseDate.Name = "gridColumnCloseDate";
            this.gridColumnCloseDate.OptionsColumn.AllowEdit = false;
            this.gridColumnCloseDate.OptionsColumn.AllowFocus = false;
            this.gridColumnCloseDate.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnCloseDate.OptionsFilter.AllowFilter = false;
            this.gridColumnCloseDate.Visible = true;
            this.gridColumnCloseDate.VisibleIndex = 3;
            this.gridColumnCloseDate.Width = 120;
            // 
            // gridColumnBillComment
            // 
            this.gridColumnBillComment.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnBillComment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnBillComment.Caption = "Тайлбар";
            this.gridColumnBillComment.FieldName = "BillComment";
            this.gridColumnBillComment.Name = "gridColumnBillComment";
            this.gridColumnBillComment.OptionsColumn.AllowEdit = false;
            this.gridColumnBillComment.OptionsColumn.AllowFocus = false;
            this.gridColumnBillComment.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnBillComment.OptionsFilter.AllowFilter = false;
            this.gridColumnBillComment.Visible = true;
            this.gridColumnBillComment.VisibleIndex = 5;
            this.gridColumnBillComment.Width = 300;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnStatus.Caption = "Хаасан эсэх";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            this.gridColumnStatus.OptionsColumn.AllowEdit = false;
            this.gridColumnStatus.OptionsColumn.AllowFocus = false;
            this.gridColumnStatus.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnStatus.OptionsFilter.AllowFilter = false;
            this.gridColumnStatus.Visible = true;
            this.gridColumnStatus.VisibleIndex = 2;
            this.gridColumnStatus.Width = 70;
            // 
            // gridColumnCountNum
            // 
            this.gridColumnCountNum.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCountNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCountNum.Caption = "Тооллогын нэр";
            this.gridColumnCountNum.FieldName = "CountNum";
            this.gridColumnCountNum.Name = "gridColumnCountNum";
            this.gridColumnCountNum.OptionsColumn.AllowEdit = false;
            this.gridColumnCountNum.OptionsColumn.AllowFocus = false;
            this.gridColumnCountNum.OptionsFilter.AllowAutoFilter = false;
            this.gridColumnCountNum.OptionsFilter.AllowFilter = false;
            this.gridColumnCountNum.Visible = true;
            this.gridColumnCountNum.VisibleIndex = 4;
            this.gridColumnCountNum.Width = 150;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBillNameEdit,
            this.barCloseBill,
            this.barBillDetailView});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(694, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 485);
            this.barDockControlBottom.Size = new System.Drawing.Size(694, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 485);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(694, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 485);
            // 
            // barBillNameEdit
            // 
            this.barBillNameEdit.Caption = "Тооцооны нэр засах";
            this.barBillNameEdit.Id = 0;
            this.barBillNameEdit.Name = "barBillNameEdit";
            // 
            // barCloseBill
            // 
            this.barCloseBill.Caption = "Тооцоог хаах";
            this.barCloseBill.Id = 1;
            this.barCloseBill.Name = "barCloseBill";
            // 
            // barBillDetailView
            // 
            this.barBillDetailView.Caption = "Тооцооны дэлгэрэнгүй харах";
            this.barBillDetailView.Id = 2;
            this.barBillDetailView.Name = "barBillDetailView";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBillNameEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCloseBill, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBillDetailView, true)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // DrugBill
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 485);
            this.Controls.Add(this.gridDrugBill);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrugBill";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эмийн тооцоо";
            this.Load += new System.EventHandler(this.DrugBill_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrugBill_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCountInvoiceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrugBill)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDrugBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtBillName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCloseBill;
        private DevExpress.XtraEditors.MemoEdit txtComment;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookCountInvoiceID;
        private DevExpress.XtraGrid.GridControl gridDrugBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDrugBill;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBillID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBillName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCountInvoiceID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCloseDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBillComment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCountNum;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBillNameEdit;
        private DevExpress.XtraBars.BarButtonItem barCloseBill;
        private DevExpress.XtraBars.BarButtonItem barBillDetailView;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBillNameEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseBill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiBillDetailView;
        private DevExpress.XtraEditors.SimpleButton btnView;
    }
}