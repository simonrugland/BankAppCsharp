using System;

namespace BankAppCsharp
{
    class Accounts
    {
        private int AccountNumber;

        public int UserAccountNumber
        {
            get => AccountNumber;
            set => AccountNumber = value;
        }

        protected string Name;
        internal int Deposit;
        protected internal char Type;

        private void Create_Account()
        {
            Console.Write("\nVennligst tast inn ønsket konto nummer : ");
            UserAccountNumber = int.Parse(Console.ReadLine());
            Console.Write("\nVennligst tast inn kontoens eier : ");
            Name = Console.ReadLine();
            Console.Write("\nØnsker du å opprette en sparekonto eller brukskonto? (S/B). : ");
            Type = char.Parse(Console.ReadLine());
            Console.Write("\nVennligst velg ønsket startsaldo(>=500 for sparekonto og >=1000 for brukskonto ) : ");
            Deposit = int.Parse(Console.ReadLine());
            Console.Write("\n\n\nKonto opprettet. Velkommen til Rugland Bank.");
        }

        public void CreateAccount()
        {
            Create_Account();
        }

        protected void Show_Account()
        {
            Console.Write("\nKonto nummer : {0}", UserAccountNumber);
            Console.Write("\nNavn på kontoholder : {0}", Name);
            Console.Write("\nKontotype : {0}", Type);
            Console.Write("\nSaldo : {0}", Deposit);
        }

        public void ShowAccount()
        {
            Show_Account();
        }

        internal void Modify_account()
        {
            Console.Write("\nKonto nummer : {0}", AccountNumber);
            Console.Write("\nForandre kontoholders navn? : ");
            Name = Console.ReadLine();
            Console.Write("\nForandre kontotype? : ");
            Type = char.Parse(Console.ReadLine());
            Console.Write("\nForandre saldo? : ");
            Deposit = int.Parse(Console.ReadLine());
        }

        public void ModifyAccount()
        {
            Modify_account();
        }

        public void Account_Deposit()
        {
            int x;
            Console.Write("Vennligst tast inn ønsket sum du vil sette inn på kontoen: ");
            x = int.Parse(Console.ReadLine());
            Deposit += x;
        }

        public void Account_Withdraw()
        {
            int x;
            Console.Write("Vennligst tast inn ønsket sum du vil ta ut fra kontoen: ");
            x = int.Parse(Console.ReadLine());
            Deposit -= x;
        }

        public void Account_Balance()
        {
            Console.Write("\nSaldo: {0}", Deposit);
        }
    }
}
