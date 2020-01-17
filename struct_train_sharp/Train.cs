using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_train_sharp
{
    struct Train
    {
        private string _destinationName;
        private int _trainNumber;
        private SimpleTime _departureTime;

        public int TrainNumber{
            get
            {
                return _trainNumber;
            }
            set
            {
                _trainNumber = value;
            }
        }

        public string DestinationName
        {
            get
            {
                return _destinationName;
            }
        }

        public SimpleTime DepartureTime
        {
            get
            {
                return _departureTime;
            }
        }

        public Train(string destinationName, int trainNumber, SimpleTime departureTime)
        {
            _destinationName = destinationName;
            _trainNumber = trainNumber;
            _departureTime = departureTime;
        }
    }
}
