
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._12._2021
{
    enum AccountType
    {
        Actual = 1,
        Savings
    }

    class Bank
    {
        private static Guid Identificator;
        private decimal Balance;
        private AccountType Type;

        public Bank GetInfo()
        {
            Console.WriteLine("Номер счета 1 или 2");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }

            Console.WriteLine("Введите баланс");
            while (!decimal.TryParse(Console.ReadLine(), out Balance) || Balance < 0)
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            var bank = new Bank();
            Identificator = Guid.NewGuid();
            Type = (AccountType)(n);
            return bank;

        }
        //public void Print()
        //{

        //    Console.WriteLine("Информация о счете:");
        //    Console.WriteLine($"Id:{Identificator}");
        //    Console.WriteLine($"Balance:{Balance}");
        //    Console.WriteLine($"Account type:{Type}");

        //}
        public void CheckOut(decimal output)
        {
            if (Balance > output)
            {
                Balance -= output;
            }
            else
            {
                Console.WriteLine("Недостаточно денег для снятия");
            }
        }
        public void CheckBalance(decimal input)
        {
            Balance += input;
        }
        [Conditional("DEBUG")]
        public void DumpScreen()
        { 
            Console.WriteLine($". Id {Identificator}. Balance is {Balance}.  Type is {Type}");
        }

}
}

