using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherForecast forecast = new WeatherForecast();

            //use the indexer to obtain forecast values and write them out
            string[] days = { "Monday","Thursday","Tuesday","Saturday"};
            foreach (string day in days)
            {
                WeatherReport report = forecast[day];
                Console.WriteLine("Day: {0} \t DayIndex {1}, Temp: {2} Ave {3}", day, report.DayOfWeek, report.DailyTemp, report.AveTempSoFar);
            }

            //Change one of the temperatures;
            forecast["Tuesday"] = new WeatherReport()
            {
                DailyTemp = 34
            };

            //Repeat the loop
            Console.WriteLine("\nModified results...");
            foreach(string day in days)
            {
                WeatherReport report = forecast[day];
                Console.WriteLine("Day: {0} \t DayIndex {1}, Temp: {2} Ave {3}", day, report.DayOfWeek, report.DailyTemp, report.AveTempSoFar);
            }

            Console.WriteLine("\nMain method complete. Press Enter.");
            Console.ReadLine();
        }
    }
}
