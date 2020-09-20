using System;
using System.Collections.Generic;
using System.Text;

namespace Delegierte_und_Veranstaltungen
{
    public class Dell_1
    {
       

        public static double Add(double value1, double value2)
        {
            return value1 + value2;
        }
        public static double Sub(double value1, double value2)
        {
            return value1 - value2;
        }
    }

    public delegate double MathDelegate(double value1, double value2);

}
