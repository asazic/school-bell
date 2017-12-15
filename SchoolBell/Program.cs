using Quartz;
using Quartz.Impl;
using SchoolBell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolBell
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var context = new SchoolBellDbContext();
            Calendar calendar;

            ISchedulerFactory schedFact = new StdSchedulerFactory();

            var quartzScheduler = schedFact.GetScheduler();
            quartzScheduler.Start();
            using (context)
            {
                var schedulers = context.Schedulers.Include("Bells").Where(x => x.Date >= DateTime.Today).ToList();

                calendar = new Calendar
                {
                    ID = 1,
                    Schedulers = schedulers == null ? new List<Scheduler>() : schedulers
                };

                foreach (var scheduler in calendar.Schedulers)
                {
                    if (scheduler.Enabled == true)
                    {
                        foreach (var bell in scheduler.Bells)
                        {
                            if (!quartzScheduler.CheckExists(new JobKey("myJob" + bell.BellTime.ToShortTimeString(), "group" + scheduler.Date.ToShortDateString())))
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
                                    quartzScheduler.ScheduleJob(job, trigger);
                                }     
                            }
                        }
                    }
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SchoolBell(calendar, context, quartzScheduler));
            }
        }
    }
}
