using System;

using RPGChallenge.Project.Entities;

namespace RPGChallenge.Project
{
    internal class GameManager
    {

        Player player;
        Enemy enemy;

        public GameManager()
        {
            Load();
        }
        private void Load()
        {
            player = new Player("Nanaka");
            enemy = new Enemy("Takashki");
        }
        public void Run()
        {
            while(!player.IsDead() && !enemy.IsDead())
            {
                Console.Clear();
                Console.WriteLine("You have " + player.HP + " hp");
                Console.WriteLine("Your oponent have " + enemy.HP + " hp");
                Console.ReadKey();


                enemy.MakeChoice();
                player.MakeChoice();

                player.PlayChoice(enemy);
                enemy.PlayChoice(player);
            }

        }
    }
}
