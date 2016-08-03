namespace Pharmacy.Forms
{
    partial class FormBillReturn
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBillNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.date = new DevExpress.XtraEditors.DateEdit();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(32, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Баримтын ДДТД:";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(141, 28);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtBillNo.Properties.Appearance.Options.UseFont = true;
            this.txtBillNo.Properties.Mask.EditMask = "[0-9]{33}";
            this.txtBillNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtBillNo.Size = new System.Drawing.Size(254, 22);
            this.txtBillNo.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(28, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Гүйлгээний огноо:";
            // 
            // date
            // 
            this.date.EditValue = null;
            this.date.Location = new System.Drawing.Point(141, 70);
            this.date.Name = "date";
            this.date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.date.Properties.Appearance.Options.UseFont = true;
            this.date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.date.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.date.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date.Size = new System.Drawing.Size(254, 22);
            this.date.TabIndex = 3;
            // 
            // btnReturn
            // 
            this.btnReturn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnReturn.Appearance.Options.UseFont = true;
            this.btnReturn.Location = new System.Drawing.Point(124, 114);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 29);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Буцаах";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(215, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Болих";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormBillReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 167);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.date);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Caramel";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "FormBillReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Баримтын буцаалт";
            this.Load += new System.EventHandler(this.FormBillReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBillNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBillNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit date;
        private DevExpress.XtraEditors.SimpleButton btnReturn;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}