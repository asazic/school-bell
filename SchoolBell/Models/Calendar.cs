using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBell.Models
{
    public class Calendar
    {
        public int ID { get; set; }
        public List<Scheduler> Schedulers { get; set; }
    }
}
