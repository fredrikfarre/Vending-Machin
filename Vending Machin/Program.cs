using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Vending_Machin.Library;
using Vending_Machin.Library.Items;

namespace Vending_Machin
{


    public class Program
    {
       
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
             while (true) 
             {
                string Choice = Purchase.DisplaySelections();
                // while ( Choice != "Q") {

                if(money >= 15)
                {
                 
                     money = Purchase.Selection(Choice, list, money);
                     Console.WriteLine(money);                                    
                }
                else 
                {
                    Console.WriteLine($"Here you have you money { money }");
                    Environment.Exit(-1);
                }                     
             }
                             
                
                                //else
                                //{
                                //     DepositMoney.MoneyPool();
                                //}
                                    // Purchase.DisplaySelections();
        }
                //}
                //        if(Choice == "Q") {Console.WriteLine($"change back {money} kr");}
    }

}


