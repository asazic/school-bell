using SchoolBell.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolBell
{
    public partial class AddBellForm : Form
    {
        private Scheduler _scheduler;
        public AddBellForm(Scheduler scheduler)
        {
            _scheduler = scheduler;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "(.mp3)|*.mp3|Audio Files (.wav)|*.wav";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                soundPathTextBox.Text = path;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                timerNum.ReadOnly = false;
                timerNum.Enabled = true;
            }
            else
            {
                timerNum.ReadOnly = true;
                timerNum.Enabled = false;
            }
        }

        private void fullSoundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                timerNum.ReadOnly = false;
                timerNum.Enabled = true;
            }
            else
            {
                timerNum.ReadOnly = true;
                timerNum.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var time = timePicker.Value;
            DateTime bellTime = new DateTime(_scheduler.Date.Year, _scheduler.Date.Month, _scheduler.Date.Day, time.Hour, time.Minute, time.Second);
            string path = soundPathTextBox.Text;

            bool full = fullSoundRadioButton.Checked;
            int numOfSeconds = full ? 0 : Int32.Parse(timerNum.Value.ToString());

            _scheduler.Bells.Add(new Bell
            {
                BellTime = bellTime,
                SoundPath = path,
                PlayFullSound = full,
                NumberOfSeconds = numOfSeconds
            });

            this.Refresh();

            soundPathTextBox.Text = "";
            fullSoundRadioButton.Checked = true;
            radioButton2.Checked = false;
            timerNum.ReadOnly = true;
            timerNum.Enabled = false;
            timerNum.Value = 9;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var time = timePicker.Value;
            DateTime bellTime = new DateTime(_scheduler.Date.Year, _scheduler.Date.Month, _scheduler.Date.Day, time.Hour, time.Minute, time.Second);
            string path = soundPathTextBox.Text;

            bool full = fullSoundRadioButton.Checked;
            int numOfSeconds = full ? 0 : Int32.Parse(timerNum.Value.ToString());

            _scheduler.Bells.Add(new Bell
            {
                BellTime = bellTime,
                SoundPath = path,
                PlayFullSound = full,
                NumberOfSeconds = numOfSeconds
            });

            this.Close();
        }
    }
}
