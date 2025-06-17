using System;
using System.Media;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class Form1 : Form
    {
        private SoundPlayer player;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            player = new SoundPlayer("alarm.wav");
            chkAlarm_CheckedChanged(null, null);
        }
        private void chkAlarm_CheckedChanged(object sender, EventArgs e)
        {
            nudHour.Enabled = !chkAlarm.Checked;
            nudMinute.Enabled = !chkAlarm.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lbTime.Text = "Сейчас: " + now.ToString("HH:mm:ss");

            if (chkAlarm.Checked &&
                now.Hour == (int)nudHour.Value &&
                now.Minute == (int)nudMinute.Value &&
                now.Second == 0)
            {
                try
                {
                    player.Play();
                }
                catch
                {
                    MessageBox.Show("Ошибка при воспроизведении звука.");
                }
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void tsmiMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tsmiMove_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tsmiRestore_Click(object sender, EventArgs e)
        {
        }

        private void tsmiSize_Click(object sender, EventArgs e)
        {
        }

        private void tsmiMaximize_Click(object sender, EventArgs e)
        {
        }
    }
}
