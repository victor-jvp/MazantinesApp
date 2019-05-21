using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzantinesApp.Classes
{
    public class Semanas
    {
        public int Value { get; set; }

        public static List<Semanas> GetSemanas(int anio)
        {
            List<Semanas> misSemanas = new List<Semanas>();

            for (int i = 1; i <= GetWeeksInYear(anio); i++)
            {
                Semanas semana = new Semanas
                {
                    Value = i
                };

                misSemanas.Add(semana);
            }

            return misSemanas;
        }

        private static int GetWeeksInYear(int year)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            DateTime date1 = new DateTime(year, 12, 31);
            Calendar cal = dfi.Calendar;
            return cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
        }
    }
}
