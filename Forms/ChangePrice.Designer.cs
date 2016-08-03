namespace Pharmacy.Forms
{
    partial class ChangePrice
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
            this.btnDrugList = new DevExpress.XtraEditors.SimpleButton();
            this.txtNewPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtOldPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBalance = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookDrug = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookDrug.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDrugList);
            this.panelControl1.Controls.Add(this.txtNewPrice);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtOldPrice);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtBalance);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lookDrug);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(344, 147);
            this.panelControl1.TabIndex = 0;
            // 
            // btnDrugList
            // 
            this.btnDrugList.Location = new System.Drawing.Point(281, 18);
            this.btnDrugList.Name = "btnDrugList";
            this.btnDrugList.Size = new System.Drawing.Size(23, 23);
            this.btnDrugList.TabIndex = 8;
            this.btnDrugList.Text = "F1";
            this.btnDrugList.Click += new System.EventHandler(this.btnDrugList_Click);
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(114, 107);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Properties.Mask.EditMask = "n";
            this.txtNewPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNewPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNewPrice.Size = new System.Drawing.Size(161, 20);
            this.txtNewPrice.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(57, 110);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Шинэ үнэ:";
            // 
            // txtOldPrice
            // 
            this.txtOldPrice.Enabled = false;
            this.txtOldPrice.Location = new System.Drawing.Point(114, 81);
            this.txtOldPrice.Name = "txtOldPrice";
            this.txtOldPrice.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtOldPrice.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtOldPrice.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtOldPrice.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtOldPrice.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtOldPrice.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtOldPrice.Properties.Mask.EditMask = "n";
            this.txtOldPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOldPrice.Size = new System.Drawing.Size(161, 20);
            this.txtOldPrice.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(49, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Хуучин үнэ:";
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Location = new System.Drawing.Point(114, 55);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtBalance.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtBalance.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtBalance.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtBalance.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtBalance.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBalance.Size = new System.Drawing.Size(161, 20);
            this.txtBalance.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(57, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Үлдэгдэл:";
            // 
            // lookDrug
            // 
            this.lookDrug.Location = new System.Drawing.Point(86, 20);
            this.lookDrug.Name = "lookDrug";
            this.lookDrug.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookDrug.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RowNum", 40, "№"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DrugID", "DrugID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 190, "Нэр"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Size", 50, "Тун"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Package", 60, "Савлалт"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", 60, "Үнэ")});
            this.lookDrug.Properties.NullText = "";
            this.lookDrug.Properties.PopupFormMinSize = new System.Drawing.Size(400, 300);
            this.lookDrug.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookDrug.Size = new System.Drawing.Size(189, 20);
            this.lookDrug.TabIndex = 1;
            this.lookDrug.EditValueChanged += new System.EventHandler(this.lookDrug_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Эмийн нэр:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(5, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Хадгалах";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(274, 158);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Хаах";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ChangePrice
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(354, 186);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePrice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эмийн үнэ өөрчлөх";
            this.Load += new System.EventHandler(this.ChangePrice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangePrice_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookDrug.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNewPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtOldPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtBalance;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        public DevExpress.XtraEditors.LookUpEdit lookDrug;
        public DevExpress.XtraEditors.SimpleButton btnDrugList;
    }
}