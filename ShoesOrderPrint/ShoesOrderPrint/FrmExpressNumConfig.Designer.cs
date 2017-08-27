namespace ShoesOrderPrint
{
    partial class FrmExpressNumConfig
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
            this.t_btn_Save = new TX.Framework.WindowUI.Controls.TXButton();
            this.t_btn_Cancel = new TX.Framework.WindowUI.Controls.TXButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // t_btn_Save
            // 
            this.t_btn_Save.Image = null;
            this.t_btn_Save.Location = new System.Drawing.Point(544, 433);
            this.t_btn_Save.Name = "t_btn_Save";
            this.t_btn_Save.Size = new System.Drawing.Size(100, 28);
            this.t_btn_Save.TabIndex = 0;
            this.t_btn_Save.Text = "保存(&S)";
            this.t_btn_Save.UseVisualStyleBackColor = true;
            this.t_btn_Save.Click += new System.EventHandler(this.t_btn_Save_Click);
            // 
            // t_btn_Cancel
            // 
            this.t_btn_Cancel.Image = null;
            this.t_btn_Cancel.Location = new System.Drawing.Point(650, 433);
            this.t_btn_Cancel.Name = "t_btn_Cancel";
            this.t_btn_Cancel.Size = new System.Drawing.Size(100, 28);
            this.t_btn_Cancel.TabIndex = 1;
            this.t_btn_Cancel.Text = "取消(&C)";
            this.t_btn_Cancel.UseVisualStyleBackColor = true;
            this.t_btn_Cancel.Click += new System.EventHandler(this.t_btn_Cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(744, 372);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmExpressNumConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 467);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.t_btn_Cancel);
            this.Controls.Add(this.t_btn_Save);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmExpressNumConfig";
            this.Text = "快递单号配置";
            this.Load += new System.EventHandler(this.FrmExpressNumConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXButton t_btn_Save;
        private TX.Framework.WindowUI.Controls.TXButton t_btn_Cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}