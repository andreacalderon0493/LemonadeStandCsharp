﻿namespace LemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game game = new Game();
            //game.RunGame();
            Weather weather = new Weather();
            Day day = new Day();
            day.CreateCustomers(10);
            day.SimulatingCustomersWalkingBy(1);
            day.CalculateNumOfCustomers();

        }
    }
}