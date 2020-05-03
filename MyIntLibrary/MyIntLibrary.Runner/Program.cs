using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIntLibrary.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            MyInt x = new MyInt(10);
            MyInt y = new MyInt(20);

            MyInt actual = x.add(y);

            Console.WriteLine("---Сложение---");
            Console.WriteLine(actual.String());

            x = new MyInt(10);
            y = new MyInt(20);

            actual = y.subtract(x);

            Console.WriteLine("---Вычитание---");
            Console.WriteLine(actual.String());

            x = new MyInt(10);
            y = new MyInt(20);

            actual = y.multiply(x);

            Console.WriteLine("---Умножение---");
            Console.WriteLine(actual.String());

            x = new MyInt(10);
            y = new MyInt(20);

            actual = y.divide(x);

            Console.WriteLine("---Деление---");
            Console.WriteLine(actual.String());

            x = new MyInt(10);
            y = new MyInt(20);

            actual = y.max(x);

            Console.WriteLine("---Макс---");
            Console.WriteLine(actual.String());

            x = new MyInt(10);
            y = new MyInt(20);

            actual = y.min(x);

            Console.WriteLine("---Мин---");
            Console.WriteLine(actual.String());

            x = new MyInt(10);
            y = new MyInt(20);

            actual = y.compareTo(x);

            Console.WriteLine("---Сравнение---");
            Console.WriteLine(actual.String());

            x = new MyInt(-10);

            actual = x.abs();

            Console.WriteLine("---Модуль---");
            Console.WriteLine(actual.String());

            x = new MyInt(3);
            y = new MyInt(9);

            actual = y.max(x);

            Console.WriteLine("---Наибольший общий делитель---");
            Console.WriteLine(actual.String());


            Console.ReadLine();
        }
    }
}
