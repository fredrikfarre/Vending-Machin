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

namespace Vending_Machin
{


    public class Program
    {
        static void Main(string[] args)
        {
            var DepositMoney = new DepositMoney();
            var Purchase = new Purchase();

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

            Purchase.Menu();
            int money = DepositMoney.MoneyPool();
            string result = Purchase.DisplaySelections();
            Console.WriteLine(result);

            switch (result)
            {
                case "C":
                    IVendorMachineContent coke = list[0];
                    //Console.WriteLine(money - coke.GetCost());
                    money -= coke.GetCost();
                    if(money > 0)
                    {
                        Console.WriteLine();
                    }
                    break;
                case "S":
                    IVendorMachineContent Sprite = list[1];
                    Console.WriteLine(Sprite.GetCost());
                    break;
                case "F":
                    IVendorMachineContent Fanta = list[2];
                    Console.WriteLine(Fanta.GetCost());
                    break;
                case "BM":
                    IVendorMachineContent Mary = list[3];
                    Console.WriteLine(Mary.GetCost());

                    break;
                case "M":
                    IVendorMachineContent Mars = list[4];
                    Console.WriteLine(Mars.GetCost());
                    break;
                case "SN":
                    IVendorMachineContent Snickers = list[5];
                    Console.WriteLine(Snickers.GetCost());
                    break;
                case "B":
                    IVendorMachineContent Bounty = list[6];
                    Console.WriteLine(Bounty.GetCost());
                    break;
                case "P":
                    IVendorMachineContent Pizza = list[7];
                    Console.WriteLine(Pizza.GetCost());
                    break;
                default:
                    //Console.WriteLine("Invalid Selection. Please re-enter your selection: ");
                    break;
            }
            //DepositMoney.MoneyPool();

                //string select = Console.ReadLine();
                //switch ()
                //{
                //    case "C":
                //        IVendorMachineContent product = list[0];
                //        Console.WriteLine(product.GetName());
                //        break;
                //    case "S":


           
            //        break;

            //}


            //foreach (IVendorMachineContent P in list)
            //{

            //}


            //while (Selection)
            //    Purchase.GetSelection(Selection);
            //Console.WriteLine();






            //    int result = 0;
            //    foreach (var li in list)
            //    {
            //        result += li.GetCost();
            //    }
            //    Console.WriteLine("Allt i maskien kostar " + result + " kr.");
            //}
        }
    }
}

           
