using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace humidicWebServices
{
    public class Humidity
    {
        public float Level { get; set; }
        public DateTime Date { get; set; }


        public Humidity(float level, DateTime date)
        {

            Level = level;
            Date = date;

        }
    }
}
