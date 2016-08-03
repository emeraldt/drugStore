namespace Pharmacy
{
    partial class Switchscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Switchscreen));
            this.btnNormalPos = new DevExpress.XtraEditors.SimpleButton();
            this.btnMain = new DevExpress.XtraEditors.SimpleButton();
            this.btnDiscountPos = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnNormalPos
            // 
            this.btnNormalPos.Location = new System.Drawing.Point(12, 12);
            this.btnNormalPos.Name = "btnNormalPos";
            this.btnNormalPos.Size = new System.Drawing.Size(350, 100);
            this.btnNormalPos.TabIndex = 0;
            this.btnNormalPos.Text = "Эмийн сангийн борлуулалт";
            this.btnNormalPos.Click += new System.EventHandler(this.btnNormalPos_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(12, 118);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(350, 100);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Үндсэн програм";
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnDiscountPos
            // 
            this.btnDiscountPos.Location = new System.Drawing.Point(12, 224);
            this.btnDiscountPos.Name = "btnDiscountPos";
            this.btnDiscountPos.Size = new System.Drawing.Size(350, 100);
            this.btnDiscountPos.TabIndex = 2;
            this.btnDiscountPos.Text = "Хөнгөлттэй эмийн борлуулалт";
            this.btnDiscountPos.Click += new System.EventHandler(this.btnDiscountPos_Click);
            // 
            // Switchscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 337);
            this.Controls.Add(this.btnDiscountPos);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnNormalPos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Switchscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Эмийн сангийн систем";
            this.Load += new System.EventHandler(this.Switchscreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNormalPos;
        private DevExpress.XtraEditors.SimpleButton btnMain;
        private DevExpress.XtraEditors.SimpleButton btnDiscountPos;
    }
}