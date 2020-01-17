using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birthDate_sharp
{
    class Client
    {
        public void Run()
        {
            int year;
            int month;
            int day;

            Console.Write("Введите год вашего рождения: ");
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                ErrorInput();
            }

            Console.Write("Введите месяц вашего рождения: ");
            while (!int.TryParse(Console.ReadLine(), out month))
            {
                ErrorInput();
            }

            Console.Write("Введите день вашего рождения: ");
            while (!int.TryParse(Console.ReadLine(), out day))
            {
                ErrorInput();
            }

            Console.WriteLine("\nСледующий день рождения через {0} дней.",
                BirthCalculator.GetDaysToNextBirhday(new DateTime(year, month, day)));
        }


        private void ErrorInput()
        {
            Console.WriteLine("error input, enter the number");
        }
    }
}
