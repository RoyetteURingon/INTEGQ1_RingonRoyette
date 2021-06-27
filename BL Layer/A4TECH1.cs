using System;
using System.Collections.Generic;
using System.Text;

namespace BL_Layer
{
    class A4TECH1
    {
        public void A4()
        {
            Console.WriteLine("Press (a) to Buy: A4Tech OP-620D 2x click Mouse Usb, Plug and Play Mouse: $3.71");
            Console.WriteLine("Press (b) to Buy: A4Tech Bloody A90 Infrared-Micro Switch Gaming Mouse: $25.96");
            Console.WriteLine("Press (c) to Buy: A4tech N-708X V-Track Padless Optical Mouse (Glossy Grey): $9.17");
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
        