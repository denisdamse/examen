using System;
namespace examen
{
	public class PaymentSystem
	{
		public  void CardPay(decimal amount)
		{
			Console.WriteLine("Using Card paying method");
            Console.WriteLine($"Paid:{amount}");
        }
        public  void PayPal(decimal amount)
		{
            Console.WriteLine("Using PayPal paying method");
            Console.WriteLine($"Paid: {amount}");
        }
        public  void CryptoWallet(decimal amount)
		{
            Console.WriteLine("Using Crypto Wallet paying method");
            Console.WriteLine($"Paid: {amount}");
        }

    }
}

