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

            }
        }
}
}
