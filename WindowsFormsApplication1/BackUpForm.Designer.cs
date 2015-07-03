namespace WindowsFormsApplication1 {
    partial class BackUpForm {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUpForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.main_button_Save = new System.Windows.Forms.Button();
            this.main_button_Exit = new System.Windows.Forms.Button();
            this.main_button_RecoverData = new System.Windows.Forms.Button();
            this.main_button_BackUpSetting = new System.Windows.Forms.Button();
            this.main_panel_BackUpSetting = new System.Windows.Forms.Panel();
            this.main_comboBox_weekly = new System.Windows.Forms.ComboBox();
            this.main_comboBox_monthly = new System.Windows.Forms.ComboBox();
            this.main_dateTimePicker_daily = new System.Windows.Forms.DateTimePicker();
            this.main_radioButton_unused = new System.Windows.Forms.RadioButton();
            this.main_radioButton_monthly = new System.Windows.Forms.RadioButton();
            this.main_radioButton_weekly = new System.Windows.Forms.RadioButton();
            this.main_radioButton_daily = new System.Windows.Forms.RadioButton();
            this.main_panel_RecoverData = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.main_panel_BackUpSetting.SuspendLayout();
            this.main_panel_RecoverData.SuspendLayout();
            this.IconStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.main_button_Save);
            this.splitContainer1.Panel1.Controls.Add(this.main_button_Exit);
            this.splitContainer1.Panel1.Controls.Add(this.main_button_RecoverData);
            this.splitContainer1.Panel1.Controls.Add(this.main_button_BackUpSetting);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.main_panel_BackUpSetting);
            this.splitContainer1.Panel2.Controls.Add(this.main_panel_RecoverData);
            this.splitContainer1.Size = new System.Drawing.Size(1333, 578);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // main_button_Save
            // 
            this.main_button_Save.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_button_Save.Location = new System.Drawing.Point(20, 224);
            this.main_button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.main_button_Save.Name = "main_button_Save";
            this.main_button_Save.Size = new System.Drawing.Size(104, 44);
            this.main_button_Save.TabIndex = 3;
            this.main_button_Save.Text = "確定";
            this.main_button_Save.UseVisualStyleBackColor = true;
            this.main_button_Save.Click += new System.EventHandler(this.main_button_Save_Click);
            // 
            // main_button_Exit
            // 
            this.main_button_Exit.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_button_Exit.Location = new System.Drawing.Point(20, 303);
            this.main_button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.main_button_Exit.Name = "main_button_Exit";
            this.main_button_Exit.Size = new System.Drawing.Size(104, 44);
            this.main_button_Exit.TabIndex = 2;
            this.main_button_Exit.Text = "關閉程式";
            this.main_button_Exit.UseVisualStyleBackColor = true;
            this.main_button_Exit.Click += new System.EventHandler(this.main_button_Exit_Click);
            // 
            // main_button_RecoverData
            // 
            this.main_button_RecoverData.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_button_RecoverData.Location = new System.Drawing.Point(20, 98);
            this.main_button_RecoverData.Margin = new System.Windows.Forms.Padding(2);
            this.main_button_RecoverData.Name = "main_button_RecoverData";
            this.main_button_RecoverData.Size = new System.Drawing.Size(104, 44);
            this.main_button_RecoverData.TabIndex = 1;
            this.main_button_RecoverData.Text = "還原檔案";
            this.main_button_RecoverData.UseVisualStyleBackColor = true;
            this.main_button_RecoverData.Click += new System.EventHandler(this.button2_Click);
            // 
            // main_button_BackUpSetting
            // 
            this.main_button_BackUpSetting.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_button_BackUpSetting.Location = new System.Drawing.Point(20, 22);
            this.main_button_BackUpSetting.Margin = new System.Windows.Forms.Padding(2);
            this.main_button_BackUpSetting.Name = "main_button_BackUpSetting";
            this.main_button_BackUpSetting.Size = new System.Drawing.Size(104, 44);
            this.main_button_BackUpSetting.TabIndex = 0;
            this.main_button_BackUpSetting.Text = "備份設定";
            this.main_button_BackUpSetting.UseVisualStyleBackColor = true;
            this.main_button_BackUpSetting.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_panel_BackUpSetting
            // 
            this.main_panel_BackUpSetting.Controls.Add(this.main_comboBox_weekly);
            this.main_panel_BackUpSetting.Controls.Add(this.main_comboBox_monthly);
            this.main_panel_BackUpSetting.Controls.Add(this.main_dateTimePicker_daily);
            this.main_panel_BackUpSetting.Controls.Add(this.main_radioButton_unused);
            this.main_panel_BackUpSetting.Controls.Add(this.main_radioButton_monthly);
            this.main_panel_BackUpSetting.Controls.Add(this.main_radioButton_weekly);
            this.main_panel_BackUpSetting.Controls.Add(this.main_radioButton_daily);

            this.main_panel_BackUpSetting.Location = new System.Drawing.Point(0, 0);

            this.main_panel_BackUpSetting.Location = new System.Drawing.Point(712, 116);

            this.main_panel_BackUpSetting.Margin = new System.Windows.Forms.Padding(2);
            this.main_panel_BackUpSetting.Name = "main_panel_BackUpSetting";
            this.main_panel_BackUpSetting.Size = new System.Drawing.Size(514, 378);
            this.main_panel_BackUpSetting.TabIndex = 0;
            // 
            // main_comboBox_weekly
            // 
            this.main_comboBox_weekly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.main_comboBox_weekly.Enabled = false;
            this.main_comboBox_weekly.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_comboBox_weekly.FormattingEnabled = true;
            this.main_comboBox_weekly.Items.AddRange(new object[] {
            "一",
            "二",
            "三",
            "四",
            "五",
            "六",
            "日"});
            this.main_comboBox_weekly.Location = new System.Drawing.Point(209, 71);
            this.main_comboBox_weekly.Margin = new System.Windows.Forms.Padding(2);
            this.main_comboBox_weekly.Name = "main_comboBox_weekly";
            this.main_comboBox_weekly.Size = new System.Drawing.Size(92, 26);
            this.main_comboBox_weekly.TabIndex = 5;
            // 
            // main_comboBox_monthly
            // 
            this.main_comboBox_monthly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.main_comboBox_monthly.Enabled = false;
            this.main_comboBox_monthly.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_comboBox_monthly.FormattingEnabled = true;
            this.main_comboBox_monthly.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.main_comboBox_monthly.Location = new System.Drawing.Point(209, 117);
            this.main_comboBox_monthly.Margin = new System.Windows.Forms.Padding(2);
            this.main_comboBox_monthly.Name = "main_comboBox_monthly";
            this.main_comboBox_monthly.Size = new System.Drawing.Size(92, 26);
            this.main_comboBox_monthly.TabIndex = 4;
            // 
            // main_dateTimePicker_daily
            // 
            this.main_dateTimePicker_daily.CustomFormat = " HH點 mm 分 ";
            this.main_dateTimePicker_daily.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_dateTimePicker_daily.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.main_dateTimePicker_daily.Location = new System.Drawing.Point(192, 25);
            this.main_dateTimePicker_daily.Margin = new System.Windows.Forms.Padding(2);
            this.main_dateTimePicker_daily.Name = "main_dateTimePicker_daily";
            this.main_dateTimePicker_daily.ShowUpDown = true;
            this.main_dateTimePicker_daily.Size = new System.Drawing.Size(109, 30);
            this.main_dateTimePicker_daily.TabIndex = 3;
            this.main_dateTimePicker_daily.Value = new System.DateTime(2015, 7, 2, 0, 0, 0, 0);
            // 
            // main_radioButton_unused
            // 
            this.main_radioButton_unused.AutoSize = true;
            this.main_radioButton_unused.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_radioButton_unused.Location = new System.Drawing.Point(33, 164);
            this.main_radioButton_unused.Margin = new System.Windows.Forms.Padding(2);
            this.main_radioButton_unused.Name = "main_radioButton_unused";
            this.main_radioButton_unused.Size = new System.Drawing.Size(84, 23);
            this.main_radioButton_unused.TabIndex = 6;
            this.main_radioButton_unused.TabStop = true;
            this.main_radioButton_unused.Text = "不使用";
            this.main_radioButton_unused.UseVisualStyleBackColor = true;
            this.main_radioButton_unused.CheckedChanged += new System.EventHandler(this.main_radioButton_unused_CheckedChanged);
            // 
            // main_radioButton_monthly
            // 
            this.main_radioButton_monthly.AutoSize = true;
            this.main_radioButton_monthly.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_radioButton_monthly.Location = new System.Drawing.Point(33, 119);
            this.main_radioButton_monthly.Margin = new System.Windows.Forms.Padding(2);
            this.main_radioButton_monthly.Name = "main_radioButton_monthly";
            this.main_radioButton_monthly.Size = new System.Drawing.Size(65, 23);
            this.main_radioButton_monthly.TabIndex = 2;
            this.main_radioButton_monthly.TabStop = true;
            this.main_radioButton_monthly.Text = "每月";
            this.main_radioButton_monthly.UseVisualStyleBackColor = true;
            this.main_radioButton_monthly.CheckedChanged += new System.EventHandler(this.main_radioButton_monthly_CheckedChanged);
            // 
            // main_radioButton_weekly
            // 
            this.main_radioButton_weekly.AutoSize = true;
            this.main_radioButton_weekly.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_radioButton_weekly.Location = new System.Drawing.Point(33, 74);
            this.main_radioButton_weekly.Margin = new System.Windows.Forms.Padding(2);
            this.main_radioButton_weekly.Name = "main_radioButton_weekly";
            this.main_radioButton_weekly.Size = new System.Drawing.Size(65, 23);
            this.main_radioButton_weekly.TabIndex = 1;
            this.main_radioButton_weekly.TabStop = true;
            this.main_radioButton_weekly.Text = "每週";
            this.main_radioButton_weekly.UseVisualStyleBackColor = true;
            this.main_radioButton_weekly.CheckedChanged += new System.EventHandler(this.main_radioButton_weekly_CheckedChanged);
            // 
            // main_radioButton_daily
            // 
            this.main_radioButton_daily.AutoSize = true;
            this.main_radioButton_daily.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.main_radioButton_daily.Location = new System.Drawing.Point(33, 30);
            this.main_radioButton_daily.Margin = new System.Windows.Forms.Padding(2);
            this.main_radioButton_daily.Name = "main_radioButton_daily";
            this.main_radioButton_daily.Size = new System.Drawing.Size(65, 23);
            this.main_radioButton_daily.TabIndex = 0;
            this.main_radioButton_daily.TabStop = true;
            this.main_radioButton_daily.Text = "每日";
            this.main_radioButton_daily.UseVisualStyleBackColor = true;
            this.main_radioButton_daily.CheckedChanged += new System.EventHandler(this.main_radioButton_daily_CheckedChanged);
            // 
            // main_panel_RecoverData
            // 

            this.main_panel_RecoverData.Location = new System.Drawing.Point(0, 0);

            this.main_panel_RecoverData.Controls.Add(this.textBox1);
            this.main_panel_RecoverData.Controls.Add(this.button1);
            this.main_panel_RecoverData.Controls.Add(this.listView1);
            this.main_panel_RecoverData.Location = new System.Drawing.Point(-1, 0);

            this.main_panel_RecoverData.Margin = new System.Windows.Forms.Padding(2);
            this.main_panel_RecoverData.Name = "main_panel_RecoverData";
            this.main_panel_RecoverData.Size = new System.Drawing.Size(514, 378);
            this.main_panel_RecoverData.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_return);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(13, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(486, 305);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Icon
            // 
            this.Icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Icon.BalloonTipText = "程式並未結束。";
            this.Icon.BalloonTipTitle = "BackUp常駐中";
            this.Icon.ContextMenuStrip = this.IconStrip;
            this.Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("Icon.Icon")));
            this.Icon.Text = "BackUp程式";
            this.Icon.Visible = true;
            this.Icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // IconStrip
            // 
            this.IconStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.結束ToolStripMenuItem});
            this.IconStrip.Name = "IconStrip";
            this.IconStrip.Size = new System.Drawing.Size(123, 26);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.結束ToolStripMenuItem.Text = "結束程式";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 578);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BackUpForm";
            this.Text = "BackUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.main_panel_BackUpSetting.ResumeLayout(false);
            this.main_panel_BackUpSetting.PerformLayout();
            this.main_panel_RecoverData.ResumeLayout(false);
            this.main_panel_RecoverData.PerformLayout();
            this.IconStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button main_button_RecoverData;
        private System.Windows.Forms.Button main_button_BackUpSetting;
        private System.Windows.Forms.Panel main_panel_RecoverData;
        private System.Windows.Forms.Panel main_panel_BackUpSetting;
        private System.Windows.Forms.RadioButton main_radioButton_daily;
        private System.Windows.Forms.RadioButton main_radioButton_monthly;
        private System.Windows.Forms.RadioButton main_radioButton_weekly;
        private System.Windows.Forms.DateTimePicker main_dateTimePicker_daily;
        private System.Windows.Forms.ComboBox main_comboBox_monthly;
        private System.Windows.Forms.ComboBox main_comboBox_weekly;
        private System.Windows.Forms.RadioButton main_radioButton_unused;
        private System.Windows.Forms.NotifyIcon Icon;
        private System.Windows.Forms.ContextMenuStrip IconStrip;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.Button main_button_Exit;
        private System.Windows.Forms.Button main_button_Save;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

