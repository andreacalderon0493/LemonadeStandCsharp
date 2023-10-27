using System;
namespace LemonadeStand
{
	internal class Customer
	{
		double willingnessToPay;

		public Customer()
		{
			Random rand = new Random();
			willingnessToPay = rand.Next(50, 200) / 100.0;
			
		}
		public bool WillBuyLemonade(double price)
		{
			return willingnessToPay >= price;
		}
	}
}

