using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1 {
    public partial class BackUpForm : Form {
        private long targetTime;
        string fileName = "test.txt";
        string sourcePath = @"D:\Data_BackUp";
        string targetPath = @"D:\Data_BackUp\target";
        string tablePath = @"D:\Data_BackUp\table";
        
        public BackUpForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            main_panel_BackUpSetting.Show();
            main_panel_RecoverData.Hide();

            /***************************************************************/
            //test copy
            string sourefile = Path.Combine(sourcePath, fileName);
            string targetfile = Path.Combine(targetPath, fileName);
            string tablefile = Path.Combine(tablePath, fileName);
            
            if (!Directory.Exists(tablePath))
            {
                Directory.CreateDirectory(tablePath);
            }

            StreamWriter tableWriter = new StreamWriter(tablefile, true);

            if (!Directory.Exists(sourcePath))
            {
                Console.WriteLine("sourcePath dosen't exist!");
            }

            if (!Directory.Exists(targetPath))
            {
                try
                {
                    Directory.CreateDirectory(targetPath);
                }
                catch { }
            }

            try
            {
                File.Copy(sourefile, targetfile, true);
                tableWriter.Write(DateTime.Now.ToString("yyyy/MM/dd ddd HH:mm:ss"));
                tableWriter.Write(" ");
                tableWriter.WriteLine(fileName);
            }
            catch { }

            tableWriter.Close();
            listView1.Clear();
            /***************************************************************/

        }

        private void button2_Click(object sender, EventArgs e) {
            main_panel_BackUpSetting.Hide();
            main_panel_RecoverData.Show();
            String line;
            String[] get = new String[4];
            char[] separator = { ' ' };
                
            string tablefile = Path.Combine(tablePath, fileName);
            StreamReader tableReader = new StreamReader(tablefile);

            listView1.Columns.Add("Date", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("Week", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("Time", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("File name", 260, HorizontalAlignment.Left);
            listView1.MultiSelect = false;

            while ((line = tableReader.ReadLine()) != null)
            {
                get = line.Split(separator);
                newView(get);
            }
            tableReader.Close();

        }

        private void main_radioButton_daily_CheckedChanged(object sender, EventArgs e) {
            main_comboBox_monthly.Enabled = false;
            main_comboBox_weekly.Enabled = false;
            main_dateTimePicker_daily.Enabled = true;
            var rb = (RadioButton)sender;
            if (rb.Checked) {
                refreshDaily();
            }
        }

        private void main_radioButton_weekly_CheckedChanged(object sender, EventArgs e) {
            main_comboBox_weekly.Enabled = true;
            main_comboBox_monthly.Enabled = false;
            main_dateTimePicker_daily.Enabled = true;
            var rb = (RadioButton)sender;
            if (rb.Checked) {
                refreshWeekly();
            }
        }

        private void main_radioButton_monthly_CheckedChanged(object sender, EventArgs e) {
            main_comboBox_weekly.Enabled = false;
            main_comboBox_monthly.Enabled = true;
            main_dateTimePicker_daily.Enabled = true;
            var rb = (RadioButton)sender;
            if (rb.Checked) {
                refreshMonthly();
            }
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
            this.Hide();
            Icon.ShowBalloonTip(3000);
        }

        private void targetTimeRefresh() {

        }

        private void refreshMonthly() {

        }

        private void refreshWeekly() {

        }

        private void refreshDaily()
        {
            var hour = main_dateTimePicker_daily.Text.Substring(1,2);
            var minute = main_dateTimePicker_daily.Text.Substring(3, 4);
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_return(object sender, EventArgs e)
        {

            /***************************************************************/
            //get data test
            foreach (ListViewItem tmpLstView in listView1.Items)
            {
                if (tmpLstView.Selected == true)
                {
                    textBox1.Text = tmpLstView.SubItems[0].Text + " " 
                                  + tmpLstView.SubItems[1].Text + " " 
                                  + tmpLstView.SubItems[2].Text + " "
                                  + tmpLstView.SubItems[3].Text;
                }
            }
            /***************************************************************/
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void newView(String[] get)
        {
            ListViewItem item = new ListViewItem();
            item.Text = (get[0]);
            item.SubItems.Add(get[1]);
            item.SubItems.Add(get[2]);
            item.SubItems.Add(get[3]);
            listView1.Items.Add(item);
        }
    }
}
