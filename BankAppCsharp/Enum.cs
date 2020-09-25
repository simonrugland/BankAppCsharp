using System;

namespace BankAppCsharp
{
    class EnumProgram
    {
        enum BankOpen
        {
            Monday = 1, Tuesday = 1, Wednesday = 1,
            Thursday = 1, Friday = 1,
            Saturday = 0, Sunday = 0
        }

        int a = (int)BankOpen.Monday;
        int b = (int)BankOpen.Tuesday;
        int c = (int)BankOpen.Wednesday;
        int d = (int)BankOpen.Thursday;
        int e = (int)BankOpen.Friday;
        int f = (int)BankOpen.Saturday;
        int g = (int)BankOpen.Sunday;

        public void ShowDaysOpen()
        {
            Console.WriteLine("\nMonday = {0}", a);
            Console.WriteLine("Tuesday = {0}", b);
            Console.WriteLine("Wednesday = {0}", c);
            Console.WriteLine("Thursday = {0}", d);
            Console.WriteLine("Friday = {0}", e);
            Console.WriteLine("Saturday = {0}", f);
            Console.WriteLine("Sunday = {0}", g);
        }
    }
}