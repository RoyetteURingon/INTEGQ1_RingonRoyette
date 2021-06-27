using System;
using System.Collections.Generic;
using System.Text;

namespace BL_Layer
{
    class Fantech
    {
     public void Fan()
     {
      Console.WriteLine("Press(a) To Buy: Fantech Mouse XD3 Helios Wired & Wireless Programmable RGB Macro Gaming Mouse: $53.15");
      Console.WriteLine("Press(b) To Buy: Fantech T532 Wired Optical Gaming Mouse 1200DPI: $3.21");
      Console.WriteLine("Press(c) To Buy: FANTECH X15 PHANTOM MACRO RGB GAMING MOUSE: $11.02");
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

