using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Hours
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string HourDate { get; set; }
        public decimal WorkedHours { get; set; }
        public bool Night { get; set; }
        public decimal DayBreak 
        {
            get {
                if(!Night)
                {
                    return (int)(WorkedHours / 4) * 20 + (WorkedHours * 10);
                }
                else
                {
                    return 0;
                }
                 }
        }
        public decimal NightBreak 
        {
            get 
            {
                if (Night)
                {
                    return (int)(WorkedHours / 4) * 30 + (WorkedHours * 15); 
                }
                else
                {
                    return 0;
                }
            } 
        }

        public Hours()
        {
            //for serialization
        }
        public Hours(string first, string last, string date, decimal workedhours, bool night)
        {
            First = first;
            Last = last;
            HourDate = date;
            WorkedHours = workedhours;
            Night = night;
        }


    }
}
