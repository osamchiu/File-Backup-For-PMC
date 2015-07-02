using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class BackUpForm : Form {
        public BackUpForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            main_panel_BackUpSetting.Show();
            main_panel_RecoverData.Hide();
        }

        private void button2_Click(object sender, EventArgs e) {
            main_panel_BackUpSetting.Hide();
            main_panel_RecoverData.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            main_comboBox_monthly.Enabled = false;
            main_comboBox_weekly.Enabled = false;
            main_dateTimePicker_daily.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            main_comboBox_weekly.Enabled = true;
            main_comboBox_monthly.Enabled = false;
            main_dateTimePicker_daily.Enabled = true;
        }

        private void main_radioButton_monthly_CheckedChanged(object sender, EventArgs e) {
            main_comboBox_weekly.Enabled = false;
            main_comboBox_monthly.Enabled = true;
            main_dateTimePicker_daily.Enabled = true;
        }

        private void main_radioButton_unused_CheckedChanged(object sender, EventArgs e) {
            main_comboBox_weekly.Enabled = false;
            main_comboBox_monthly.Enabled = false;
            main_dateTimePicker_daily.Enabled = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            Icon.ShowBalloonTip(3000);
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e) {
            Environment.Exit(Environment.ExitCode);
        }

        private void main_button_Exit_Click(object sender, EventArgs e) {
            Environment.Exit(Environment.ExitCode);
        }





    }
}
