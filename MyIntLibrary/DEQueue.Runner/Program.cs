using System;
using System.Linq;

namespace DEQueue.Runner
{
    public class Program
    {
        private static void Main(string[] args)
        {
            DEQueue<string> queue = new DEQueue<string>();

            
            Console.WriteLine("---Добавление элементов---");
            queue.pushFront("Mark");
            queue.pushFront("Alisa");
            queue.pushBack("Kate");
            queue.pushBack("Ed");
            queue.pushBack("Kostya");
            queue.pushFront("Ilyas");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---Удаление с начала---");

            Console.WriteLine(queue.popFront());

            Console.WriteLine("---Вывод данных---");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---Удаление с конца---");
            Console.WriteLine(queue.popBack());

            Console.WriteLine("---Вывод данных---");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---Очистка данных---");
            queue.Clear();

            queue.pushFront("Mark");
            queue.pushFront("Alisa");
            queue.pushBack("Kate");
            queue.pushBack("Ed");
            queue.pushBack("Kostya");
            queue.pushFront("Ilyas");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---ЛИСТ---");

            foreach (var x in queue.convertToArray())
                Console.WriteLine(x);

            
            string[] ss = (string[]) queue.convertToArray().Clone();

            Console.WriteLine("---ЛИСТ КОПИЯ---");

            foreach (var x in ss.ToArray())
                Console.WriteLine(x);


            Console.WriteLine("---Проверка Типов---");

            if (ss.ToArray().GetType() == queue.convertToArray().GetType()) 
            {
                Console.WriteLine("True");
            }


            Console.Read();
        }
    }
}
