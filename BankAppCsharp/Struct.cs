using System;

namespace BankAppCsharp
{
    struct Data
    {
        private void Intro()
        {
            Console.Write("\n\n\n\t\t\t Bank");
            Console.Write("\n\n\t\t\t Management");
            Console.Write("\n\n\t\t\t System");
            Console.Write("\n\n\t\t Made by Simon@GETACADEMY");
        }

        public void ShowIntro()
        {
            Intro();
        }
         
        internal void Load()
        {
            Console.Write("Laster, vennligst vent");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}