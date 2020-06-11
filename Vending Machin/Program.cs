using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Vending_Machin.Library;
using Vending_Machin.Library.Items;
using System.ComponentModel;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.Design;
using System.Xml.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Vending_Machin
{


    public class Program
    {
        public readonly static bool selectionOK = false;

        static void Main(string[] args)
        {
            List<IVendorMachineContent> list = new List<IVendorMachineContent>();
            {
                list.Add(new Drink(1, "Coke", 20));
                list.Add(new Drink(2, "Sprite", 20));
                list.Add(new Drink(3, "Fanta", 20));
                list.Add(new Drink(4, "Bloody Mary", 75));
                list.Add(new Chocolate(5, "Mars", 15));
                list.Add(new Chocolate(6, "Snickers", 15));
                list.Add(new Chocolate(7, "Bounty", 15));
                list.Add(new Food(8, "Pizza", 95));
            }
            
            var DepositMoney = new DepositMoney();
            var Purchase = new Purchase();


            Purchase.Menu();
            int money = DepositMoney.MoneyPool();
            string result = Purchase.DisplaySelections();
            Purchase.Selection(result);
            int _money = Choice(result, money, list, selectionOK);
            
            Console.WriteLine("Do you whant to buy more stufe? (y/n)");
            
            string Buy = Console.ReadLine().ToUpper();
            
            //if(Buy == "N")
            //{
            //    Console.WriteLine($"You have money {_money} left. Do not forget to take the money!");
            //}
            //else
            //{
            //    result = Purchase.DisplaySelections();
            //    Purchase.Selection(result);

            //    Choice(result, money, list, selectionOK);
            //    _money = Choice(result, money, list, selectionOK);

            //}
 
            
            
            
            //  Choice(result, money, selectionOK);
            

            //    Console.WriteLine("Do you to put more money in the machine? y/n");
            //    Buy = Console.ReadLine().ToUpper();
            
            //}


        }
        public static int Choice(string result, int money, List<IVendorMachineContent> list, bool selectionOK)
        {
            IVendorMachineContent coke = list[0];
            IVendorMachineContent sprite = list[1];
            IVendorMachineContent fanta = list[2];
            IVendorMachineContent mary = list[3];
            IVendorMachineContent mars = list[4];
            IVendorMachineContent snickers = list[5];
            IVendorMachineContent bounty = list[6];
            IVendorMachineContent pizza = list[7];

            while (!selectionOK)
            {
                switch (result)
                {
                    case "C":
                        money -= coke.GetCost();
                        Console.WriteLine($"You have money { money} left, after bying a coke!");
                        selectionOK = true;
                        break;
                    case "S":
                        money -= sprite.GetCost();
                        Console.WriteLine($"You have money { money} left, after bying a coke!");
                        selectionOK = true;
                        break;
                    case "F":
                        money -= fanta.GetCost();
                        Console.WriteLine($"You have money { money} left, after bying a coke!");
                        selectionOK = true;
                        break;
                    case "BM":
                        money -= mary.GetCost();
                        Console.WriteLine($"You ´have money { money} left, after bying a coke!");
                        selectionOK = true;
                        break;
                    case "M":
                        money -= mars.GetCost();
                        Console.WriteLine($"You ´have money { money} left, after bying a coke!");
                        selectionOK = true;
                        break;
                    case "SN":
                        money -= snickers.GetCost();
                        Console.WriteLine($"You ´have money { money} left, after bying a coke!");
                        selectionOK = true;
                        break;
                    case "B":
                        money -= bounty.GetCost();
                        Console.WriteLine($"You ´have money { money} left, after bying a coke!");
                        selectionOK = true;
                        break;
                    case "P":
                        money -= pizza.GetCost();
                        Console.WriteLine($"You ´have money { money} left, after bying a pizza!");
                        selectionOK = true;
                        break;

                }
            }
              return money; 
        }
    }
}


           
