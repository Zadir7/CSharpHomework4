using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayWork a1 = new ArrayWork(0, 2, 10);
            ArrayWork a2 = ArrayWork.Inverse(a1);
            ArrayWork a3 = new ArrayWork(5, 0, 10);

            Console.WriteLine($"Сумма массива а1: {a1.Sum}");
            Console.WriteLine($"Максимальных элементов: {a1.MaxCount}");

            Console.WriteLine($"Массив a2");
            a2.Print();

            Console.WriteLine($"Multi(3) от a1");
            a1.Multi(3);
            a1.Print();

            Dictionary<int, int> a1Elements = a1.CountElements();
            Dictionary<int, int> a3Elements = a3.CountElements();


            foreach (var pair in a1Elements)
               Console.WriteLine($"Element {pair.Key} occured {pair.Value} times");

            foreach (var pair in a3Elements)
                Console.WriteLine($"Element {pair.Key} occured {pair.Value} times");

            Console.ReadKey();
        }
    }
}
