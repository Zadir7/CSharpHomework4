using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random r = new Random();

            //for (int i = 0; i < arr.Length; i++) {
            //    arr[i] = r.Next(-10000, 10000);
            //    Console.Write($"{arr[i]} ");
            //}
            //Console.WriteLine();
            

            StaticClass.arrayWrite("Array.txt");
            arr = StaticClass.arrayRead("Array.txt");
            StaticClass.pairCheck(arr);

            Console.ReadKey();
        }
    }

    static class StaticClass
    {
        public static void pairCheck(int[] a)
        {
            Console.WriteLine("Выводим пары чисел, в которых одно делится на 3:");
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i - 1] % 3 == 0 ^ a[i] % 3 == 0)
                {
                    Console.WriteLine($"{a[i - 1]}, {a[i]}");
                }
            }
        }
        public static void arrayWrite(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            int[] arr = new int[20];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10000, 10000);
                sw.Write($"{arr[i]} ");
            }
            sw.Close();
        }

        public static int[] arrayRead(string path)
        {
            int size = 0;
            if (File.Exists(path)) {
                StreamReader sr = new StreamReader(path);
                string[] str = sr.ReadLine().Split(' ');
                sr.Close();

                size = str.Length - 1;
                int[] arr = new int[size];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(str[i]);
                }
                return arr;
            } else
            {
                Console.WriteLine("Не удалось считать файл!");
                int[] arr = new int[size];
                return arr;
            }
        }
    }
}
