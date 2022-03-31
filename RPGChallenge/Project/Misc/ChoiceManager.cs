using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGChallenge.Project
{
    public static class ChoiceManager
    {
        public static int AskChoice(List<string> _choices, string _question)
        {
            bool validated = false;
            ConsoleKey keyPressed = ConsoleKey.O;
            int answer = 0;
            while(validated != true)
            {
                Console.Clear();
                Console.WriteLine(_question + "\n");

                for(int i = 0; i < _choices.Count; i++)
                {
                    if (answer == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("  > " + _choices[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("    " + _choices[i]);
                    }
                }
                keyPressed = Console.ReadKey().Key;

                if (keyPressed == ConsoleKey.Z || keyPressed == ConsoleKey.UpArrow)
                {
                    answer -= 1;
                    if(answer < 0)
                    {
                        answer += _choices.Count;
                    }
                }
                if (keyPressed == ConsoleKey.S || keyPressed == ConsoleKey.DownArrow)
                {
                    answer += 1;
                    if (answer > _choices.Count - 1)
                    {
                        answer -= _choices.Count;
                    }
                }
                if (keyPressed == ConsoleKey.Spacebar || keyPressed == ConsoleKey.Enter)
                {
                    validated = Validate(_choices[answer]);
                }
            }
            return answer;
        }
        public static bool Validate(string _choice)
        {
            bool validate = true;
            ConsoleKey keyPressed = ConsoleKey.O;

            while (keyPressed != ConsoleKey.Enter && keyPressed != ConsoleKey.Spacebar)
            {
                Console.Clear();
                Console.WriteLine("you agree this choice: " + _choice);

                if (validate)
                {
                    Console.WriteLine("  > Yes");
                    Console.WriteLine("    No");
                }
                else
                {
                    Console.WriteLine("    Yes");
                    Console.WriteLine("  > No");
                }

                keyPressed = Console.ReadKey().Key;
                if (keyPressed == ConsoleKey.Z || keyPressed == ConsoleKey.S || keyPressed == ConsoleKey.UpArrow || keyPressed == ConsoleKey.DownArrow)
                {
                    validate = !validate;
                }
            }
            return validate;
        }
    }
}
