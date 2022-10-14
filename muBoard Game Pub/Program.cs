using muBoard_Game_Pub.Games;

namespace muBoard_Game_Pub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("muBoard Game Pub");

            Puzzle puzzle = new Puzzle(new TimeSpan(1, 30, 0), Complexity.hard);
            Console.WriteLine(puzzle);
            Card cardgame = new Card(new TimeSpan(0, 45, 0), Complexity.easy, 2, 3);
            Console.WriteLine(cardgame);
            Storytelling storytelling = Storytelling.GetInstance(new TimeSpan(1, 0, 0), Complexity.medium, 3, 6);
            Console.WriteLine(storytelling);

            List<Player> players = new() { new Player("Joe"), new Player("Eve"), new Player("Jane"), new Player("Adam") };

            var george = new Player("George");
            puzzle.Start(new List<Player>() { george });
            puzzle.Quit(george);
        }
    }
}