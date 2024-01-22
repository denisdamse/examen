namespace examen;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti datele pentru comanda");
        Order comanda1 = new Order();
        Console.WriteLine("Numele clientului: ");
        comanda1.Customer = Console.ReadLine();
        comanda1.Date = DateTime.Now;
        Console.WriteLine("Suma platita: ");
        comanda1.Total =decimal.Parse(Console.ReadLine());
        Console.WriteLine("Type the method you want to use: ");
        string UsedPaymentMethod = Console.ReadLine();
        int cardverify = string.Compare(UsedPaymentMethod, "CardPay",true);
        int paypalverify = string.Compare(UsedPaymentMethod, "PayPal",true);
        int cryptoverify = string.Compare(UsedPaymentMethod, "CryptoWallet",true);

        if(cardverify==0)
        {

        }
        else if(paypalverify==0)
        {
            
        }
        else if(cryptoverify==0)
        {
            
        }
    }
}

