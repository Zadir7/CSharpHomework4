using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class ArrayWork
    {
        public int[] arr;
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                int maxcount = 0;
                int maxnumber = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (maxnumber < arr[i])
                    {
                        maxnumber = arr[i];
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == maxnumber)
                    {
                        maxcount++;
                    }
                }

                return maxcount;
            }
        }

        public ArrayWork(int start, int step, int size)
        {
            arr = new int[size];
            arr[0] = start;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = start + step * i;
            }
        }

        public ArrayWork(int[] a)
        {
            arr = a;
        }

        public ArrayWork(ArrayWork a)
        {
            arr = a.arr;
        }

        public static ArrayWork Inverse(ArrayWork a)
        {
            int[] invArr = new int[a.arr.Length];
            for (int i = 0; i < a.arr.Length; i++)
            {
                invArr[i] = -a.arr[i];
            }
            return new ArrayWork(invArr);
        }

        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public void Multi(int Multiplier)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= Multiplier;
            }
        }

        public Dictionary<int,int> CountElements() {
            Dictionary<int, int> ElementCount = new Dictionary<int, int>();
            int number;

            for (int i = 0; i < arr.Length; i++)
            {
                number = arr[i];
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == number)
                    {
                        count++;
                    }
                }
                try
                {
                    ElementCount.Add(number, count);
                }
                catch(ArgumentException)
                {
                    continue;
                }
            }

            return ElementCount;
    }
    }
}