using System;
namespace LemonadeStand
{
	public class Game
	{    public Game()
		{

		}

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Lemonade Stand!" +
                "\nYou have seven days to make as much money as you can!" +
                "\nThe weather as well as your pricing can affect your success" +
                "\nLet's hustle and see if you can make the big bucks!");

        }
        public void DisplayDay()
        {
            Player player;
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
            int currentDay = 0;
            
            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine($"It is {days[i]}");
            }
        }
        
        public void RunGame()
        {
            DisplayWelcome();
            Wallet wallet = new Wallet();
            Inventory inventory = new Inventory();
            Console.WriteLine($"You have an inventory of \nMoney ${wallet.Money}, \nIce Cubes {inventory.iceCubes.Count}\n" +
                $"Lemons {inventory.lemons.Count},\nCups {inventory.cups.Count}\nSugar Cubes {inventory.sugarCubes.Count}");
            
            
            Store store = new Store();
            Player player = new Player();
            store.SellCups(player);
            store.SellIceCubes(player);
            store.SellLemons(player);
            store.SellSugarCubes(player);

            Recipe recipe = new Recipe();
            recipe.DisplayRecipe();
            Console.WriteLine("");
            recipe.ChangeRecipe();
            Console.WriteLine("");
            Day day = new Day();

            day.StartDay();

            DisplayDay();
        }
    }


	
}

