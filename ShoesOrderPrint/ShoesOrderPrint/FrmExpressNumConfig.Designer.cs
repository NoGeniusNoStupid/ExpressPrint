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
            this.t_dgv_Data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.t_dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // t_btn_Save
            // 
            this.t_btn_Save.Image = null;
            this.t_btn_Save.Location = new System.Drawing.Point(525, 433);
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
            this.t_btn_Cancel.Location = new System.Drawing.Point(631, 433);
            this.t_btn_Cancel.Name = "t_btn_Cancel";
            this.t_btn_Cancel.Size = new System.Drawing.Size(100, 28);
            this.t_btn_Cancel.TabIndex = 1;
            this.t_btn_Cancel.Text = "取消(&C)";
            this.t_btn_Cancel.UseVisualStyleBackColor = true;
            this.t_btn_Cancel.Click += new System.EventHandler(this.t_btn_Cancel_Click);
            // 
            // t_dgv_Data
            // 
            this.t_dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.t_dgv_Data.Location = new System.Drawing.Point(6, 43);
            this.t_dgv_Data.Name = "t_dgv_Data";
            this.t_dgv_Data.RowTemplate.Height = 23;
            this.t_dgv_Data.Size = new System.Drawing.Size(725, 372);
            this.t_dgv_Data.TabIndex = 2;
            this.t_dgv_Data.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.t_dgv_Data_DataError);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ExpressName";
            this.Column1.HeaderText = "快递类型";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ExrepssNumRule";
            this.Column2.HeaderText = "是否自动生成快递号";
            this.Column2.Items.AddRange(new object[] {
            "是",
            "否"});
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ExpressBeforeNum";
            this.Column3.HeaderText = "快递号前缀";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SerialNum";
            this.Column4.HeaderText = "流水号长度";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ExpressStartNum";
            this.Column5.HeaderText = "流水号起始值";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // FrmExpressNumConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 467);
            this.Controls.Add(this.t_dgv_Data);
            this.Controls.Add(this.t_btn_Cancel);
            this.Controls.Add(this.t_btn_Save);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmExpressNumConfig";
            this.Text = "快递单号配置";
            this.Load += new System.EventHandler(this.FrmExpressNumConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_dgv_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXButton t_btn_Save;
        private TX.Framework.WindowUI.Controls.TXButton t_btn_Cancel;
        private System.Windows.Forms.DataGridView t_dgv_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}