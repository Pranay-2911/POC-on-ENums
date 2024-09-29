using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_on_ENums.Models
{
    internal class WeekDay
    {
        //Enum of WEEKLY day
        public enum Day
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        //ENUM of Custum day with chnages value
        public enum CustomDay
        {
            Sunday = 7,
            Monday = 8,
            Tuesday = 9,
            Wednesday = 10,
            Thursday = 11,
            Friday = 12,
            Saturday = 13

        }
    }
}
