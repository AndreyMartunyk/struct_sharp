using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_train_sharp
{
    struct SimpleTime
    {
        const int MAX_MIN = 60;
        const int MAX_SEC = 60;
        const int MAX_HOURS = 24;

        private int _hours;
        private int _minutes;
        private int _seconds;

        public SimpleTime(int hours)
            :this(hours, 0)
        {
            
        }

        public SimpleTime(int hours, int minutes)
            :this(hours, minutes, 0)
        {

        }

        public SimpleTime(int hours, int minutes, int seconds)
        {
            _hours = hours % MAX_HOURS;
            _minutes = minutes % MAX_MIN;
            _seconds = seconds % MAX_SEC;
        }

        public SimpleTime(params int[] time)
        {
            _hours = 0;
            _minutes = 0;
            _seconds = 0;

            switch (time.Length)
            {
                case 1:
                    this = new SimpleTime(time[0]);
                    break;
                case 2:
                    this = new SimpleTime(time[0], time[1]);
                    break;
                case 3:
                    this = new SimpleTime(time[0], time[1], time[2]);
                    break;
                default:
                    break;
            }
        }


        public override string ToString()
        {
            string hourPlaceholder = "";
            string minutesPlaceholder = "";
            string secondsPlaceholder = "";

            if (_hours < 10)
            {
                hourPlaceholder = "0";
            }
            if (_minutes < 10)
            {
                minutesPlaceholder = "0";
            }
            if (_seconds < 10)
            {
                secondsPlaceholder = "0";
            }

            return String.Format("{0}{1}:{2}{3}:{4}{5}",
                hourPlaceholder, _hours, minutesPlaceholder, _minutes, secondsPlaceholder, _seconds);
        }
    }
}
