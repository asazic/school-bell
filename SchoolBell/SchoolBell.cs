using Quartz;
using Quartz.Impl;
using SchoolBell.Extensions;
using SchoolBell.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolBell
{
    public partial class SchoolBell : Form
    {
        private Calendar _calendar;
        private Scheduler selectedScheduler;
        private IScheduler _quartzScheduler;
        private SchoolBellDbContext _context;

        public SchoolBell(Calendar calendar, SchoolBellDbContext context, IScheduler quartzScheduler)
        {
            _context = context;
            _calendar = calendar;
            _quartzScheduler = quartzScheduler;
            
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var date in monthCalendar1.Dates())
            {
                if (!CheckIfExists(date))
                {
                    _calendar.Schedulers.Add(new Scheduler
                    {
                        Bells = new List<Bell>(),
                        Date = new DateTime(date.Year, date.Month, date.Day),
                        Enabled = true
                    });
                    _context.Schedulers.Add(new Scheduler
                    {
                        Bells = new List<Bell>(),
                        Date = new DateTime(date.Year, date.Month, date.Day),
                        Enabled = true
                    });
                    _context.SaveChanges();
                }else
                {
                    _calendar.Schedulers.Where(x => x.Date.ToShortDateString() == date.ToShortDateString()).FirstOrDefault().Enabled = true;
                    try
                    {
                        _context.Schedulers.Where(x => x.Date.ToShortDateString() == date.ToShortDateString()).FirstOrDefault().Enabled = true;
                        _context.SaveChanges();
                    } catch (Exception ex) { }
                }
            }

            var startDate = monthCalendar1.SelectionStart;
            int index = 0;

            for (int i = 0; i < _calendar.Schedulers.Count; i++)
            {
                if (_calendar.Schedulers.ElementAt(i).Date.ToLongDateString().Equals(startDate.ToLongDateString()))
                {
                    index = i;
                    break;
                }
            }

            selectedScheduler = _calendar.Schedulers.ElementAt(index);
            DayScheduler form = new DayScheduler(selectedScheduler, _context);
            form.FormClosing += new FormClosingEventHandler(CopySchedulers);
            form.FormClosing += new FormClosingEventHandler(CreateTriggers);
            form.Show();
        }

        private bool CheckIfExists(DateTime date)
        {
            foreach (var scheduler in _calendar.Schedulers)
            {
                if (date.ToLongDateString().Equals(scheduler.Date.ToLongDateString()))
                {
                    return true;
                }
            }
            return false;
        }
        [STAThread]
        public void CopySchedulers(object sender, EventArgs e)
        {
            foreach (var date in monthCalendar1.Dates())
            {
                foreach (var scheduler in _calendar.Schedulers)
                {
                    if(scheduler.ID == 0)
                    {
                        scheduler.ID = _context.Schedulers.Where(x => x.Date == date).FirstOrDefault().ID;
                    }           
                    if (date.ToLongDateString().Equals(scheduler.Date.ToLongDateString()) && !date.ToLongDateString().Equals(selectedScheduler.Date.ToLongDateString()))
                    {
                        scheduler.Bells = new List<Bell>();
                        try
                        {
                            _context.Bells.RemoveRange(_context.Bells.Where(x => x.Scheduler_ID == scheduler.ID));
                        } catch (Exception ex) { }
                        for (int i = 0; i < selectedScheduler.Bells.Count; i++)
                        {
                            _context.Bells.Add(new Bell
                            {
                                Scheduler_ID = scheduler.ID,
                                BellTime = new DateTime(scheduler.Date.Year, scheduler.Date.Month, scheduler.Date.Day,
                                                selectedScheduler.Bells.ElementAt(i).BellTime.Hour, selectedScheduler.Bells.ElementAt(i).BellTime.Minute, selectedScheduler.Bells.ElementAt(i).BellTime.Second),
                                SoundPath = selectedScheduler.Bells.ElementAt(i).SoundPath,
                                PlayFullSound = selectedScheduler.Bells.ElementAt(i).PlayFullSound,
                                NumberOfSeconds = selectedScheduler.Bells.ElementAt(i).NumberOfSeconds
                            });
                        }
                    }
                    if (date.ToLongDateString().Equals(selectedScheduler.Date.ToLongDateString()))
                    {
                        foreach (var bell in selectedScheduler.Bells)
                        {
                            try
                            {
                                if (bell.ID == 0)
                                {
                                    _context.Bells.Add(new Bell
                                    {
                                        BellTime = bell.BellTime,
                                        NumberOfSeconds = bell.NumberOfSeconds,
                                        PlayFullSound = bell.PlayFullSound,
                                        SoundPath = bell.SoundPath,
                                        Scheduler_ID = _context.Schedulers.First(x => x.Date.ToShortDateString() == date.ToLongDateString()).ID
                                    });
                                }
                            }
                            catch (Exception ex) { }
                        }
                    }
                }
                _context.SaveChanges();
            }
        }
        [STAThread]
        public void CreateTriggers(object sender, EventArgs e)
        {
            foreach (var scheduler in _calendar.Schedulers)
            {
                if(InDate(scheduler.Date))
                if(scheduler.Enabled == true)
                {
                    foreach (var bell in scheduler.Bells)
                    {
                        if (!_quartzScheduler.CheckExists(new JobKey("myJob" + bell.BellTime.ToShortTimeString(), "group" + scheduler.Date.ToShortDateString())))
                        {
                                if (bell.BellTime > DateTime.Now)
                                {
                                    IJobDetail job = JobBuilder.Create<PlaySound>()
                                        .UsingJobData("path", bell.SoundPath)
                                        .UsingJobData("sec", bell.NumberOfSeconds)
                                        .UsingJobData("full", bell.PlayFullSound)
                                        .WithIdentity("myJob" + bell.BellTime.ToShortTimeString(), "group" + scheduler.Date.ToShortDateString())
                                        .Build();

                                    ITrigger trigger = TriggerBuilder.Create()
                                      .WithIdentity("myTrigger" + bell.BellTime.ToShortTimeString(), "group" + scheduler.Date.ToShortDateString())
                                      .StartAt(bell.BellTime.ToUniversalTime())
                                      .Build();
                                    _quartzScheduler.ScheduleJob(job, trigger);
                                }
                        }
                    }
                }              
            }
        }

        private bool InDate(DateTime d)
        {
            foreach (var date in monthCalendar1.Dates())
            {
                if (d.ToLongDateString() == date.ToLongDateString())
                {
                    return true;
                }
            }
            return false;
        }

        private void deleteSchedulerButton_Click(object sender, EventArgs e)
        {
            foreach (var date in monthCalendar1.Dates())
            {
                var scheduler = _calendar.Schedulers.Where(x => x.Date.ToShortDateString() == date.ToShortDateString()).FirstOrDefault();
                if (scheduler != null)
                {
                    scheduler.Enabled = false;
                    try
                    {
                        _context.Schedulers.Where(x => x.Date.ToShortDateString() == date.ToShortDateString()).FirstOrDefault().Enabled = false;
                        _context.SaveChanges();
                    }
                    catch (Exception ex) { }
                }
                foreach (var bell in scheduler.Bells)
                {
                    try
                    {
                        _quartzScheduler.DeleteJob(new JobKey("myJob" + bell.BellTime.ToShortTimeString(), "group" + scheduler.Date.ToShortDateString()));
                    }
                    catch (Exception ex) { }

                }
            }
        }
    }
    public class PlaySound : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            JobDataMap dataMap;
            dataMap = context.JobDetail.JobDataMap;
            var url = dataMap.GetString("path");
            var sec = dataMap.GetInt("sec");
            var full = dataMap.GetBoolean("full");

            WMPLib.WindowsMediaPlayer Player;
            Player = new WMPLib.WindowsMediaPlayer();

            Player.openPlayer(url);
            if (!full)
            {
                wait(sec);
            }


            //var proc = Process.GetProcessesByName("wmplayer");
            //if (proc.Length > 1)
            //{
            //    proc[proc.Length - 1].Kill();
            //}
        }

        private async void wait(int time)
        {
            await Task.Delay(TimeSpan.FromSeconds(time));
            var proc = Process.GetProcessesByName("wmplayer");
            if (proc.Length > 0)
            {
                proc[proc.Length - 1].Kill();
            }
        }

    }
}