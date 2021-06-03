using System;

namespace laba1_Kushil_Cross
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вариант №4");
            Console.WriteLine("Tusk #1");
            Console.Write("Введите х - длину стороны квадрата: ");
            double x1 = double.Parse(Console.ReadLine());
            double Tusk1 = MyLib.MySolution.Perimeter(x1);
            Console.WriteLine("Периметр квадрата равен {0}", Tusk1);

            Console.WriteLine("Tusk #2");
            Console.Write("Введите х - действительное число: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите n - натуральное число: ");
            double n2 = double.Parse(Console.ReadLine());
            double Tusk2 = MyLib.MySolution.Sum(x2, n2);
            Console.WriteLine(Tusk2.ToString());

            Console.WriteLine("Tusk #3");
            Console.Write("Введите х - действительное число: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Введите n - кол-во членов в ряде: ");
            double n3 = double.Parse(Console.ReadLine());
            double Tusk3 = MyLib.MySolution.Func_t(x3, n3);
            Console.WriteLine(Tusk3.ToString());
            Console.ReadLine();

        }
    }
}
