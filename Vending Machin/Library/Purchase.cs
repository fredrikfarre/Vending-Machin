using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machin.Library
{
    class Purchase
    {
        bool selectionOK = false;
       

        public void Menu()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("**Welcome to the vending machin**");
            Console.WriteLine("*********************************\n");
            Console.WriteLine("Valid money in the machin is 1, 5, 10, 20, 50, 100, 1000\n");
            Console.WriteLine("***********************");
            Console.WriteLine("*****Drinks************");
            Console.WriteLine("*    C- Coke          *");
            Console.WriteLine("*    S- Sprite        *");
            Console.WriteLine("*    F- Fanta         *");
            Console.WriteLine("*    BM- Blody Merry  *");
            Console.WriteLine("*****Chocolate*********");
            Console.WriteLine("*    M - Mars         *");
            Console.WriteLine("*    SN- Snickers     *");
            Console.WriteLine("*    B- Bounty        *");
            Console.WriteLine("*****Food**************");
            Console.WriteLine("*    P- Pizza         *");
            Console.WriteLine("***********************\n");
        }

        

        public void DisplaySelections()
        {
            Menu();


            Console.WriteLine("Please make your selection");

            Selection = Console.ReadLine().ToUpper();

        }

        string SelectVar = "";
        DisplaySelections(ref SelectVar);
        // mata in: tomat<ENTER>
        Console.WriteLine(" Txt: " + SelectVar);
         Console.ReadLine();
        

        private void Selection(string selection)
        {

            while (!selectionOK)
            {
                

                    switch (selection)
                    {
                        case "C":
                            Console.WriteLine("Thank you for buying a Coke");
                            Console.WriteLine("Drink the Coke");
                            selectionOK = true;
                        
                            // ReturnChange();
                            break;
                        case "S":
                            Console.WriteLine("Thank you for buying a Sprite");
                            Console.WriteLine("Drink the Sprite");
                            selectionOK = true;
                            // ReturnChange();
                            break;
                        case "F":
                            Console.WriteLine("Thank you for buying a Fanta");
                            Console.WriteLine("Drink the Fanta");
                            selectionOK = true;
                            // ReturnChange();
                            break;
                        case "BM":
                            Console.WriteLine("Thank you for buying a Blody Merry");
                            Console.WriteLine("Drink the Blody Merry");
                            selectionOK = true;
                            // ReturnChange();
                            break;
                        case "M":
                            Console.WriteLine("Thank you for buying a Mars");
                            Console.WriteLine("Eat the Mars");
                            selectionOK = true;
                            // ReturnChange();
                            break;
                        case "SN":
                            Console.WriteLine("Thank you for buying a Snickers");
                            Console.WriteLine("Eat the Snickers");
                            selectionOK = true;
                            // ReturnChange();
                            break;
                        case "B":
                            Console.WriteLine("Thank you for buying a Bounty");
                            Console.WriteLine("Eat the Bounty");
                            selectionOK = true;
                            // ReturnChange();
                            break;
                        case "P":
                            Console.WriteLine("Thank you for buying a Pizza");
                            Console.WriteLine("Eat the Pizza");
                            selectionOK = true;
                            // ReturnChange();
                            break;
                        
                        default:
                            Console.WriteLine("Invalid Selection. Please re-enter your selection: ");
                            selection = Convert.ToString(Console.ReadLine().ToUpper());
                            break;
                    }
                  
                        
            }

        }

    }
}
        

    

