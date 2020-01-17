using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_train_sharp
{
    class TrainClient
    {
        //вообще надо бы разделить создание и поиск поездов с вводом/выводом в консоль =(
        const int TASK_REQUIRED_COUNT_OF_TRAINS = 3;

        public void Run()
        {
            Train[] trains = CreateTrains();

            Train clientChoiceTrain;
                

            if (TryFindTrain(trains, TakeTrainNumFromClient(), out clientChoiceTrain))
            {
                Console.WriteLine(clientChoiceTrain.ToString()); 
            }
            else
            {
                ErrorInput();
            }

        }

        private bool TryFindTrain(Train[] trains, int num, out Train result)
        {
            result = new Train();

            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber == num)
                {
                    result = trains[i];
                    return true;
                }
            }

            return false;
        }

        private int TakeTrainNumFromClient()
        {
            Console.WriteLine("Введите номер поезда, информацию которого хотите узнать: ");
            int num = -1;

            if(!int.TryParse(Console.ReadLine(), out num))
            {
                ErrorInput();
            }

            return num;
        }

        private void ErrorInput()
        {
            Console.WriteLine("error input, no trais");
        }

        private Train[] CreateTrains()
        {
            Train[] trains = new Train[TASK_REQUIRED_COUNT_OF_TRAINS];

            for (int i = 0; i < TASK_REQUIRED_COUNT_OF_TRAINS; i++)
            {
                trains[i] = AskTrainInfo();
            }

            SortTrains(trains);

            return trains;

        }

        private static void SortTrains(Train[] arr)
        {
            if (arr == null)
            {
                return;
            }

            if (arr.Length < 2)
            {
                return;
            }

            SortToBigger(arr);
        }

        private static void SortToBigger(Train[] arr)
        {
            for (int y = 0; y < arr.Length; y++)
            {
                for (int i = 0; i < arr.Length - 1 - y; i++)
                {
                    if (arr[i].TrainNumber > arr[i + 1].TrainNumber)
                    {
                        int temp = arr[i].TrainNumber;
                        arr[i].TrainNumber = arr[i + 1].TrainNumber;
                        arr[i + 1].TrainNumber = temp;
                    }
                }
            }
        }

        private Train AskTrainInfo()
        {
            Console.WriteLine("Введите пункт назначения: ");
            string dest = Console.ReadLine();

            Console.WriteLine("Введите номер поезда: ");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("error input, enter the number: ");
            }

            Console.WriteLine("Введите время отправления через точку (час.минута.секунда) (можно просто час): ");
            string temp = Console.ReadLine();
            string[] sTime = temp.Split('.');
            int[] iTime = new int[sTime.Length];

            for (int i = 0; i < sTime.Length; i++)
            {
                iTime[i] = 0;
                int.TryParse(sTime[i], out iTime[i]);
            }

            return new Train(dest, num, new SimpleTime(iTime));
        }
    }
}
