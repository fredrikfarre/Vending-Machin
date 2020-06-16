using System;
using System.Collections.Generic;

namespace Vending_Machin.Library
{
    public class Purchase
    {
        //bool selectionOK = false;

        public void Menu()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("**Welcome to the vending machin**");
            Console.WriteLine("*********************************\n");
            Console.WriteLine("Valid money in the machin is 1, 5, 10, 20, 50, 100, 1000\n");
            Console.WriteLine("***************************");
            Console.WriteLine("*****Drinks****************");
            Console.WriteLine("*    C- Coke 20           *");
            Console.WriteLine("*    S- Sprite 20         *");
            Console.WriteLine("*    F- Fanta 20          *");
            Console.WriteLine("*    BM- Bloody Mary 75   *");
            Console.WriteLine("*****Chocolate*************");
            Console.WriteLine("*    M - Mars 15          *");
            Console.WriteLine("*    SN- Snickers 15      *");
            Console.WriteLine("*    B- Bounty 15         *");
            Console.WriteLine("*****Food******************");
            Console.WriteLine("*    P- Pizza 95          *");
            Console.WriteLine("*    Q- For get money back*");
            Console.WriteLine("***************************\n");
        }

        public string DisplaySelections()
        {
            Console.WriteLine("Please make your selection");
            return Console.ReadLine().ToUpper();
        }

        public int Selection(string selection, List<IVendorMachineContent> list, int money)
        {           
            IVendorMachineContent coke = list[0];
            IVendorMachineContent sprite = list[1];
            IVendorMachineContent fanta = list[2];
            IVendorMachineContent mary = list[3];
            IVendorMachineContent mars = list[4];
            IVendorMachineContent snickers = list[5];
            IVendorMachineContent bounty = list[6];
            IVendorMachineContent pizza = list[7];
             
          //while (!selectionOK)
          //  {
                switch (selection)
                    {
                        case "C":
                            Console.WriteLine("Thank you for buying a Coke");
                            Console.WriteLine("Drink the Coke");   
                            money -= coke.GetCost();                           
                            Console.WriteLine($"You have money { money } left, after bying a coke!");
                            //selectionOK = true;
                            break;
                        case "S":
                            Console.WriteLine("Thank you for buying a Sprite");
                            Console.WriteLine("Drink the Sprite");
                            money -= sprite.GetCost();
                            Console.WriteLine($"You have money { money } left, after bying a Sprite!");
                            //selectionOK = true;
                            break;
                        case "F":
                            Console.WriteLine("Thank you for buying a Fanta");
                            Console.WriteLine("Drink the Fanta");
                            money -= fanta.GetCost();
                            Console.WriteLine($"You have money { money } left, after bying a Fanta!");
                            //selectionOK = true;
                            break;
                        case "BM":
                            Console.WriteLine("Thank you for buying a Blody Merry");
                            Console.WriteLine("Drink the Blody Merry");
                            money -= mary.GetCost();
                            Console.WriteLine($"You have money { money } left, after bying a Blody Merry!");
                            //selectionOK = true;
                            break;
                        case "M":
                            Console.WriteLine("Thank you for buying a Mars");
                            Console.WriteLine("Eat the Mars");
                            money -= mars.GetCost();
                            Console.WriteLine($"You ´have money { money } left, after bying a Mars!");
                            //selectionOK = true;
                            break;
                        case "SN":
                            Console.WriteLine("Thank you for buying a Snickers");
                            Console.WriteLine("Eat the Snickers");
                            money -= snickers.GetCost();
                            Console.WriteLine($"You ´have money { money } left, after bying a snickers!");
                            //selectionOK = true;
                            break;
                        case "B":
                            Console.WriteLine("Thank you for buying a Bounty");
                            Console.WriteLine("Eat the Bounty");
                            money -= bounty.GetCost();
                            Console.WriteLine($"You ´have money { money } left, after bying a Bounty!");
                           // selectionOK = true;
                            break;
                        case "P":
                            Console.WriteLine("Thank you for buying a Pizza");
                            Console.WriteLine("Eat the Pizza");
                            money -= pizza.GetCost();
                            Console.WriteLine($"You have money { money } left, after bying a pizza!");
                            //selectionOK = true;
                            break;
                        case "Q":
                            Console.WriteLine($"Here you have you money { money }");
                            //selectionOK = true;
                            Environment.Exit(-1);
                            break;    
                        default:
                            Console.WriteLine("Invalid Selection. Please re-enter your selection: ");
                            break;
                }
          //}
               return money;
        }
    }
}


        

    

