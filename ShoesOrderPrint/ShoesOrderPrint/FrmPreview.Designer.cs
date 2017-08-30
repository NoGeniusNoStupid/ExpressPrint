namespace ShoesOrderPrint
{
    partial class FrmPreview
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
            this.txButton1 = new TX.Framework.WindowUI.Controls.TXButton();
            this.SuspendLayout();
            // 
            // txButton1
            // 
            this.txButton1.AllowDrop = true;
            this.txButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txButton1.Image = null;
            this.txButton1.Location = new System.Drawing.Point(302, 266);
            this.txButton1.Name = "txButton1";
            this.txButton1.Size = new System.Drawing.Size(100, 28);
            this.txButton1.TabIndex = 0;
            this.txButton1.Text = "保存";
            this.txButton1.UseVisualStyleBackColor = true;
            this.txButton1.Click += new System.EventHandler(this.txButton1_Click);
            // 
            // FrmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 297);
            this.Controls.Add(this.txButton1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印预览";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPreview_FormClosing);
            this.Load += new System.EventHandler(this.FrmPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXButton txButton1;


    }
}