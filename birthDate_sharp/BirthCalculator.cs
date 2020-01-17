using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birthDate_sharp
{
    static class BirthCalculator
    {
        public static int GetDaysToNextBirhday(DateTime birthDate)
        {
            DateTime nextBirthDate = new DateTime(DateTime.Now.Year, birthDate.Month, birthDate.Day);

            if (DateTime.Now > nextBirthDate)
            {
                nextBirthDate = nextBirthDate.AddYears(1);
            }

            TimeSpan timeSpan = nextBirthDate - DateTime.Now;
            int res  = timeSpan.Days;
            return res;
        }

      
    }
}
