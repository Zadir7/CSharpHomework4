using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Table t1 = new Table(3, 5);
            t1.Print();
            Console.WriteLine($"Сумма всех элементов: {t1.getSum()}");
            Console.WriteLine($"Сумма всех элементов больших 0: {t1.getSum(0)}");
            Console.WriteLine($"Минимальный элемент массива: {t1.Min}");
            Console.WriteLine($"Максимальный элемент массива: {t1.Max}");
            t1.getNumberOfMax(out int numofmax);
            Console.WriteLine($"Номер максимального элемента: {numofmax}");

            Table t2 = new Table("array.txt");
            t2.Print();

            Console.ReadKey();
        }
    }
}
