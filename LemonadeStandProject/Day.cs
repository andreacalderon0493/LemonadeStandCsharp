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
				if (customer.WillBuyLemonade(lemonadePrice))
				{
					Console.WriteLine("A customer walked by.. $cha ching");
					customersWhoBought++;
				}
				else
				{
					Console.WriteLine("A customer walked by...");
				}

				
            } return customersWhoBought;

           

        }

		public int CalculateNumOfCustomers ()
		{
			Weather weather = new Weather();

			int numberOfCustomers = 35;


			if (weather.condition == "sunny" || weather.condition == "cloudy")
			{
				numberOfCustomers++;
				if (weather.tempature >= 78)
				{
					numberOfCustomers++;
				}
	
			}
			else if (weather.condition == "rainy")
			{
				numberOfCustomers--;

				if (weather.tempature < 78)

				{
					numberOfCustomers--;
				}
			}
                return numberOfCustomers;

        }
        public void StartDay()
        {
			CreateCustomers(CalculateNumOfCustomers());
            
        }
    }


}


