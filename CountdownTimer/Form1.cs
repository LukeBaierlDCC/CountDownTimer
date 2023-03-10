using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class CountDownTimer : Form
    {
        public CountDownTimer()
        {
            InitializeComponent();
        }
        int timeleft = 60;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeleft > 0)
            {
                timeleft = timeleft - 1;
                timerlabel.Text = timeleft + " seconds";                
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                timer.Stop();
                timerlabel.Text = "Time's up!";
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeleft = 60;
            timerlabel.Text = timeleft + " seconds";
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            timeleft = timeleft + 60;
            timerlabel.Text = timeleft.ToString() + " seconds";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            timeleft = timeleft - 60;
            timerlabel.Text = timeleft.ToString() + " seconds";
        }
    }
}
