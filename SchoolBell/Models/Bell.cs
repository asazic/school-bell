using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBell.Models
{
    public class Bell
    {
        public int ID { get; set; }
        public DateTime BellTime { get; set; }
        public string SoundPath { get; set; }
        public bool PlayFullSound { get; set; }
        public int NumberOfSeconds { get; set; }
        public Scheduler Scheduler { get; set; }
        public int Scheduler_ID { get; set; }

    }
}
