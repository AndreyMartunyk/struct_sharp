using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accaunt
{
    class Accauntant
    {
        /// <summary>
        /// вот эту задачу вообще не понял.
        /// я так-то сделал, но вообще не уверен то ли это =\
        /// если ни то, напишите пожалуйста, я все исправлю
        /// П.С. было бы логично писать менторам с вопросами, но работаю я чаще всего по ночам,
        /// да и вообще дергать людей как-то не очень хочется
        /// </summary>
        public const int COOK = 6;
        public const int DRIVER = 5;
        public const int BAKER = 7;
        public const int TEACHER = 8;

        public bool AskForBonus(Position worker, int hours)
        {
            int normalWorkHours = 0;
            switch (worker)
            {
                case Position.COOK:
                    normalWorkHours = COOK;
                    break;
                case Position.DRIVER:
                    normalWorkHours = DRIVER;
                    break;
                case Position.BAKER:
                    normalWorkHours = BAKER;
                    break;
                case Position.TEACHER:
                    normalWorkHours = TEACHER;
                    break;
                default:
                    Console.WriteLine("Error! no position finded!!!");
                    break;
            }
            return hours > normalWorkHours;
        }


    }
}
