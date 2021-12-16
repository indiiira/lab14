#define NoUse
using System;
using System.Diagnostics;

namespace ConsoleApp1
{

    class Program
    {
        static void Main()
        {
            System.Reflection.MemberInfo attrInfo;
            attrInfo = typeof(Racionalization);
            object[] attrs = attrInfo.GetCustomAttributes(false);

            foreach (CustomAttribute.DeveloperInfoAttribute devAttr in attrs)
            {
                Console.WriteLine("Developer: {0}\tDate: {1}", devAttr.Developer, devAttr.Date);
            }
            Console.ReadKey();
        }
    }
}
