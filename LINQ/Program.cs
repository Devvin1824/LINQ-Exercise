namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string> { "CallofDuty", "Forza", "Pacman", "Minecraft", "RocketLeague", };
            IEnumerable<string> sortedGames = videoGames.OrderBy(game => game.Length);
            foreach (string game in sortedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
