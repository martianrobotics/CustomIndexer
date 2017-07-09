using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIndexer
{
    class WeatherReport
    {
        public int DayOfWeek
        {
            get;
            set;
        }

        public int DailyTemp
        {
            get;
            set;
        }

        public int AveTempSoFar
        {
            get;
            set;
        }
    }
}
