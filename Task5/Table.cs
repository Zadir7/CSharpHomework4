using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Table
    {
        int[,] arr;
        int height, width;
        Random rand = new Random();

        public Table(int h, int w)
        {
            height = h;
            width = w;
            arr = new int[h,w];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }
        }
        public Table(string path)
        {
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string[] hw = sr.ReadLine().Split(',');
                try
                {
                    height = int.Parse(hw[0]);
                    width = int.Parse(hw[1]);
                    arr = new int[height, width];
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                while (!sr.EndOfStream)
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        string[] str = sr.ReadLine().Split(' ');
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            try
                            {
                                arr[i, j] = int.Parse(str[j]);
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        public int getSum()
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            return sum;
        }
        public int getSum(int cap)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > cap)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            return sum;
        }
        public int Min
        {
            get
            {
                int min = 100;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] < min)
                        {
                            min = arr[i, j];
                        }
                    }
                }
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = -100;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                        }
                    }
                }
                return max;
            }
        }
        public void getNumberOfMax(out int number)
        {
            number = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == Max)
                    {
                         number = i * width + j + 1;
                    }
                }
            }
        }
        public void writeToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine($"{height},{width}");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sw.Write($"{arr[i, j]} ");
                }
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}
