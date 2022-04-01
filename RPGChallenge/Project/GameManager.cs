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

                Console.Clear();
                Console.WriteLine("Your stance is: " + player.stance.ToString());
                Console.WriteLine("The enemy's stance is: " + enemy.stance.ToString());
                Console.ReadKey();

                player.PlayChoice(enemy);
                enemy.PlayChoice(player);
            }
            Console.Clear();
            if (player.IsDead())
            {
                Console.WriteLine("You died");
            }
            if (enemy.IsDead())
            {
                Console.WriteLine("your oponent died");
            }
        }
    }
}
 