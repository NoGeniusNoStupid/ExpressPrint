namespace ShoesOrderPrint
{
    partial class FrmPrinterSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.txGroupBox1 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txComboBox2 = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.t_cmg_PrinterName = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txGroupBox2 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txTextBox2 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.txTextBox1 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txGroupBox3 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.t_btn_Detail = new TX.Framework.WindowUI.Controls.TXButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txTextBox6 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txTextBox4 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.txTextBox5 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.txTextBox3 = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txButton1 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton2 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.txGroupBox2.SuspendLayout();
            this.txGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "打印机名称";
            // 
            // txGroupBox1
            // 
            this.txGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox1.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox1.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox1.Controls.Add(this.numericUpDown1);
            this.txGroupBox1.Controls.Add(this.label3);
            this.txGroupBox1.Controls.Add(this.txComboBox2);
            this.txGroupBox1.Controls.Add(this.t_cmg_PrinterName);
            this.txGroupBox1.Controls.Add(this.label2);
            this.txGroupBox1.Controls.Add(this.label1);
            this.txGroupBox1.Location = new System.Drawing.Point(6, 30);
            this.txGroupBox1.Name = "txGroupBox1";
            this.txGroupBox1.Size = new System.Drawing.Size(676, 100);
            this.txGroupBox1.TabIndex = 1;
            this.txGroupBox1.TabStop = false;
            this.txGroupBox1.Text = "打印机";
            this.txGroupBox1.TextMargin = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(109, 70);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(144, 21);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "打印份数";
            // 
            // txComboBox2
            // 
            this.txComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txComboBox2.FormattingEnabled = true;
            this.txComboBox2.Items.AddRange(new object[] {
            "纵向",
            "横向"});
            this.txComboBox2.Location = new System.Drawing.Point(109, 44);
            this.txComboBox2.Name = "txComboBox2";
            this.txComboBox2.Size = new System.Drawing.Size(144, 20);
            this.txComboBox2.TabIndex = 3;
            // 
            // t_cmg_PrinterName
            // 
            this.t_cmg_PrinterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_cmg_PrinterName.FormattingEnabled = true;
            this.t_cmg_PrinterName.Location = new System.Drawing.Point(109, 16);
            this.t_cmg_PrinterName.Name = "t_cmg_PrinterName";
            this.t_cmg_PrinterName.Size = new System.Drawing.Size(144, 20);
            this.t_cmg_PrinterName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "打印方向";
            // 
            // txGroupBox2
            // 
            this.txGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox2.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox2.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox2.Controls.Add(this.label7);
            this.txGroupBox2.Controls.Add(this.label6);
            this.txGroupBox2.Controls.Add(this.txTextBox2);
            this.txGroupBox2.Controls.Add(this.txTextBox1);
            this.txGroupBox2.Controls.Add(this.label5);
            this.txGroupBox2.Controls.Add(this.label4);
            this.txGroupBox2.Location = new System.Drawing.Point(6, 136);
            this.txGroupBox2.Name = "txGroupBox2";
            this.txGroupBox2.Size = new System.Drawing.Size(211, 147);
            this.txGroupBox2.TabIndex = 2;
            this.txGroupBox2.TabStop = false;
            this.txGroupBox2.Text = "文字整体偏移";
            this.txGroupBox2.TextMargin = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "毫米";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "毫米";
            // 
            // txTextBox2
            // 
            this.txTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox2.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox2.Image = null;
            this.txTextBox2.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox2.Location = new System.Drawing.Point(73, 70);
            this.txTextBox2.Name = "txTextBox2";
            this.txTextBox2.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBox2.PasswordChar = '\0';
            this.txTextBox2.Required = false;
            this.txTextBox2.Size = new System.Drawing.Size(80, 22);
            this.txTextBox2.TabIndex = 8;
            this.txTextBox2.Text = "0";
            // 
            // txTextBox1
            // 
            this.txTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox1.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox1.Image = null;
            this.txTextBox1.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox1.Location = new System.Drawing.Point(73, 28);
            this.txTextBox1.Name = "txTextBox1";
            this.txTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBox1.PasswordChar = '\0';
            this.txTextBox1.Required = false;
            this.txTextBox1.Size = new System.Drawing.Size(80, 22);
            this.txTextBox1.TabIndex = 7;
            this.txTextBox1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "左右偏移";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "上下偏移";
            // 
            // txGroupBox3
            // 
            this.txGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox3.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox3.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox3.Controls.Add(this.label18);
            this.txGroupBox3.Controls.Add(this.t_btn_Detail);
            this.txGroupBox3.Controls.Add(this.label17);
            this.txGroupBox3.Controls.Add(this.label16);
            this.txGroupBox3.Controls.Add(this.label15);
            this.txGroupBox3.Controls.Add(this.label14);
            this.txGroupBox3.Controls.Add(this.txTextBox6);
            this.txGroupBox3.Controls.Add(this.label12);
            this.txGroupBox3.Controls.Add(this.label13);
            this.txGroupBox3.Controls.Add(this.txTextBox4);
            this.txGroupBox3.Controls.Add(this.txTextBox5);
            this.txGroupBox3.Controls.Add(this.txTextBox3);
            this.txGroupBox3.Controls.Add(this.label11);
            this.txGroupBox3.Controls.Add(this.label10);
            this.txGroupBox3.Controls.Add(this.label9);
            this.txGroupBox3.Controls.Add(this.label8);
            this.txGroupBox3.Location = new System.Drawing.Point(223, 136);
            this.txGroupBox3.Name = "txGroupBox3";
            this.txGroupBox3.Size = new System.Drawing.Size(459, 147);
            this.txGroupBox3.TabIndex = 3;
            this.txGroupBox3.TabStop = false;
            this.txGroupBox3.Text = "修正纸张大小";
            this.txGroupBox3.TextMargin = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Green;
            this.label18.Location = new System.Drawing.Point(70, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(179, 12);
            this.label18.TabIndex = 23;
            this.label18.Text = "注：0表示采用设计时的原始大小";
            // 
            // t_btn_Detail
            // 
            this.t_btn_Detail.Image = null;
            this.t_btn_Detail.Location = new System.Drawing.Point(347, 109);
            this.t_btn_Detail.Name = "t_btn_Detail";
            this.t_btn_Detail.Size = new System.Drawing.Size(100, 28);
            this.t_btn_Detail.TabIndex = 22;
            this.t_btn_Detail.Text = "详细说明";
            this.t_btn_Detail.UseVisualStyleBackColor = true;
            this.t_btn_Detail.Click += new System.EventHandler(this.t_btn_Detail_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(297, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 21;
            this.label17.Text = "宽度";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(94, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 20;
            this.label16.Text = "宽度";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(297, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 19;
            this.label15.Text = "高度";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(94, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 18;
            this.label14.Text = "宽度";
            // 
            // txTextBox6
            // 
            this.txTextBox6.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox6.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox6.Image = null;
            this.txTextBox6.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox6.Location = new System.Drawing.Point(129, 65);
            this.txTextBox6.Name = "txTextBox6";
            this.txTextBox6.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBox6.PasswordChar = '\0';
            this.txTextBox6.Required = false;
            this.txTextBox6.Size = new System.Drawing.Size(80, 22);
            this.txTextBox6.TabIndex = 17;
            this.txTextBox6.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "毫米";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(418, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "毫米";
            // 
            // txTextBox4
            // 
            this.txTextBox4.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox4.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox4.Image = null;
            this.txTextBox4.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox4.Location = new System.Drawing.Point(332, 67);
            this.txTextBox4.Name = "txTextBox4";
            this.txTextBox4.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBox4.PasswordChar = '\0';
            this.txTextBox4.Required = false;
            this.txTextBox4.Size = new System.Drawing.Size(80, 22);
            this.txTextBox4.TabIndex = 14;
            this.txTextBox4.Text = "0";
            // 
            // txTextBox5
            // 
            this.txTextBox5.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox5.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox5.Image = null;
            this.txTextBox5.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox5.Location = new System.Drawing.Point(332, 25);
            this.txTextBox5.Name = "txTextBox5";
            this.txTextBox5.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBox5.PasswordChar = '\0';
            this.txTextBox5.Required = false;
            this.txTextBox5.Size = new System.Drawing.Size(80, 22);
            this.txTextBox5.TabIndex = 13;
            // 
            // txTextBox3
            // 
            this.txTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.txTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTextBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTextBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txTextBox3.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTextBox3.Image = null;
            this.txTextBox3.ImageSize = new System.Drawing.Size(0, 0);
            this.txTextBox3.Location = new System.Drawing.Point(129, 28);
            this.txTextBox3.Name = "txTextBox3";
            this.txTextBox3.Padding = new System.Windows.Forms.Padding(2);
            this.txTextBox3.PasswordChar = '\0';
            this.txTextBox3.Required = false;
            this.txTextBox3.Size = new System.Drawing.Size(80, 22);
            this.txTextBox3.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "毫米";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "毫米";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "修正大小";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "原始大小";
            // 
            // txButton1
            // 
            this.txButton1.Image = null;
            this.txButton1.Location = new System.Drawing.Point(472, 298);
            this.txButton1.Name = "txButton1";
            this.txButton1.Size = new System.Drawing.Size(100, 28);
            this.txButton1.TabIndex = 4;
            this.txButton1.Text = "保存";
            this.txButton1.UseVisualStyleBackColor = true;
            // 
            // txButton2
            // 
            this.txButton2.Image = null;
            this.txButton2.Location = new System.Drawing.Point(578, 298);
            this.txButton2.Name = "txButton2";
            this.txButton2.Size = new System.Drawing.Size(100, 28);
            this.txButton2.TabIndex = 5;
            this.txButton2.Text = "取消";
            this.txButton2.UseVisualStyleBackColor = true;
            // 
            // FrmPrinterSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 332);
            this.Controls.Add(this.txButton2);
            this.Controls.Add(this.txButton1);
            this.Controls.Add(this.txGroupBox3);
            this.Controls.Add(this.txGroupBox2);
            this.Controls.Add(this.txGroupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmPrinterSetting";
            this.Text = "打印机设置";
            this.Load += new System.EventHandler(this.FrmPrinterSetting_Load);
            this.txGroupBox1.ResumeLayout(false);
            this.txGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.txGroupBox2.ResumeLayout(false);
            this.txGroupBox2.PerformLayout();
            this.txGroupBox3.ResumeLayout(false);
            this.txGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private TX.Framework.WindowUI.Controls.TXComboBox txComboBox2;
        private TX.Framework.WindowUI.Controls.TXComboBox t_cmg_PrinterName;
        private System.Windows.Forms.Label label2;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox2;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox3;
        private TX.Framework.WindowUI.Controls.TXButton txButton1;
        private TX.Framework.WindowUI.Controls.TXButton txButton2;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox2;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox4;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox5;
        private TX.Framework.WindowUI.Controls.TXTextBox txTextBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private TX.Framework.WindowUI.Controls.TXButton t_btn_Detail;
        private System.Windows.Forms.Label label18;
    }
}