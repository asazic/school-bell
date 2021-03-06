﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolBell.Extensions
{
    public static class Extensions
    {
        public static IEnumerable<DateTime> Dates(this MonthCalendar cal)
        {
            DateTime day = cal.SelectionStart;
            do
            {
                yield return day;
                day = day.AddDays(1);
            } while (day <= cal.SelectionEnd);
        }
    }
}
