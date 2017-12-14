using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Windows.Forms.VisualStyles;

namespace EvertTimer
{
    public partial class timertoolForm : Form
    {
        public timertoolForm()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(TimeReached);
            timer2.Tick += new EventHandler(ShowSecond);
            timer3.Tick += new EventHandler(Exclamate);
        }

        private void timertoolForm_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.BalloonTipTitle = "EvertTimer";
                notifyIcon.BalloonTipText = "I am hiding in the tray.";
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(2000);
                Hide();
            }
            else
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_Restore(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private static int countdown = 0;
        DateTime StartTime;
        DateTime FinishTime;

        private void StopIt()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer1.Stop();
            timer2.Stop();
            txtHours.Enabled = true;
            txtMinutes.Enabled = true;
            lbl_seconds.Text = "00";
            btn_start.Text = "start";
            btn_start.BackColor = Color.LightGreen;
            progressbarSimple1.Value = 0;
            btn_5min.Enabled = true;
            btn_15min.Enabled = true;
            btn_30min.Enabled = true;
            btn_1hour.Enabled = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "start")
            {
                int seconds = 0;
                seconds += Convert.ToInt16(txtMinutes.Text) * 60;
                seconds += Convert.ToInt16(txtHours.Text) * 60 * 60;
                if (seconds == 0)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        btn_start.BackColor = Color.Tomato;
                        btn_start.Refresh();
                        System.Threading.Thread.Sleep(200);
                        btn_start.BackColor = Color.LightGreen;
                        btn_start.Refresh();
                        System.Threading.Thread.Sleep(200);
                    }
                    return;
                }

                StartTime = DateTime.Now;
                FinishTime = StartTime;
                FinishTime = FinishTime.AddSeconds(seconds);

                timer1.Interval = seconds * 1000;
                timer1.Enabled = true;
                timer1.Start();

                timer2.Interval = 1000; // 1 second
                timer2.Enabled = true;
                timer2.Start();

                btn_start.Text = "stop";
                txtHours.Enabled = false;
                txtMinutes.Enabled = false;

                btn_5min.Enabled = false;
                btn_15min.Enabled = false;
                btn_30min.Enabled = false;
                btn_1hour.Enabled = false;

                progressbarSimple1.Maximum = seconds;
                btn_start.BackColor = Color.LightCoral;
            }
            else
            {
                StopIt();
            }

        }

        public void TimeReached(object sender, EventArgs eArgs)
        {
            StopIt();

            if (chk_beep.Checked)
            {
                // sounds 3 times a beep (exclamation mark)
                SystemSounds.Exclamation.Play();
                countdown = 1;
                timer3.Interval = 2000;
                timer3.Enabled = true;
            }

            notifyIcon.BalloonTipTitle = "EvertTimer";
            notifyIcon.BalloonTipText = "Time is up!";
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(4000);

            Show();
            Activate();
            MessageBox.Show("Time is up!","EvertTimer");
            progressbarSimple1.Value = 0;
        }

        public void ShowSecond(object sender, EventArgs eArgs)
        {
            int h, m, s;
            string sh = ""; string sm = ""; string ss = "";
            TimeSpan TimeToGo = FinishTime - DateTime.Now;
            h = TimeToGo.Hours;
            m = TimeToGo.Minutes;
            s = TimeToGo.Seconds;
            if (h < 10) sh = "0";
            if (m < 10) sm = "0";
            if (s < 10) ss = "0";
            txtHours.Text = sh + Convert.ToString(h);
            txtMinutes.Text = sm + Convert.ToString(m);
            lbl_seconds.Text = ss + Convert.ToString(s);
            progressbarSimple1.Value = Convert.ToInt32(TimeToGo.TotalSeconds);
        }

        public void Exclamate(object sender, EventArgs eArgs)
        {
            SystemSounds.Exclamation.Play();
            if (countdown == 0)
            {
                if (!chk_repeat.Checked)
                {
                    timer3.Stop();
                    timer3.Enabled = false;
                    chk_repeat.ForeColor = DefaultForeColor;
                }
                else
                {
                    chk_repeat.ForeColor = Color.DarkOrange;
                }
            }
            else countdown--;
        }

        private void btn_5min_Click(object sender, EventArgs e)
        {
            txtHours.Text = "00";
            txtMinutes.Text = "05";
        }

        private void btn_15min_Click(object sender, EventArgs e)
        {
            txtHours.Text = "00";
            txtMinutes.Text = "15";
        }

        private void btn_30min_Click(object sender, EventArgs e)
        {
            txtHours.Text = "00";
            txtMinutes.Text = "30";
        }

        private void btn_1hour_Click(object sender, EventArgs e)
        {
            txtHours.Text = "01";
            txtMinutes.Text = "00";
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(txtHours.Text, out n);
            if (!isNumeric)
            {
                txtHours.Text = "";
                for (int i = 0; i < 1; i++)
                {
                    txtHours.BackColor = Color.Tomato;
                    txtHours.Refresh();
                    System.Threading.Thread.Sleep(200);
                    txtHours.BackColor = Color.White;
                    txtHours.Refresh();
                    System.Threading.Thread.Sleep(200);
                }
            }
        }

        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(txtMinutes.Text, out n);
            if (!isNumeric)
            {
                txtMinutes.Text = "";
                for (int i = 0; i < 1; i++)
                {
                    txtMinutes.BackColor = Color.Tomato;
                    txtMinutes.Refresh();
                    System.Threading.Thread.Sleep(200);
                    txtMinutes.BackColor = Color.White;
                    txtMinutes.Refresh();
                    System.Threading.Thread.Sleep(200);
                }
            }
        }

        private void chk_beep_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_beep.Checked) chk_repeat.Enabled = true;
            else chk_repeat.Enabled = false;
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.evertmouw.nl/");
        }

    }

    
    
}
