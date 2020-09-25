using System;
using System.ComponentModel;

namespace BankAppCsharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            EnumProgram BankOpen = new EnumProgram();
            int num, n;
            Data show = new Data();
            Accounts bank = new Accounts();
            show.Load();
            Console.Clear();
            show.ShowIntro();
            Console.Write("\n\n\n\t\t Bankens åpningstider: ");
            Console.Write("\n\n\n\t\t 1 = banken er åpen, 0 = banken er stengt.");
            BankOpen.ShowDaysOpen();

            do
            {
                Console.Write("\n\n\n\t Hovedmeny: ");
                Console.Write("\n\t 01. Ny konto");
                Console.Write("\n\t 02. Sette inn penger");
                Console.Write("\n\t 03. Ta ut penger");
                Console.Write("\n\t 04. Saldo");
                Console.Write("\n\t 05. Konto info");
                Console.Write("\n\t 06. Endre kontoen");
                Console.Write("\n\t 07. Avslutt");
                Console.Write("\n\t 08. Vennligst velg ønsket funksjon (1-7)\n ");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                    {
                        Console.Clear();
                        show.Load();
                        bank.CreateAccount();
                        break;
                    }

                    case 2:
                    {
                        Console.Clear();
                        show.Load();
                        bank.Account_Deposit();
                        break;
                    }

                    case 3:
                    {
                        Console.Clear();
                        show.Load();
                        bank.Account_Withdraw();
                        break;
                    }

                    case 4:
                    {
                        Console.Clear();
                        show.Load();
                        bank.Account_Balance();
                        break;
                    }

                    case 5:
                    {
                        Console.Clear();
                        show.Load();
                        bank.ShowAccount();
                        break;
                    }

                    case 6:
                    {
                        Console.Clear();
                        show.Load();
                        Console.Write("\nVennligst tast inn konto nummeret: ");
                        num = int.Parse(Console.ReadLine());
                        bank.ModifyAccount();
                        break;
                    }
                }
            } while (n != 7);
        }
    }
}