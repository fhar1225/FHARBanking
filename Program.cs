class Program{
    static void DisplayAccountDetails(Account account1){
        Console.WriteLine($"Account Number: {account1.AccountNumber}");
        Console.WriteLine($"Balance: ${account1.Balance}");
    }
    static void Main(string [] args){
        SavingsAccount savingsAccount = new SavingsAccount(12345, 12.0);
        CheckingAccount checkingAccount = new CheckingAccount(1025,12.0);

        savingsAccount.Deposit(10000);
        DisplayAccountDetails(savingsAccount);
        savingsAccount.CalculateInterest();
        DisplayAccountDetails(savingsAccount);

        Console.WriteLine();

        checkingAccount.Deposit(100);
        DisplayAccountDetails(checkingAccount);
        checkingAccount.Withdraw(600);
        DisplayAccountDetails(checkingAccount);
    }
}