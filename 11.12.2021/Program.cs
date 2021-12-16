
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _11._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {
           Bank bankinfo = new Bank();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите команды:заполнить, вывести, снять со счета, положить на счет, выход");

                string act = Console.ReadLine().ToLower();
                if (act.Equals("выход"))
                {
                    flag = false;
                }
                else if (act.Equals("заполнить"))
                {
                    bankinfo.GetInfo();
                }
                else if (act.Equals("info"))
                {
                    bankinfo.DumpScreen();
                }
                else if (act.Equals("снять со счета"))
                {
                    decimal output;
                    Console.WriteLine("Сумма для снятия");
                    while (!decimal.TryParse(Console.ReadLine(), out output) || output < 0)
                    {
                        Console.WriteLine("Ошибка ввода! Введите целое число n");
                    }
                    bankinfo.CheckOut(output);
                }
                else if (act.Equals("положить на счет"))
                {
                    decimal input;
                    Console.WriteLine("Сумма для пополнения");
                    while (!decimal.TryParse(Console.ReadLine(), out input) || input < 0)
                    {
                        Console.WriteLine("Ошибка ввода! Введите целое число n");
                    }
                    bankinfo.CheckBalance(input);
                }
                Console.ReadKey();
            }
        }
    }
}
