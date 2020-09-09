using System;
using System.Collections.Generic;
using System.Text;

namespace Delegierte_und_Veranstaltungen
{
    class Dell_1
    {
        public delegate double MathDelegate(double value1, double value2);

        public static double Add(double value1, double value2)
        {
            return value1 + value2;
        }
        public static double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }
        Console.ReadLine();

    public static void Main()
        {
            MathDelegate mathDelegate = Add;
            var result = mathDelegate(5, 2);
            Console.WriteLine(result);
            // вывод: 7

            mathDelegate = Subtract;
            result = mathDelegate(5, 2);
            Console.WriteLine(result);
            // вывод: 3

        }

    }
