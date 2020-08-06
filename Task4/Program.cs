using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Account admin = new Account();
            admin.ReadFile("logpass.txt");

            int tryCount = 0, maxTryCount = 3;
            string log, pass;

            do
            {
                Console.WriteLine("Введите логин");
                log = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                pass = Console.ReadLine();

                if (log == admin.login && pass == admin.password)
                {
                    Console.WriteLine("Вход выполнен.");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль. Вам дана еще одна попытка.");
                }
                tryCount++;
            }
            while (tryCount < maxTryCount);

            if (tryCount >= maxTryCount)
            {
                Console.WriteLine($"Вы превысили максимальное количество попыток: {maxTryCount}. Вход заблокирован отныне и навсегда.");
            }
            Console.ReadKey();
        }
        }
    }
    

    struct Account
    {
        public string login;
        public string password;

        public void ReadFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string[] logpass = sr.ReadLine().Split(' ');
                this.login = logpass[0];
                this.password = logpass[1];
            }
            
        }
    }
