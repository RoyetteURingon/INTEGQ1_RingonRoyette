using System;
using System.Collections.Generic;
using System.Text;

namespace BL_Layer
{
    class Logitech
    {
        public void Logi()
        {
            Console.WriteLine("Press (a) To Buy: Logitech Business B100 Optical USB Mouse,Ambidextrous design,Plug ad Play: $5.05 ");
            Console.WriteLine("Press (b) To Buy: Logitech M585 Multi-Device Wireless Mouse : $20.58 ");
            Console.WriteLine("Press (c) To Buy: Logitech G502 HERO High Performance Gaming Mouse: $47.36");
            Console.WriteLine("Press any key to exit");

            string answer = Console.ReadLine();
            if (answer == "a")
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("Thank You for Purchasing Our Product");

            }
            else if (answer == "b")
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("Thank You for Purchasing Our Product");
            }

            else if (answer == "c")
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("Thank You for Purchasing Our Product");
            }

            else
            {
                Console.WriteLine("Back To List");
                exit exit2 = new exit();
                exit2.exit1();

            }
        }
    }
}