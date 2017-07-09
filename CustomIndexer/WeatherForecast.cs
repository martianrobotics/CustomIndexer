using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIndexer
{
    class WeatherForecast
    {
        private int[] temps = { 54, 63, 61, 55, 61, 63, 58 };

        IList<string> daysOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", 
            "Thursday", "Friday", "Saturday", "Sunday" };
        
        public WeatherReport this[string dow]
        {
            get
            { 
                // get the day of the week index
                int dayIndex = daysOfWeek.IndexOf(dow);
                return new WeatherReport()
                {
                    DayOfWeek = dayIndex,
                    DailyTemp = temps[dayIndex],
                    AveTempSoFar = calculateTempSoFar(dayIndex)
                };
            }
            set
            {
                temps[daysOfWeek.IndexOf(dow)] = value.DailyTemp;
            }
        }

        private int calculateTempSoFar(int dayOfWeek)
        {
            int[] subset = new int[dayOfWeek + 1];
            Array.Copy(temps, 0, subset, 0, dayOfWeek + 1);
            return (int)subset.Average();
        }
    }
}
