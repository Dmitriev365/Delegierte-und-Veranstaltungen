using System;
using System.Collections.Generic;
using System.Text;

namespace Delegierte_und_Veranstaltungen
{
    class Dell_2
    {
        static void Hello(string s)
        {
            Console.WriteLine("  Hello, {0}!", s);
        }

        static void Goodbye(string s)
        {
            Console.WriteLine("  Goodbye, {0}!", s);
        }

        delegate void Del(string s);

        static void TT()
        {
            Del a, b, c, d;

            // Создаем делегат a ссылающийся на метод  Hello:
            a = Hello;

            // Создаем делегат b ссылающийся на метод  Goodbye:
            b = Goodbye;

            // Формируем композицию делегатов a и b - c: 
            c = a + b;

            // Удаляем a из композиции делегатов c, создавая делегат d, который в результате вызывает только метод  Goodbye:
            d = c - a;

            Console.WriteLine("Invoking delegate a:");
            a("A");
            Console.WriteLine("Invoking delegate b:");
            b("B");
            Console.WriteLine("Invoking delegate c:");
            c("C");
            Console.WriteLine("Invoking delegate d:");
            d("D");


            /* Вывод:
            Invoking delegate a:
              Hello, A!
            Invoking delegate b:
              Goodbye, B!
            Invoking delegate c:
              Hello, C!
              Goodbye, C!
            Invoking delegate d:
              Goodbye, D!
            */

            Console.ReadLine();
        }
    }
}





//Это возможно, поскольку делегаты наследуются от класса System.MulticastDelegate,
    //который, в свою очередь, наследуется от System.Delegate. Вы можете использовать члены, 
   // определенные в этих базовых классах для ваших делегатов.

//Например, чтобы узнать, сколько методов будет вызывать многоадресный делегат, вы можете использовать следующий код:

//int invocationCount = d.GetInvocationList().GetLength(0);