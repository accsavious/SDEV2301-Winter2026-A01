namespace Encapsulation
{
    // EncapsulationDemo_Guided.cs
    // Guided exercise: Refactor public fields into private fields + properties.

    //using System;

    // ❌ Starting point: Public fields (no encapsulation)
    public class BankAccountPublic
    {
        public string AccountNumber;
        public decimal Balance;
    }

    // ✅ Refactor this into an encapsulated version
    public class BankAccount
    {
        public static string BankName = "B.O.B. (Big Ol Bank)";
        private decimal _balance; // private property

        public decimal Balance
        {
            get => _balance;
            set
            {
                if (value < 0)
                    throw new Exception($"{nameof(value)} cannot be negative");
                _balance = value;
            }

        }

        public string AccountNumber // read only property
        {
            get;
            private set;
        }

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentNullException($"Account Number cannot be empty");
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }


        public void Deposit(decimal amount)
        {
            if (amount < 0)
                throw new Exception($"Amount cannot be negative");
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
                throw new Exception($"Amount cannot be negative");
            else if (amount > Balance)
                throw new Exception($"Cannot overdraw from account");
            _balance -= amount;
        }

        public override string ToString()
        {
            return $" Account number: {AccountNumber} \nBalance: {Balance:C}";
        }
    }
    public class EncapsulationExercise
    {
        public static void Main()
        {
            Console.WriteLine("=== Encapsulation Demo (Guided) ===");
            BankAccount bankAccount = new BankAccount("123", 1000000);
            Console.WriteLine($"Account number: {bankAccount.AccountNumber} \nBalance: {bankAccount.Balance}");
            Console.WriteLine(BankAccount.BankName);
            // ❌ Using public fields: no protection
            var accountPublic = new BankAccountPublic();
            accountPublic.AccountNumber = "12345";
            accountPublic.Balance = -5000; // ❌ Allowed! Invalid state.
            Console.WriteLine($"[Public] Account: {accountPublic.AccountNumber}, Balance: {accountPublic.Balance}");

            Console.WriteLine();

            // ✅ TODO: Create a BankAccount object with encapsulation
            // - Use the constructor to set account number and initial balance
            // - Print the account details using the properties

            // ✅ TODO: Test your Deposit and Withdraw methods
            // - Deposit a valid amount, print balance
            // - Withdraw a valid amount, print balance
            // - Try to deposit or withdraw invalid amounts and see exceptions
        }
    }

}
