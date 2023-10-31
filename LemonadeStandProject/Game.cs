using System;
namespace LemonadeStand
{
	internal class Game
 
	{
        public double resultOfDay;
        public Player player = new Player();
        public Store store = new Store();
        public double resultOfWeek;

        public Game()
		{
            
		}

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Lemonade Stand!" +
                "\nYou have seven days to make as much money as you can!" +
                "\nThe weather as well as your pricing can affect your success" +
                "\nLet's hustle and see if you can make the big bucks!");

        }
      
        //SOLID design principle
        //Open-Close principle open for extension but closed for modification 
        internal void ProfitAndLoss(Day currentDay)
        {
            resultOfDay = 0;
            
            int numberOfPitchers = UserInterface.GetNumberOfPitchers();
            CreatePitcher(numberOfPitchers);
            Console.WriteLine("How much would you like to charge per cup?");
            double inputPricePerCup = double.Parse(Console.ReadLine());
            int customersWhoBought = currentDay.SimulatingCustomersWalkingBy(inputPricePerCup);
            resultOfDay = inputPricePerCup * customersWhoBought;
            player.wallet.AcceptMoney(resultOfDay);
            resultOfDay -= player.totalCostOfDay;
            resultOfWeek += resultOfDay;
            player.totalCostOfDay = 0;
            Console.WriteLine($"Day over! You saw {currentDay.customers.Count} customers today.\n" +
          $"{customersWhoBought} customers bought lemonade.\nToday you have made a profit of ${resultOfDay} and you made a total profit for the week of ${resultOfWeek}");
        }

        public void CreatePitcher(int numberOfPitchers)
        {
            player.inventory.RemoveLemonsFromInventory(player.recipe.numberOfLemons * numberOfPitchers);
            player.inventory.RemoveSugarCubesToInventory(player.recipe.numberOfSugarCubes * numberOfPitchers);
            player.inventory.RemoveCupsToInventory(8 * numberOfPitchers);
            player.inventory.RemoveIceCubesToInventory(player.recipe.numberOfIceCubes * numberOfPitchers);

        }
        public void RunGame()
        {
            DisplayWelcome();
            List<string> days = new List<string>
            {
                "Day 1 Monday",
                "Day 2 Tuesday",
                "Day 3 Weds",
                "Day 4 Thursday",
                "Day 5 Friday",
                "Day 6 Saturday",
                "Day 7 Sunday"
            };
           
            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine($"\nIt is {days[i]}\n");

                Console.WriteLine($"You have an inventory of \nMoney ${player.wallet.Money}, \nIce Cubes {player.inventory.iceCubes.Count}\n" +
                    $"Lemons {player.inventory.lemons.Count},\nCups {player.inventory.cups.Count}\nSugar Cubes {player.inventory.sugarCubes.Count}");

                store.SellCups(player);
                store.SellIceCubes(player);
                store.SellLemons(player);
                store.SellSugarCubes(player);

                player.recipe.DisplayRecipe();
                Console.WriteLine("");
                player.recipe.ChangeRecipe();
                Console.WriteLine("");
                Day day = new Day(); //this is a unique Day object
                day.StartDay();
                ProfitAndLoss(day);

            }


            
        }
    }


	
}

