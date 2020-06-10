using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Vending_Machin.Library.Items
{
        public class Chocolate : IVendorMachineContent
        {
            private int id;
            private string name;
            private int price;
        public Chocolate(int ID = 0, string Name = "No Name", int Price = 0)
            {
                id = ID;
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
            public int GetId()
            {
                return id;
            }

            public void SetId(int ID)
            {
                id = ID;
            }
    }
}
