using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Delegierte_und_Veranstaltungen
{


    
    class Program
    {

        static void Main()
        {

            ConsoleText Printtext = new ConsoleText(Dell_0.Message);

            Printtext.Invoke();



            MathDelegate AddMathDelegate = new MathDelegate(Dell_1.Add);
            MathDelegate SubMathDelegate = new MathDelegate(Dell_1.Sub);

           

            Console.ReadKey();


        }
    }
}
