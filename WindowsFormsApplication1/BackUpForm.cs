using System;
using System.Globalization;
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
        internal long targetTime = -1;
        private DateTime nextTime;

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

        private void main_radioButton_daily_CheckedChanged(object sender, EventArgs e) {
            main_comboBox_monthly.Enabled = false;
            main_comboBox_weekly.Enabled = false;
            main_dateTimePicker_daily.Enabled = true;
        }

        private void main_radioButton_weekly_CheckedChanged(object sender, EventArgs e) {
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

        private void main_button_Save_Click(object sender, EventArgs e) {
            if (main_radioButton_daily.Checked) {
                targetTime = refreshDaily();
            } else if (main_radioButton_weekly.Checked) {
                targetTime = refreshWeekly();
            } else if (main_radioButton_monthly.Checked) {
                targetTime = refreshMonthly();
            }



            //this.Hide();
            //Icon.ShowBalloonTip(3000);
        }

        private long refreshMonthly() {
            string hour = main_dateTimePicker_daily.Text.Substring(1, 2);
            string minute = main_dateTimePicker_daily.Text.Substring(4, 4);
            int hourInt = Convert.ToInt32(hour);
            int minuteInt = Convert.ToInt32(minute);

            DateTime nextTempTime = DateTime.Now.AddMonths(1);
            string nextTimeFormat = nextTempTime.Year.ToString() + " " + nextTempTime.Month.ToString() + " " + main_comboBox_monthly.Text;
            nextTime = DateTime.ParseExact(nextTimeFormat, "yyyy M d", CultureInfo.InvariantCulture);
            TimeSpan nextTimeSpan = nextTime - DateTime.Now;
            return (long)nextTimeSpan.TotalSeconds + deSecond(hourInt, minuteInt, 0, 0);
        }

        private long refreshWeekly() {
            DayOfWeek weekDay = DateTime.Now.DayOfWeek;
            DateTime targetWeekDay;

            if (main_comboBox_weekly.Text.Equals("一")) {
                weekDay = DayOfWeek.Monday;
            } else if (main_comboBox_weekly.Text.Equals("二")) {
                weekDay = DayOfWeek.Tuesday;
            } else if (main_comboBox_weekly.Text.Equals("三")) {
                weekDay = DayOfWeek.Wednesday;
            } else if (main_comboBox_weekly.Text.Equals("四")) {
                weekDay = DayOfWeek.Tuesday;
            } else if (main_comboBox_weekly.Text.Equals("五")) {
                weekDay = DayOfWeek.Friday;
            } else if (main_comboBox_weekly.Text.Equals("六")) {
                weekDay = DayOfWeek.Saturday;
            } else if (main_comboBox_weekly.Text.Equals("日")) {
                weekDay = DayOfWeek.Sunday;
            }

            if (weekDay > DateTime.Now.DayOfWeek) {
                targetWeekDay = getWeekUpOfDate(DateTime.Now, weekDay, 0);
            } else {
                targetWeekDay = getWeekUpOfDate(DateTime.Now, weekDay, 1);
            }

            string hour = main_dateTimePicker_daily.Text.Substring(1, 2);
            string minute = main_dateTimePicker_daily.Text.Substring(4, 4);
            int hourInt = Convert.ToInt32(hour);
            int minuteInt = Convert.ToInt32(minute);

            TimeSpan nextTimeSpan = targetWeekDay - DateTime.Now;
            MessageBox.Show(Convert.ToString((long)nextTimeSpan.TotalSeconds + deSecond(hourInt, minuteInt, Convert.ToInt32(DateTime.Now.Hour), Convert.ToInt32(DateTime.Now.Minute))));
            return (long)nextTimeSpan.TotalSeconds + deSecond(hourInt, minuteInt, 0, 0);
        }

        private long refreshDaily() {
            string hour = main_dateTimePicker_daily.Text.Substring(1, 2);
            string minute = main_dateTimePicker_daily.Text.Substring(4, 4);

            int hourInt = Convert.ToInt32(hour);
            int minuteInt = Convert.ToInt32(minute);
            return deSecond(hourInt, minuteInt, Convert.ToInt32(DateTime.Now.Hour), Convert.ToInt32(DateTime.Now.Minute));
        }

        private long deSecond(int hourInt, int minuteInt, int nowHour, int nowMinute) {
            long targetSecond = Math.Abs(((hourInt * 60 + minuteInt) - (nowHour * 60 + nowMinute))) * 60;
            return targetSecond;
        }

        private DateTime getWeekUpOfDate(DateTime dt, DayOfWeek weekday, int Number) {
            int wd1 = (int)weekday;
            int wd2 = (int)dt.DayOfWeek;
            return wd2 == wd1 ? dt.AddDays(7 * Number) : dt.AddDays(7 * Number - wd2 + wd1);
        }

    }
}
