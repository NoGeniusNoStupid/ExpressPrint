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
            this.t_num_PrintNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.t_cmg_PrintForward = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.t_cmg_PrinterName = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txGroupBox2 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t_txt_LeftAway = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.t_txt_TopAway = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txGroupBox3 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.t_btn_Detail = new TX.Framework.WindowUI.Controls.TXButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.t_txt_NowWeight = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.t_txt_NowHeight = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.t_txt_IniHeight = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.t_txt_IniWeight = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t_btn_Save = new TX.Framework.WindowUI.Controls.TXButton();
            this.t_btn_Cancel = new TX.Framework.WindowUI.Controls.TXButton();
            this.txGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_num_PrintNum)).BeginInit();
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
            this.txGroupBox1.Controls.Add(this.t_num_PrintNum);
            this.txGroupBox1.Controls.Add(this.label3);
            this.txGroupBox1.Controls.Add(this.t_cmg_PrintForward);
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
            // t_num_PrintNum
            // 
            this.t_num_PrintNum.Location = new System.Drawing.Point(109, 70);
            this.t_num_PrintNum.Name = "t_num_PrintNum";
            this.t_num_PrintNum.Size = new System.Drawing.Size(144, 21);
            this.t_num_PrintNum.TabIndex = 3;
            this.t_num_PrintNum.Value = new decimal(new int[] {
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
            // t_cmg_PrintForward
            // 
            this.t_cmg_PrintForward.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_cmg_PrintForward.FormattingEnabled = true;
            this.t_cmg_PrintForward.Items.AddRange(new object[] {
            "纵向",
            "横向"});
            this.t_cmg_PrintForward.Location = new System.Drawing.Point(109, 44);
            this.t_cmg_PrintForward.Name = "t_cmg_PrintForward";
            this.t_cmg_PrintForward.Size = new System.Drawing.Size(144, 20);
            this.t_cmg_PrintForward.TabIndex = 2;
            // 
            // t_cmg_PrinterName
            // 
            this.t_cmg_PrinterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_cmg_PrinterName.FormattingEnabled = true;
            this.t_cmg_PrinterName.Location = new System.Drawing.Point(109, 16);
            this.t_cmg_PrinterName.Name = "t_cmg_PrinterName";
            this.t_cmg_PrinterName.Size = new System.Drawing.Size(144, 20);
            this.t_cmg_PrinterName.TabIndex = 1;
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
            this.txGroupBox2.Controls.Add(this.t_txt_LeftAway);
            this.txGroupBox2.Controls.Add(this.t_txt_TopAway);
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
            // t_txt_LeftAway
            // 
            this.t_txt_LeftAway.BackColor = System.Drawing.Color.Transparent;
            this.t_txt_LeftAway.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.t_txt_LeftAway.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t_txt_LeftAway.ForeColor = System.Drawing.SystemColors.WindowText;
            this.t_txt_LeftAway.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.t_txt_LeftAway.Image = null;
            this.t_txt_LeftAway.ImageSize = new System.Drawing.Size(0, 0);
            this.t_txt_LeftAway.Location = new System.Drawing.Point(73, 70);
            this.t_txt_LeftAway.Name = "t_txt_LeftAway";
            this.t_txt_LeftAway.Padding = new System.Windows.Forms.Padding(2);
            this.t_txt_LeftAway.PasswordChar = '\0';
            this.t_txt_LeftAway.Required = false;
            this.t_txt_LeftAway.Size = new System.Drawing.Size(80, 22);
            this.t_txt_LeftAway.TabIndex = 2;
            this.t_txt_LeftAway.Text = "0";
            this.t_txt_LeftAway.Leave += new System.EventHandler(this.t_txt_TopAway_Leave);
            // 
            // t_txt_TopAway
            // 
            this.t_txt_TopAway.BackColor = System.Drawing.Color.Transparent;
            this.t_txt_TopAway.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.t_txt_TopAway.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t_txt_TopAway.ForeColor = System.Drawing.SystemColors.WindowText;
            this.t_txt_TopAway.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.t_txt_TopAway.Image = null;
            this.t_txt_TopAway.ImageSize = new System.Drawing.Size(0, 0);
            this.t_txt_TopAway.Location = new System.Drawing.Point(73, 28);
            this.t_txt_TopAway.Name = "t_txt_TopAway";
            this.t_txt_TopAway.Padding = new System.Windows.Forms.Padding(2);
            this.t_txt_TopAway.PasswordChar = '\0';
            this.t_txt_TopAway.Required = false;
            this.t_txt_TopAway.Size = new System.Drawing.Size(80, 22);
            this.t_txt_TopAway.TabIndex = 1;
            this.t_txt_TopAway.Text = "0";
            this.t_txt_TopAway.Leave += new System.EventHandler(this.t_txt_TopAway_Leave);
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
            this.txGroupBox3.Controls.Add(this.t_txt_NowWeight);
            this.txGroupBox3.Controls.Add(this.label12);
            this.txGroupBox3.Controls.Add(this.label13);
            this.txGroupBox3.Controls.Add(this.t_txt_NowHeight);
            this.txGroupBox3.Controls.Add(this.t_txt_IniHeight);
            this.txGroupBox3.Controls.Add(this.t_txt_IniWeight);
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
            // t_txt_NowWeight
            // 
            this.t_txt_NowWeight.BackColor = System.Drawing.Color.Transparent;
            this.t_txt_NowWeight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.t_txt_NowWeight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t_txt_NowWeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.t_txt_NowWeight.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.t_txt_NowWeight.Image = null;
            this.t_txt_NowWeight.ImageSize = new System.Drawing.Size(0, 0);
            this.t_txt_NowWeight.Location = new System.Drawing.Point(129, 65);
            this.t_txt_NowWeight.Name = "t_txt_NowWeight";
            this.t_txt_NowWeight.Padding = new System.Windows.Forms.Padding(2);
            this.t_txt_NowWeight.PasswordChar = '\0';
            this.t_txt_NowWeight.Required = false;
            this.t_txt_NowWeight.Size = new System.Drawing.Size(80, 22);
            this.t_txt_NowWeight.TabIndex = 3;
            this.t_txt_NowWeight.Text = "0";
            this.t_txt_NowWeight.Leave += new System.EventHandler(this.t_txt_TopAway_Leave);
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
            // t_txt_NowHeight
            // 
            this.t_txt_NowHeight.BackColor = System.Drawing.Color.Transparent;
            this.t_txt_NowHeight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.t_txt_NowHeight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t_txt_NowHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.t_txt_NowHeight.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.t_txt_NowHeight.Image = null;
            this.t_txt_NowHeight.ImageSize = new System.Drawing.Size(0, 0);
            this.t_txt_NowHeight.Location = new System.Drawing.Point(332, 67);
            this.t_txt_NowHeight.Name = "t_txt_NowHeight";
            this.t_txt_NowHeight.Padding = new System.Windows.Forms.Padding(2);
            this.t_txt_NowHeight.PasswordChar = '\0';
            this.t_txt_NowHeight.Required = false;
            this.t_txt_NowHeight.Size = new System.Drawing.Size(80, 22);
            this.t_txt_NowHeight.TabIndex = 4;
            this.t_txt_NowHeight.Text = "0";
            this.t_txt_NowHeight.Leave += new System.EventHandler(this.t_txt_TopAway_Leave);
            // 
            // t_txt_IniHeight
            // 
            this.t_txt_IniHeight.BackColor = System.Drawing.Color.Transparent;
            this.t_txt_IniHeight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.t_txt_IniHeight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t_txt_IniHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.t_txt_IniHeight.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.t_txt_IniHeight.Image = null;
            this.t_txt_IniHeight.ImageSize = new System.Drawing.Size(0, 0);
            this.t_txt_IniHeight.Location = new System.Drawing.Point(332, 25);
            this.t_txt_IniHeight.Name = "t_txt_IniHeight";
            this.t_txt_IniHeight.Padding = new System.Windows.Forms.Padding(2);
            this.t_txt_IniHeight.PasswordChar = '\0';
            this.t_txt_IniHeight.ReadOnly = true;
            this.t_txt_IniHeight.Required = false;
            this.t_txt_IniHeight.Size = new System.Drawing.Size(80, 22);
            this.t_txt_IniHeight.TabIndex = 2;
            this.t_txt_IniHeight.Text = "0";
            // 
            // t_txt_IniWeight
            // 
            this.t_txt_IniWeight.BackColor = System.Drawing.Color.Transparent;
            this.t_txt_IniWeight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.t_txt_IniWeight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t_txt_IniWeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.t_txt_IniWeight.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.t_txt_IniWeight.Image = null;
            this.t_txt_IniWeight.ImageSize = new System.Drawing.Size(0, 0);
            this.t_txt_IniWeight.Location = new System.Drawing.Point(129, 28);
            this.t_txt_IniWeight.Name = "t_txt_IniWeight";
            this.t_txt_IniWeight.Padding = new System.Windows.Forms.Padding(2);
            this.t_txt_IniWeight.PasswordChar = '\0';
            this.t_txt_IniWeight.ReadOnly = true;
            this.t_txt_IniWeight.Required = false;
            this.t_txt_IniWeight.Size = new System.Drawing.Size(80, 22);
            this.t_txt_IniWeight.TabIndex = 1;
            this.t_txt_IniWeight.Text = "0";
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
            // t_btn_Save
            // 
            this.t_btn_Save.Image = null;
            this.t_btn_Save.Location = new System.Drawing.Point(472, 298);
            this.t_btn_Save.Name = "t_btn_Save";
            this.t_btn_Save.Size = new System.Drawing.Size(100, 28);
            this.t_btn_Save.TabIndex = 4;
            this.t_btn_Save.Text = "确定";
            this.t_btn_Save.UseVisualStyleBackColor = true;
            this.t_btn_Save.Click += new System.EventHandler(this.t_btn_Save_Click);
            // 
            // t_btn_Cancel
            // 
            this.t_btn_Cancel.Image = null;
            this.t_btn_Cancel.Location = new System.Drawing.Point(578, 298);
            this.t_btn_Cancel.Name = "t_btn_Cancel";
            this.t_btn_Cancel.Size = new System.Drawing.Size(100, 28);
            this.t_btn_Cancel.TabIndex = 5;
            this.t_btn_Cancel.Text = "取消";
            this.t_btn_Cancel.UseVisualStyleBackColor = true;
            this.t_btn_Cancel.Click += new System.EventHandler(this.t_btn_Cancel_Click);
            // 
            // FrmPrinterSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 332);
            this.Controls.Add(this.t_btn_Cancel);
            this.Controls.Add(this.t_btn_Save);
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
            ((System.ComponentModel.ISupportInitialize)(this.t_num_PrintNum)).EndInit();
            this.txGroupBox2.ResumeLayout(false);
            this.txGroupBox2.PerformLayout();
            this.txGroupBox3.ResumeLayout(false);
            this.txGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox1;
        private System.Windows.Forms.NumericUpDown t_num_PrintNum;
        private System.Windows.Forms.Label label3;
        private TX.Framework.WindowUI.Controls.TXComboBox t_cmg_PrintForward;
        private TX.Framework.WindowUI.Controls.TXComboBox t_cmg_PrinterName;
        private System.Windows.Forms.Label label2;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox2;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox3;
        private TX.Framework.WindowUI.Controls.TXButton t_btn_Save;
        private TX.Framework.WindowUI.Controls.TXButton t_btn_Cancel;
        private TX.Framework.WindowUI.Controls.TXTextBox t_txt_LeftAway;
        private TX.Framework.WindowUI.Controls.TXTextBox t_txt_TopAway;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private TX.Framework.WindowUI.Controls.TXTextBox t_txt_NowWeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private TX.Framework.WindowUI.Controls.TXTextBox t_txt_NowHeight;
        private TX.Framework.WindowUI.Controls.TXTextBox t_txt_IniHeight;
        private TX.Framework.WindowUI.Controls.TXTextBox t_txt_IniWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private TX.Framework.WindowUI.Controls.TXButton t_btn_Detail;
        private System.Windows.Forms.Label label18;
    }
}