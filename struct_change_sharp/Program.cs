using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_change_sharp
{
    class Program
    {
        /// <summary>
        /// тут все достаточно просто, структура является ValueType, такая же как int, double и т.д
        /// valueType передаваясь в функцию делает копию, итого у нас получается 2 переменных не связанных друг с другом
        /// в случае же с классом, он является ссылочным типом данных. передавая переменную в метод мы передаем ссылку на обьект
        /// соответственно у нас получается 2 переменных с ссылками на один обьект.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "не изменено";
            myStruct.change = "не изменено";
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

            Console.ReadKey();
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";

        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}
