using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<BankCard> bankCards = ReadCSV("8.csv");

        foreach (var card in bankCards)
        {
            card.DisplayCardInfo();
            Console.WriteLine();
        }

        Console.ReadLine();
    }

    static List<BankCard> ReadCSV(string filePath)
    {
        List<BankCard> bankCards = new List<BankCard>();

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    string OwnerName = values[0];
                    decimal Balance = 0.0m;
                    DateTime ExpirationDate = new DateTime(2025, 12, 31);

                    BankCard newCard = new BankCard(OwnerName, ExpirationDate, Balance);
                    bankCards.Add(newCard);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Hiba történt a fájl olvasása során: " + e.Message);
        }

        return bankCards;
    }
}