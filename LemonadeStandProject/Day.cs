using System;
namespace LemonadeStand
{
	internal class Day
	{
		public List<Customer> customers;

        public Day()
		{
			customers = new List<Customer>();
		
		}
		

		public void CreateCustomers(int numOfCustomers)
		{
			for (int i = 0; i < numOfCustomers; i++)
			{
				customers.Add(new Customer());
			}
		}
		public int SimulatingCustomersWalkingBy(double lemonadePrice)
		{
			int customersWhoBought = 0;

			foreach (Customer customer in customers)
			{
				if(customer.WillBuyLemonade(lemonadePrice))
				{
					Console.WriteLine("A customer walked by.. $cha ching");
					customersWhoBought++;
				}
				else
				{
					Console.WriteLine("A customer walked by...");
				}
				
			}  return customersWhoBought;

		}

		public int CalculateNumOfCustomers ()
		{
			Weather weather = new Weather();

			int numOfCustomers = 35;

			if (weather.FindCondition() == "sunny" || weather.FindCondition() == "cloudy")
			{
				numOfCustomers++;
				if (weather.FindTempature() >= 78)
				{
					numOfCustomers++;
				}
	
			}
			else if (weather.FindCondition() == "rainy")
			{
				numOfCustomers--;

				if (weather.FindTempature() < 78)

				{
					numOfCustomers--;
				}
			}
                return numOfCustomers;

        }
        public void StartDay()
        {

			CreateCustomers(35);
            CalculateNumOfCustomers();
			SimulatingCustomersWalkingBy(1);
  

        }
    }


}


