using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Recipe
    {
        // member variables (HAS A)
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public double price;


        // constructor (SPAWNER)
        public Recipe()
        {
            numberOfLemons = 2;
            numberOfSugarCubes = 4;
            numberOfIceCubes = 10;
            price = 1;
        }

        //Member Methods (CAN DO)
        public void DisplayRecipe()
        {
            Console.WriteLine($"Your recipe currently consists of:\n{numberOfLemons} lemons per pitcher\n{numberOfSugarCubes} sugar cubes per pitcher\n{numberOfIceCubes} ice cubes per pitcher");
        }
        public void ChangeRecipe()
        {
            Console.WriteLine("Would you like to change your recipe?\nYes or No");
            string userInput = Console.ReadLine();

            if (userInput == "Yes")
            {
                Console.WriteLine($"How many lemons?");
                int lemonInput = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nHow many sugarcubes?");
                int sugarCubeInput = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nHow many ice cubes?");
                int iceCubeInput = int.Parse(Console.ReadLine());


            }

            else
            {
                Console.WriteLine("Keeping the same recipe!");
            }
            
            
        }

    }
}
