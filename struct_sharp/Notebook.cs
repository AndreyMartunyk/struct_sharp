using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_sharp
{
    struct Notebook
    {
        private string _model;
        private string _manufacturer;
        private double _price;


        public Notebook(string model, string manufacturer, double price)
        {
            _model = model;
            _manufacturer = manufacturer;
            _price = price;
        }

        public void ShowNote()
        {
            Console.WriteLine(String.Format("Model: {0};", _model));
            Console.WriteLine(String.Format("Manufacturer: {0};", _manufacturer));
            Console.WriteLine(String.Format("Price: {0};", _price));
        }
    }
}
