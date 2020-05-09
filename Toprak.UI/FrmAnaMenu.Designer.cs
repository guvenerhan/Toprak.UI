namespace Toprak.UI
{
    partial class FrmAnaMenu
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
            this.calcEdit1 = new DevExpress.XtraEditors.CalcEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // calcEdit1
            // 
            this.calcEdit1.Location = new System.Drawing.Point(195, 58);
            this.calcEdit1.Name = "calcEdit1";
            this.calcEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcEdit1.Properties.Appearance.Options.UseFont = true;
            this.calcEdit1.Size = new System.Drawing.Size(260, 48);
            this.calcEdit1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(195, 181);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(260, 110);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Kademeyi Onayla";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 472);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.calcEdit1);
            this.Name = "FrmAnaMenu";
            this.Text = "FrmAnaMenu";
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CalcEdit calcEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}