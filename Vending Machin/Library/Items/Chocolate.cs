using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machin.Library.Items
{
        public class Chocolate : IVendorMachineContent
        {
            private string name;
            private int price;
            public Chocolate(string Name = "No Name", int Price = 0)
            {
                name = Name;
                price = Price;
            }
            public string GetName()
            {
                return this.name;
            }
            public void SetName(string Name)
            {
                name = Name;
            }
            public int GetCost()
            {
                return price;
            }
            public void SetCost(int Price)
            {
                price = Price;
            }
        }
}
