using SchoolBell.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolBell
{

    public partial class DayScheduler : Form
    {
        private Scheduler _scheduler;
        private SchoolBellDbContext _context;
        public DayScheduler(Scheduler scheduler, SchoolBellDbContext context)
        {
            _scheduler = scheduler;
            _context = context;
            InitializeComponent();

            foreach (var item in _scheduler.Bells)
            {
                var v = new ListViewItem(item.BellTime.ToLongTimeString());
                v.SubItems.Add(item.SoundPath);
                bellListView.Items.Add(v);
            }
        }

        private void addBellButton_Click(object sender, EventArgs e)
        {
            AddBellForm form = new AddBellForm(_scheduler);
            form.FormClosing += new FormClosingEventHandler(AddToList);
            form.button1.Click += new EventHandler(AddToList);
            form.Show();
        }

        private void bellListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void AddToList(object sender, EventArgs e)
        {
            bellListView.Items.Clear();
            foreach (var item in _scheduler.Bells)
            {
                var v = new ListViewItem(item.BellTime.ToLongTimeString());
                v.SubItems.Add(item.SoundPath);
                bellListView.Items.Add(v);
            }
        }

        private void deleteBellButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in bellListView.SelectedItems)
            {
                Bell bellToRemove = null;
                foreach (var bell in _scheduler.Bells)
                {
                    if (bell.BellTime.ToLongTimeString().Equals(item.Text) && bell.SoundPath.Equals(item.SubItems[1].Text))
                    {
                        bellToRemove = bell;
                    }
                }
                if (bellToRemove != null)
                {
                    _scheduler.Bells.Remove(bellToRemove);
                    try
                    {
                        _context.Bells.Remove(bellToRemove);
                        _context.SaveChanges();
                    } catch (Exception ex) { }
                }        
            }
            foreach (ListViewItem eachItem in bellListView.SelectedItems)
            {
                bellListView.Items.Remove(eachItem);
            }
        }

        private void editBellButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            ListViewItem item = bellListView.SelectedItems[0];
            for (int i = 0; i < _scheduler.Bells.Count; i++)
            {
                if (_scheduler.Bells.ElementAt(i).BellTime.ToLongTimeString().Equals(item.Text))
                {
                    index = i;
                }
            }
            EditBellForm form = new EditBellForm(_scheduler, index, _context);
            form.FormClosing += new FormClosingEventHandler(AddToList);
            form.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
