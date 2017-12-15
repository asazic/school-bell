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
    public partial class EditBellForm : Form
    {
        private Scheduler _scheduler;
        private Bell _bell;
        private SchoolBellDbContext _context;
        public EditBellForm(Scheduler scheduler, int index, SchoolBellDbContext context)
        {
            _scheduler = scheduler;
            _bell = _scheduler.Bells.ElementAt(index);
            InitializeComponent();
            dateTimePicker1.Value = _bell.BellTime;
            pathTextBox.Text = _bell.SoundPath;
            fullSoundRadioButton.Checked = _bell.PlayFullSound;
            stopSoundRadioButton.Checked = !_bell.PlayFullSound;
            timerNum.Value = _bell.NumberOfSeconds;
            _context = context;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _bell.BellTime = dateTimePicker1.Value;
            _bell.SoundPath = pathTextBox.Text;
            _bell.PlayFullSound = fullSoundRadioButton.Checked;
            _bell.NumberOfSeconds = _bell.PlayFullSound ? 9 : Int32.Parse(timerNum.Value.ToString());

            try
            {
                var dbBell = _context.Bells.Where(x => x.ID == _bell.ID).FirstOrDefault();
                dbBell.BellTime = _bell.BellTime;
                dbBell.SoundPath = _bell.SoundPath;
                dbBell.PlayFullSound = _bell.PlayFullSound;
                dbBell.NumberOfSeconds = _bell.NumberOfSeconds;

                _context.SaveChanges();
            } catch(Exception ex) { }
            

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fullSoundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (stopSoundRadioButton.Checked)
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

        private void stopSoundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (stopSoundRadioButton.Checked)
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
    }
}
