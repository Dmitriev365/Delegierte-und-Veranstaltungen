using System;


class Program
{
    public delegate double MathDelegate(double value1, double value2);

    public static double Add(double value1, double value2)
    {
        return value1 + value2;
    }
    public static double Sub(double value1, double value2)
    {
        return value1 - value2;
    }
    

    public static void Main()
    {

        MathDelegate AddMathDel = new MathDelegate(Add);
        MathDelegate SubMathDel = new MathDelegate(Sub);


        var a = AddMathDel(5, 2);
        var b = SubMathDel(5, 2);
        Console.WriteLine(a);
        Console.WriteLine(b);
        // вывод: 7
        // вывод: 3

    }
}
