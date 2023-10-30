using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Типы данных
            //Основные типы int | float | char | string | bool
            //Целочисленные типы
            byte b; //0 до 255
            sbyte sb; // -128 до 127
            short s; // -32768 до 32767
            ushort us; //0 до 65535
            int i; //-2147483648 до 2147483647
            uint ui; //0 до 4294692295
            long l;
            ulong ul;
            //minvalue и maxvalue позволяют узнать пределы переменной
            //Числа с плавающей точкой
            float f; //До 7 знаков после запятой, нужно указывать суффикс "f" для явной конвертации в тип
            double d; //До 15 знаков после запятой
            //Символьный тип
            char c; //Для записи одинарного символа, использовать ''
            //Строковый тип
            string str; //Для записи строк, использовать ""
            //Логический тип
            bool bl; //Используется в условных конструкция, где проверяется истина или ложь
            Console.WriteLine("Hello");
            Console.ReadKey();
        }
    }
}
