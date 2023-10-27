namespace LemonadeStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game game = new Game();
            //game.RunGame();
         
            //Day day = new Day();
            //day.StartDay();
            Store store = new Store();
            Player player = new Player();
            store.SellCups(player);
            
        }
    }
}