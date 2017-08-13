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
            this.t_cmg_ = new System.Windows.Forms.DataGridView();
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
            this.txGroupBox1 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.t_btn_TemplateSava = new TX.Framework.WindowUI.Controls.TXButton();
            this.t_btn_ColorSelect = new TX.Framework.WindowUI.Controls.TXButton();
            this.t_txt_Color = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.t_cmg_FontSize = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.t_cmg_Font = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t_cmg_)).BeginInit();
            this.txGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_cmg_
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.t_cmg_.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.t_cmg_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_cmg_.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.t_cmg_.DefaultCellStyle = dataGridViewCellStyle2;
            this.t_cmg_.Location = new System.Drawing.Point(6, 94);
            this.t_cmg_.Name = "t_cmg_";
            this.t_cmg_.RowTemplate.Height = 23;
            this.t_cmg_.Size = new System.Drawing.Size(742, 529);
            this.t_cmg_.TabIndex = 0;
            this.t_cmg_.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.t_dgv_PrintItemConfig_DataError);
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
            this.txComboBox1.Location = new System.Drawing.Point(65, 23);
            this.txComboBox1.Name = "txComboBox1";
            this.txComboBox1.Size = new System.Drawing.Size(135, 20);
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
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "打印模板";
            // 
            // txGroupBox1
            // 
            this.txGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox1.BorderStyle = TX.Framework.WindowUI.EnumBorderStyle.QQStyle;
            this.txGroupBox1.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox1.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox1.Controls.Add(this.t_btn_TemplateSava);
            this.txGroupBox1.Controls.Add(this.t_btn_ColorSelect);
            this.txGroupBox1.Controls.Add(this.t_txt_Color);
            this.txGroupBox1.Controls.Add(this.t_cmg_FontSize);
            this.txGroupBox1.Controls.Add(this.t_cmg_Font);
            this.txGroupBox1.Controls.Add(this.label4);
            this.txGroupBox1.Controls.Add(this.label3);
            this.txGroupBox1.Controls.Add(this.label2);
            this.txGroupBox1.Controls.Add(this.label1);
            this.txGroupBox1.Controls.Add(this.txComboBox1);
            this.txGroupBox1.Location = new System.Drawing.Point(6, 31);
            this.txGroupBox1.Name = "txGroupBox1";
            this.txGroupBox1.Size = new System.Drawing.Size(744, 57);
            this.txGroupBox1.TabIndex = 5;
            this.txGroupBox1.TabStop = false;
            this.txGroupBox1.Text = "模板配置";
            this.txGroupBox1.TextMargin = 6;
            // 
            // t_btn_TemplateSava
            // 
            this.t_btn_TemplateSava.Image = null;
            this.t_btn_TemplateSava.Location = new System.Drawing.Point(689, 23);
            this.t_btn_TemplateSava.Name = "t_btn_TemplateSava";
            this.t_btn_TemplateSava.Size = new System.Drawing.Size(49, 21);
            this.t_btn_TemplateSava.TabIndex = 12;
            this.t_btn_TemplateSava.Text = "保存";
            this.t_btn_TemplateSava.UseVisualStyleBackColor = true;
            this.t_btn_TemplateSava.Click += new System.EventHandler(this.t_btn_TemplateSava_Click);
            // 
            // t_btn_ColorSelect
            // 
            this.t_btn_ColorSelect.Image = null;
            this.t_btn_ColorSelect.Location = new System.Drawing.Point(614, 23);
            this.t_btn_ColorSelect.Name = "t_btn_ColorSelect";
            this.t_btn_ColorSelect.Size = new System.Drawing.Size(49, 21);
            this.t_btn_ColorSelect.TabIndex = 11;
            this.t_btn_ColorSelect.Text = "选择";
            this.t_btn_ColorSelect.UseVisualStyleBackColor = true;
            this.t_btn_ColorSelect.Click += new System.EventHandler(this.t_btn_ColorSelect_Click);
            // 
            // t_txt_Color
            // 
            this.t_txt_Color.BackColor = System.Drawing.Color.Transparent;
            this.t_txt_Color.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.t_txt_Color.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t_txt_Color.ForeColor = System.Drawing.SystemColors.WindowText;
            this.t_txt_Color.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.t_txt_Color.Image = null;
            this.t_txt_Color.ImageSize = new System.Drawing.Size(0, 0);
            this.t_txt_Color.Location = new System.Drawing.Point(506, 22);
            this.t_txt_Color.Name = "t_txt_Color";
            this.t_txt_Color.Padding = new System.Windows.Forms.Padding(2);
            this.t_txt_Color.PasswordChar = '\0';
            this.t_txt_Color.ReadOnly = true;
            this.t_txt_Color.Required = false;
            this.t_txt_Color.Size = new System.Drawing.Size(102, 22);
            this.t_txt_Color.TabIndex = 10;
            // 
            // t_cmg_FontSize
            // 
            this.t_cmg_FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_cmg_FontSize.FormattingEnabled = true;
            this.t_cmg_FontSize.Items.AddRange(new object[] {
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
            "30"});
            this.t_cmg_FontSize.Location = new System.Drawing.Point(378, 23);
            this.t_cmg_FontSize.Name = "t_cmg_FontSize";
            this.t_cmg_FontSize.Size = new System.Drawing.Size(65, 20);
            this.t_cmg_FontSize.TabIndex = 9;
            // 
            // t_cmg_Font
            // 
            this.t_cmg_Font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_cmg_Font.FormattingEnabled = true;
            this.t_cmg_Font.Items.AddRange(new object[] {
            "宋体",
            "黑体",
            "楷体",
            "隶书",
            "微软雅黑"});
            this.t_cmg_Font.Location = new System.Drawing.Point(246, 23);
            this.t_cmg_Font.Name = "t_cmg_Font";
            this.t_cmg_Font.Size = new System.Drawing.Size(77, 20);
            this.t_cmg_Font.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "字体颜色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "字体大小";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "字体";
            // 
            // FrmPrintItemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 660);
            this.Controls.Add(this.txGroupBox1);
            this.Controls.Add(this.t_btn_SaveConfig);
            this.Controls.Add(this.t_btn_Preview);
            this.Controls.Add(this.t_cmg_);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPrintItemConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印项配置";
            this.Load += new System.EventHandler(this.FrmPrintItemConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_cmg_)).EndInit();
            this.txGroupBox1.ResumeLayout(false);
            this.txGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView t_cmg_;
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
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private TX.Framework.WindowUI.Controls.TXTextBox t_txt_Color;
        private TX.Framework.WindowUI.Controls.TXComboBox t_cmg_FontSize;
        private TX.Framework.WindowUI.Controls.TXComboBox t_cmg_Font;
        private TX.Framework.WindowUI.Controls.TXButton t_btn_ColorSelect;
        private TX.Framework.WindowUI.Controls.TXButton t_btn_TemplateSava;
    }
}