using System;

using RPGChallenge.Project;

namespace RPGChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager game = new GameManager();
            game.Run();
        }
    }
}
