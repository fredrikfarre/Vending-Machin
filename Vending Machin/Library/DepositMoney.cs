using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machin.Library
{
    class DepositMoney
    {
        public int MoneyBag { get; set; }

        public int MoneyPool()
        {
            Console.WriteLine("Do you whant to buy? (y/n)");
            string Buy = Console.ReadLine().ToUpper();
            try
            {
                if (Buy != "Y")
                {
                    //Console.WriteLine($"Here you have you money {MoneyBag} kr");
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Welcome Back ");
            }

            while (Buy == "Y")
            {
                Console.WriteLine("Enter money into the machine");
            
                int userMoney = Convert.ToInt32(Console.ReadLine());
                int[] ValidMoney = { 1, 5, 10, 20, 50, 100, 1000 };
           

                switch (userMoney)
                {
                    case 1:
                        Console.WriteLine("You enterd 1 kr to the machine");
                        Console.WriteLine($"You have { MoneyBag += ValidMoney[0]} kr in the machine now. ");
                        break;
                    case 5:
                        Console.WriteLine("You enterd 5 kr");
                        Console.WriteLine($"You have { MoneyBag += ValidMoney[1]} kr in the machine now. ");
                        break;
                    case 10:
                        Console.WriteLine("You enterd 10 kr");
                        Console.WriteLine($"You have { MoneyBag += ValidMoney[2]} kr in the machine now. ");
                        break;
                    case 20:
                        Console.WriteLine("You enterd 20 kr");
                        Console.WriteLine($"You have { MoneyBag += ValidMoney[3]} kr in the machine now. ");
                        break;
                    case 50:
                        Console.WriteLine("You enterd 50 kr");
                        Console.WriteLine($"You have { MoneyBag += ValidMoney[4]} kr in the machine now. ");
                        break;
                    case 100:
                        Console.WriteLine("You enterd 100 kr");
                        Console.WriteLine($"You have { MoneyBag += ValidMoney[5]} kr in the machine now. ");
                        break;
                    case 1000:
                        Console.WriteLine("You enterd 1000 kr");
                        Console.WriteLine($"You have { MoneyBag += ValidMoney[6]} kr in the machine now. ");    
                        break;
                    default:
                        Console.WriteLine("Not valid denomination");
                        break;
                }
                Console.WriteLine("Do you to put more money in the machine? y/n");
                Buy = Console.ReadLine().ToUpper();
            }
                return MoneyBag;
        }
    }
}
