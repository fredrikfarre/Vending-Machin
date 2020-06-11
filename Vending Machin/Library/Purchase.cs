﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Vending_Machin.Library;
using Vending_Machin.Library.Items;

namespace Vending_Machin.Library
{
    public class Purchase
    {
        bool selectionOK = false;
        string select;

        public void Menu()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("**Welcome to the vending machin**");
            Console.WriteLine("*********************************\n");
            Console.WriteLine("Valid money in the machin is 1, 5, 10, 20, 50, 100, 1000\n");
            Console.WriteLine("*************************");
            Console.WriteLine("*****Drinks**************");
            Console.WriteLine("*    C- Coke 20         *");
            Console.WriteLine("*    S- Sprite 20       *");
            Console.WriteLine("*    F- Fanta 20        *");
            Console.WriteLine("*    BM- Bloody Mary 75 *");
            Console.WriteLine("*****Chocolate***********");
            Console.WriteLine("*    M - Mars 15        *");
            Console.WriteLine("*    SN- Snickers 15    *");
            Console.WriteLine("*    B- Bounty 15       *");
            Console.WriteLine("*****Food****************");
            Console.WriteLine("*    P- Pizza 95        *");
            Console.WriteLine("***********************\n");
        }

        public string DisplaySelections()
        {
            //Menu();
            Console.WriteLine("Please make your selection");
            return Console.ReadLine().ToUpper();
        }

        public string Selection(string selection)
        {
            while (!selectionOK)
            {
                switch (selection)
                {
                    case "C":
                        select = "C";
                        Console.WriteLine("Thank you for buying a Coke");
                        Console.WriteLine("Drink the Coke");
                        selectionOK = true;                       
                        break;
                    case "S":
                        select = "S";
                        Console.WriteLine("Thank you for buying a Sprite");
                        Console.WriteLine("Drink the Sprite");
                        selectionOK = true;
                        break;
                    case "F":
                        select = "F";
                        Console.WriteLine("Thank you for buying a Fanta");
                        Console.WriteLine("Drink the Fanta");
                        selectionOK = true;
                        break;
                    case "BM":
                        select = "BM";
                        Console.WriteLine("Thank you for buying a Blody Merry");
                        Console.WriteLine("Drink the Blody Merry");
                        selectionOK = true;

                        break;
                    case "M":
                        select = "M";
                        Console.WriteLine("Thank you for buying a Mars");
                        Console.WriteLine("Eat the Mars");
                        selectionOK = true;
                        break;
                    case "SN":
                        select = "SN";
                        Console.WriteLine("Thank you for buying a Snickers");
                        Console.WriteLine("Eat the Snickers");
                        selectionOK = true;
                        break;
                    case "B":
                        select = "B";
                        Console.WriteLine("Thank you for buying a Bounty");
                        Console.WriteLine("Eat the Bounty");
                        selectionOK = true;
                        break;
                    case "P":
                        select = "P";
                        Console.WriteLine("Thank you for buying a Pizza");
                        Console.WriteLine("Eat the Pizza");
                        selectionOK = true;
                        
                        break;
                    default:
                        Console.WriteLine("Invalid Selection. Please re-enter your selection: ");
                        break;
                }
            }
            return select;
        }
    }
}

        

    

