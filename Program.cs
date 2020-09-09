using System;


class Program
{
    public delegate double MathDelegate(double value1, double value2);

    public delegate double Sum(double value1, double value2);


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

        Sum SumDelName = new Sum(Add);


        var a = AddMathDel(5, 2);
        var b = SubMathDel(5, 2);
        var c = AddMathDel(412, 12);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        // вывод: 7
        // вывод: 3

    }
}
