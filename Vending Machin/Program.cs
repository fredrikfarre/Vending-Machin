using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Vending_Machin.Library;
using Vending_Machin.Library.Items;


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
                list.Add(new Drink("Fanta", 20));
                list.Add(new Drink("Blody Merry", 75));
                list.Add(new Drink("Sprite", 20));
                list.Add(new Drink("Coke", 20));
                list.Add(new Chocolate("Mars", 15));
                list.Add(new Chocolate("Snickers", 15));
                list.Add(new Chocolate("Bounty", 15));
                list.Add(new Food("Pizza", 95));

            }


            Purchase.Menu();
            DepositMoney.MoneyPool();

            while (Selection)
                Purchase.GetSelection(Selection);
            Console.WriteLine();
            
            
           



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

           
