using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBell.Models
{
    public class Scheduler
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public bool Enabled { get; set; }
        public List<Bell> Bells { get; set; }

    }
}
