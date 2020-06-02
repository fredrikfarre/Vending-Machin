using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machin
{
        public interface IVendorMachineContent
        {
            string GetName();
            void SetName(string Name);
            int GetCost();
            void SetCost(int Price);
        }
}