using System;
using System.Collections.Generic;
using System.Text;
using DL_layer;
namespace BL_Layer
{
    public class BL
    {


        public void log()
        {

            string user, pass;
            string username = "username";
            string password = "password";
            Console.WriteLine("Hello Welcome To Mice Shop And Enjoy Your Shopping :) ");
            Console.Write("Enter Your Username: ");
            user = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            pass = Console.ReadLine();

            if (user == username && pass == password)
            {

                mouse();
            }
            else
            {
                Console.WriteLine("Wrong Credentials");
            }
        }

        public void mouse()
        {
            A4TECH1 A440 = new A4TECH1();
            Logitech logit = new Logitech();
            Fantech fant = new Fantech();
            DL item = new DL();

            Console.WriteLine(" Mouse For Pc");
            Console.WriteLine("");
        
            foreach (string list in item.mouse)
                
            
                Console.WriteLine(list);

                {
                    Console.Clear();
                    Console.WriteLine("Press A To view A4TECH");
                    Console.WriteLine("Press L To view Logitech");
                    Console.WriteLine("Press F To view FanTech");
                    char select = Convert.ToChar(Console.ReadLine());
                    select = char.ToUpper(select);

                    switch (select)
                    {
                        case 'A':
                            A440.A4();
                            break;
                        case 'L':
                            logit.Logi();
                            break;
                        case 'F':
                            fant.Fan();
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;

                    }
                }
              
            }
        }
    }

