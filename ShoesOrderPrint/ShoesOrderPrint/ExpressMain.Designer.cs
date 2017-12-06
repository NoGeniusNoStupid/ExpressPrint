namespace ShoesOrderPrint
{
    partial class ExpressMain
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
            this.txButton4 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton2 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton1 = new TX.Framework.WindowUI.Controls.TXButton();
            this.label1 = new System.Windows.Forms.Label();
            this.t_btn_ExpressNoConfig = new TX.Framework.WindowUI.Controls.TXButton();
            this.SuspendLayout();
            // 
            // txButton4
            // 
            this.txButton4.Image = null;
            this.txButton4.Location = new System.Drawing.Point(120, 171);
            this.txButton4.Name = "txButton4";
            this.txButton4.Size = new System.Drawing.Size(100, 28);
            this.txButton4.TabIndex = 7;
            this.txButton4.Text = "打印项配置";
            this.txButton4.UseVisualStyleBackColor = true;
            this.txButton4.Click += new System.EventHandler(this.txButton4_Click);
            // 
            // txButton2
            // 
            this.txButton2.Image = null;
            this.txButton2.Location = new System.Drawing.Point(281, 171);
            this.txButton2.Name = "txButton2";
            this.txButton2.Size = new System.Drawing.Size(100, 28);
            this.txButton2.TabIndex = 6;
            this.txButton2.Text = "快递单管理";
            this.txButton2.UseVisualStyleBackColor = true;
            this.txButton2.Click += new System.EventHandler(this.txButton2_Click);
            // 
            // txButton1
            // 
            this.txButton1.Image = null;
            this.txButton1.Location = new System.Drawing.Point(281, 117);
            this.txButton1.Name = "txButton1";
            this.txButton1.Size = new System.Drawing.Size(100, 28);
            this.txButton1.TabIndex = 5;
            this.txButton1.Text = "快递单录入";
            this.txButton1.UseVisualStyleBackColor = true;
            this.txButton1.Click += new System.EventHandler(this.txButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(329, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "*若数据重要请定期备份";
            // 
            // t_btn_ExpressNoConfig
            // 
            this.t_btn_ExpressNoConfig.Image = null;
            this.t_btn_ExpressNoConfig.Location = new System.Drawing.Point(120, 117);
            this.t_btn_ExpressNoConfig.Name = "t_btn_ExpressNoConfig";
            this.t_btn_ExpressNoConfig.Size = new System.Drawing.Size(100, 28);
            this.t_btn_ExpressNoConfig.TabIndex = 11;
            this.t_btn_ExpressNoConfig.Text = "快递单号配置";
            this.t_btn_ExpressNoConfig.UseVisualStyleBackColor = true;
            this.t_btn_ExpressNoConfig.Click += new System.EventHandler(this.t_btn_ExpressNoConfig_Click);
            // 
            // ExpressMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.t_btn_ExpressNoConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txButton4);
            this.Controls.Add(this.txButton2);
            this.Controls.Add(this.txButton1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpressMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能打印";
            this.Load += new System.EventHandler(this.ExpressMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXButton txButton4;
        private TX.Framework.WindowUI.Controls.TXButton txButton2;
        private TX.Framework.WindowUI.Controls.TXButton txButton1;
        private System.Windows.Forms.Label label1;
        private TX.Framework.WindowUI.Controls.TXButton t_btn_ExpressNoConfig;
    }
}