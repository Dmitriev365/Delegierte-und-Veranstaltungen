using System;
using System.Collections.Generic;
using System.Text;

namespace Delegierte_und_Veranstaltungen
{
    class Program
    {

        static void Main()
        {

            ConsoleText Printtext = new ConsoleText(Dell_0.Message);

            Printtext.Invoke();


            Console.ReadKey();


        }
    }
}
