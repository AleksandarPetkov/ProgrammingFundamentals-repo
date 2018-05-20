using System;

class BlankReceipt
{
    static void PrintReceiptHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }

    static void PrintReceiptBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
        Console.WriteLine("------------------------------");
    }

    static void PrintReceiptFooter()
    {
        Console.WriteLine("\u00A9 SoftUni");
    }

    static void PrintReceipt()
    {
        PrintReceiptHeader();
        PrintReceiptBody();
        PrintReceiptFooter();
            
    }

    static void Main() // MAIN
    {
        PrintReceipt();
    }
}

