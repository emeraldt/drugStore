namespace Pharmacy.Settings
{
    partial class ClearData
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearData2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTootsooOgnoo2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookTootsooName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearData1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTootsooOgnoo1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTootsooName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartProgram = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTootsooOgnoo2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookTootsooName.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTootsooOgnoo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTootsooName.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox3);
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(370, 548);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClearData2);
            this.groupBox3.Controls.Add(this.txtTootsooOgnoo2);
            this.groupBox3.Controls.Add(this.labelControl4);
            this.groupBox3.Controls.Add(this.lookTootsooName);
            this.groupBox3.Controls.Add(this.labelControl3);
            this.groupBox3.Location = new System.Drawing.Point(5, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 160);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тооцооноос сонгон устгах";
            // 
            // btnClearData2
            // 
            this.btnClearData2.Location = new System.Drawing.Point(29, 122);
            this.btnClearData2.Name = "btnClearData2";
            this.btnClearData2.Size = new System.Drawing.Size(300, 23);
            this.btnClearData2.TabIndex = 5;
            this.btnClearData2.Text = "Тооцоог сонгон сутгах";
            this.btnClearData2.Click += new System.EventHandler(this.btnClearData2_Click);
            // 
            // txtTootsooOgnoo2
            // 
            this.txtTootsooOgnoo2.Location = new System.Drawing.Point(29, 92);
            this.txtTootsooOgnoo2.Name = "txtTootsooOgnoo2";
            this.txtTootsooOgnoo2.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txtTootsooOgnoo2.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtTootsooOgnoo2.Properties.ReadOnly = true;
            this.txtTootsooOgnoo2.Size = new System.Drawing.Size(300, 20);
            this.txtTootsooOgnoo2.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(113, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Тооцоо эхэлсэн огноо:";
            // 
            // lookTootsooName
            // 
            this.lookTootsooName.Location = new System.Drawing.Point(29, 47);
            this.lookTootsooName.Name = "lookTootsooName";
            this.lookTootsooName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookTootsooName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BillID", "BillID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BillName", 150, "Тооцооны нэр"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActionDate", "Огноо", 100, DevExpress.Utils.FormatType.DateTime, "yyyy-MM-dd hh:mm:ss", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status", 50, "Төлөв")});
            this.lookTootsooName.Properties.NullText = "";
            this.lookTootsooName.Properties.PopupFormMinSize = new System.Drawing.Size(300, 200);
            this.lookTootsooName.Size = new System.Drawing.Size(300, 20);
            this.lookTootsooName.TabIndex = 2;
            this.lookTootsooName.EditValueChanged += new System.EventHandler(this.lookTootsooName_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(131, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Идэвхитэй тооцооны нэр:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearData1);
            this.groupBox2.Controls.Add(this.txtTootsooOgnoo1);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.txtTootsooName);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Location = new System.Drawing.Point(5, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 160);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Програмын одооны тооцооноос өмнөх датаг устгах";
            // 
            // btnClearData1
            // 
            this.btnClearData1.Location = new System.Drawing.Point(29, 122);
            this.btnClearData1.Name = "btnClearData1";
            this.btnClearData1.Size = new System.Drawing.Size(300, 23);
            this.btnClearData1.TabIndex = 4;
            this.btnClearData1.Text = "Өмнөх датаг сутгах";
            this.btnClearData1.Click += new System.EventHandler(this.btnClearData1_Click);
            // 
            // txtTootsooOgnoo1
            // 
            this.txtTootsooOgnoo1.Location = new System.Drawing.Point(29, 92);
            this.txtTootsooOgnoo1.Name = "txtTootsooOgnoo1";
            this.txtTootsooOgnoo1.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txtTootsooOgnoo1.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtTootsooOgnoo1.Properties.ReadOnly = true;
            this.txtTootsooOgnoo1.Size = new System.Drawing.Size(300, 20);
            this.txtTootsooOgnoo1.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Тооцоо эхэлсэн огноо:";
            // 
            // txtTootsooName
            // 
            this.txtTootsooName.Location = new System.Drawing.Point(29, 47);
            this.txtTootsooName.Name = "txtTootsooName";
            this.txtTootsooName.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txtTootsooName.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtTootsooName.Properties.ReadOnly = true;
            this.txtTootsooName.Size = new System.Drawing.Size(300, 20);
            this.txtTootsooName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(131, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Идэвхитэй тооцооны нэр:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartProgram);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Програмынг шинээр эхлүүлэх";
            // 
            // btnStartProgram
            // 
            this.btnStartProgram.Location = new System.Drawing.Point(29, 23);
            this.btnStartProgram.Name = "btnStartProgram";
            this.btnStartProgram.Size = new System.Drawing.Size(300, 23);
            this.btnStartProgram.TabIndex = 1;
            this.btnStartProgram.Text = "Эхлүүлэх";
            this.btnStartProgram.Click += new System.EventHandler(this.btnStartProgram_Click);
            // 
            // ClearData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 572);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClearData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Програмын дата устгах";
            this.Load += new System.EventHandler(this.ClearData_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClearData_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTootsooOgnoo2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookTootsooName.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTootsooOgnoo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTootsooName.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnStartProgram;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtTootsooName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTootsooOgnoo1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnClearData1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.TextEdit txtTootsooOgnoo2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookTootsooName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnClearData2;
    }
}