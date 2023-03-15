using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
     public class Atposition0_UC1
        {
        public static void call()
        {
            int position = 0; 
            
            Console.ReadLine();

            Random random = new Random();

            while (position < 100)
            {
                int dice = random.Next(1, 7);
                Console.WriteLine("You rolled {0}", dice);
                position += dice;
                if (position > 100)
                {
                    position = 100 - (position - 100);
                }
                Console.WriteLine("You are now at position {0}", position);

                // check for snakes and ladders
                switch (position)
                {
                    case 3:
                        Console.WriteLine("You found a ladder at position 3! You climb to position 21.");
                        position = 21;
                        break;
                    case 8:
                        Console.WriteLine("You found a ladder at position 8! You climb to position 30.");
                        position = 30;
                        break;
                    case 17:
                        Console.WriteLine("You found a snake at position 17! You slide down to position 13.");
                        position = 13;
                        break;
                    case 28:
                        Console.WriteLine("You found a snake at position 28! You slide down to position 19.");
                        position = 19;
                        break;
                    case 52:
                        Console.WriteLine("You found a ladder at position 52! You climb to position 72.");
                        position = 72;
                        break;
                    case 57:
                        Console.WriteLine("You found a snake at position 57! You slide down to position 40.");
                        position = 40;
                        break;
                    case 62:
                        Console.WriteLine("You found a snake at position 62! You slide down to position 22.");
                        position = 22;
                        break;
                    case 75:
                        Console.WriteLine("You found a ladder at position 75! You climb to position 86.");
                        position = 86;
                        break;
                    case 88:
                        Console.WriteLine("You found a snake at position 88! You slide down to position 52.");
                        position = 52;
                        break;
                }

                Console.WriteLine("Press Enter key to roll the dice...");
                Console.ReadLine();
            }
        }
}
}
