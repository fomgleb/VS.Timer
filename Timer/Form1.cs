using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        int hours, minutes, seconds;
        public Form1()
        {
            InitializeComponent();
        }

        void SetTextBoxes()
        {
            if (hours != 0 || minutes != 0 || seconds != 0)
            {

            }
            else
            {
                try
                {
                    if (TextBoxHours.Text == "")
                        hours = 0;
                    else
                        hours = Convert.ToInt32(TextBoxHours.Text);
                    if (TextBoxMinutes.Text == "")
                        minutes = 0;
                    else
                        minutes = Convert.ToInt32(TextBoxMinutes.Text);
                    if (TextBoxSeconds.Text == "")
                        seconds = 0;
                    else
                        seconds = Convert.ToInt32(TextBoxSeconds.Text);
                }
                catch (Exception)
                {

                }
            }
            
        }

        private void ButtonPauseTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void ButtonStopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            hours = 0;
            minutes = 0;
            seconds = 0;
            TextBoxHours.Text = "";
            TextBoxMinutes.Text = "";
            TextBoxSeconds.Text = "";
            LabelHours.Text = "0";
            LabelMinutes.Text = "0";
            LabelSeconds.Text = "0";
        }

        private void ButtonStartTimer_Click(object sender, EventArgs e)
        {
            if (TextBoxHours.Text == "" && TextBoxMinutes.Text == "" && TextBoxSeconds.Text == "")
                return;
            else
            {
                SetTextBoxes();

                LabelHours.Text = Convert.ToString(hours);
                LabelMinutes.Text = Convert.ToString(minutes);
                LabelSeconds.Text = Convert.ToString(seconds);

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds -= 1;
            if (seconds == -1)
            {
                minutes -= 1;
                seconds = 59;
            }
            if (minutes == -1)
            {
                hours -= 1;
                minutes = 59;
            }
            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                LabelSeconds.Text = Convert.ToString(seconds);
                timer1.Stop();

                Stop_Timer();
            }
            LabelHours.Text = Convert.ToString(hours);
            LabelMinutes.Text = Convert.ToString(minutes);
            LabelSeconds.Text = Convert.ToString(seconds);
        }

        private void Stop_Timer()
        {
            Sound.Play_TimerOver();
            DialogResult dr = MessageBox.Show("Время вышло", "Таймер",
                MessageBoxButtons.OK);
            if (dr == DialogResult.OK)
                Sound.Stop_TimerOver();
        }
    }
}
