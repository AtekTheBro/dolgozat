using System;

public class BankCard
{
    private string OwnerName;
    private DateTime ExpirationDate;
    private decimal Balance;

    public BankCard(string OwnerName, DateTime expirationDate, decimal Balance)
    {
        this.OwnerName = OwnerName;
        this.ExpirationDate = expirationDate;
        this.Balance = Balance;
    }

    public void DisplayCardInfo()
    { 
        Console.WriteLine("Bankkártya adatai:");
        Console.WriteLine("Kártyatulajdonos: " + OwnerName);
        Console.WriteLine("Lejárati dátum: " + ExpirationDate.ToString("MM/yy"));
        Console.WriteLine("Egyenleg: " + Balance);
    }
}
