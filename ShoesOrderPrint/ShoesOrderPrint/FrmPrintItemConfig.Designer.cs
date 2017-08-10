namespace ShoesOrderPrint
{
    partial class FrmPrintItemConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.t_dgv_PrintItemConfig = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txComboBox1 = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.t_btn_Preview = new TX.Framework.WindowUI.Controls.TXButton();
            this.t_btn_SaveConfig = new TX.Framework.WindowUI.Controls.TXButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t_dgv_PrintItemConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // t_dgv_PrintItemConfig
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.t_dgv_PrintItemConfig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.t_dgv_PrintItemConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_dgv_PrintItemConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.t_dgv_PrintItemConfig.DefaultCellStyle = dataGridViewCellStyle2;
            this.t_dgv_PrintItemConfig.Location = new System.Drawing.Point(6, 72);
            this.t_dgv_PrintItemConfig.Name = "t_dgv_PrintItemConfig";
            this.t_dgv_PrintItemConfig.RowTemplate.Height = 23;
            this.t_dgv_PrintItemConfig.Size = new System.Drawing.Size(742, 551);
            this.t_dgv_PrintItemConfig.TabIndex = 0;
            this.t_dgv_PrintItemConfig.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.t_dgv_PrintItemConfig_DataError);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ItemlName";
            this.Column1.HeaderText = "打印项";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Wight";
            this.Column2.HeaderText = "宽度";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Helght";
            this.Column3.HeaderText = "高度";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LeftAway";
            this.Column4.HeaderText = "左边距";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TopAway";
            this.Column5.HeaderText = "上边距";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Font";
            this.Column6.HeaderText = "字体";
            this.Column6.Items.AddRange(new object[] {
            "宋体",
            "黑体",
            "楷体",
            "隶书",
            "微软雅黑"});
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FontSize";
            this.Column7.HeaderText = "字体大小";
            this.Column7.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32"});
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Visable";
            this.Column8.HeaderText = "是否显示";
            this.Column8.Items.AddRange(new object[] {
            "是",
            "否"});
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txComboBox1
            // 
            this.txComboBox1.FormattingEnabled = true;
            this.txComboBox1.Location = new System.Drawing.Point(66, 43);
            this.txComboBox1.Name = "txComboBox1";
            this.txComboBox1.Size = new System.Drawing.Size(150, 20);
            this.txComboBox1.TabIndex = 1;
            this.txComboBox1.SelectedIndexChanged += new System.EventHandler(this.txComboBox1_SelectedIndexChanged);
            // 
            // t_btn_Preview
            // 
            this.t_btn_Preview.Image = null;
            this.t_btn_Preview.Location = new System.Drawing.Point(544, 626);
            this.t_btn_Preview.Name = "t_btn_Preview";
            this.t_btn_Preview.Size = new System.Drawing.Size(100, 28);
            this.t_btn_Preview.TabIndex = 2;
            this.t_btn_Preview.Text = "预览";
            this.t_btn_Preview.UseVisualStyleBackColor = true;
            this.t_btn_Preview.Click += new System.EventHandler(this.t_btn_Preview_Click);
            // 
            // t_btn_SaveConfig
            // 
            this.t_btn_SaveConfig.Image = null;
            this.t_btn_SaveConfig.Location = new System.Drawing.Point(650, 626);
            this.t_btn_SaveConfig.Name = "t_btn_SaveConfig";
            this.t_btn_SaveConfig.Size = new System.Drawing.Size(100, 28);
            this.t_btn_SaveConfig.TabIndex = 3;
            this.t_btn_SaveConfig.Text = "保存";
            this.t_btn_SaveConfig.UseVisualStyleBackColor = true;
            this.t_btn_SaveConfig.Click += new System.EventHandler(this.t_btn_SaveConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "打印模板";
            // 
            // FrmPrintItemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_btn_SaveConfig);
            this.Controls.Add(this.t_btn_Preview);
            this.Controls.Add(this.txComboBox1);
            this.Controls.Add(this.t_dgv_PrintItemConfig);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPrintItemConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印项配置";
            this.Load += new System.EventHandler(this.FrmPrintItemConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_dgv_PrintItemConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView t_dgv_PrintItemConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column7;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column8;
        private TX.Framework.WindowUI.Controls.TXComboBox txComboBox1;
        private TX.Framework.WindowUI.Controls.TXButton t_btn_Preview;
        private TX.Framework.WindowUI.Controls.TXButton t_btn_SaveConfig;
        private System.Windows.Forms.Label label1;
    }
}