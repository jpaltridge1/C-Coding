using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePortfolio03_JeffPaltridge
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Purpose: calulating depreciation tables
             * 
             * Input: option selection, amount to depreciate, number of years to deprieciate 
             * 
             * Process(s): loop, switch, method, if/else
             * 
             * Output: option menu, input queries, depreciation values 
             * 
             * Author: Jeff Paltridge       
             * 
             * modified: February 28, 2020
             *              
             */

            string menuOption;
            decimal amount = 0.0m;
            decimal year = 0.0m;
            string amountString, yearString;

            do
            {
                Console.WriteLine("Please Enter: ");
                Console.WriteLine("\tA -To enter a new Amount and/or Number of Years, ");
                Console.WriteLine("\tB -To use the straight-line method, ");
                Console.WriteLine("\tC -To use the sum-of-years-digits method, ");
                Console.WriteLine("\tD -To use the double-declining balance method, ");
                Console.WriteLine("\tQ -To Quit, ");
                Console.Write("\nOption? ");
                menuOption = Console.ReadLine();

                switch (menuOption.ToUpper())
                {

                    case "A":
                        {
                            Console.Write("\nHow much money is to be Depriciated: ");
                            amountString = Console.ReadLine();
                            decimal.TryParse(amountString, out amount);
                            Console.Write("Over How many Years? ");
                            yearString = Console.ReadLine();
                            decimal.TryParse(yearString, out year);
                            Console.WriteLine();

                            break;
                        }

                    case "B":
                        {
                            Straight_Line_Method(amount, year);
                            break;
                        }

                    case "C":
                        {
                            Sum_of_Years_Digits_Method(amount, year);
                            break;
                        }

                    case "D":
                        {
                            Double_Declining_Balance_Method(amount, year);
                            break;
                        }

                    case "Q":
                        {
                            Console.WriteLine("\nGood-Bye!\n");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine($"\n*** Invaild Menu Choice {menuOption}.\n");
                            break;
                        }
                }//eos

            } while (menuOption.ToUpper() != "Q"); //eow
        }

        public static void Straight_Line_Method(decimal amount, decimal year)
        {
            decimal loopMax = year;
            decimal amountInput = amount;
            decimal depreciationAmount;

            Console.WriteLine("\n  Year \t  Depreciation");
            Console.WriteLine("  ---- \t--------------");
            
            for (decimal depreciationCounter = 1; depreciationCounter <= loopMax; depreciationCounter++)
            {

                depreciationAmount = amountInput / year;
                Console.WriteLine("{0,6:0}{1,16:c}", depreciationCounter, depreciationAmount);
            }
            Console.WriteLine();
           
        }
        public static void Sum_of_Years_Digits_Method(decimal amount, decimal year)
        {
            decimal loopMax = year;
            decimal amountInput = amount;
            decimal yearSum = 0;
            decimal depreciationAmount;
            decimal yearTotal;

            Console.WriteLine("\n  Year \t  Depreciation");
            Console.WriteLine("  ---- \t--------------");
            for (decimal loopCounter = 1; loopCounter <= loopMax; loopCounter++)
            {
                yearSum += loopCounter;

            }

            for (decimal depreciationCounter = 1; depreciationCounter <= loopMax; depreciationCounter++)
            {

                yearTotal = (year - depreciationCounter + 1);
                depreciationAmount = amountInput * (yearTotal / yearSum);
                Console.WriteLine("{0,6:0}{1,16:c}", depreciationCounter, depreciationAmount);

            }
            Console.WriteLine();
        
        }

        public static void Double_Declining_Balance_Method(decimal amount, decimal year)
        {
            decimal amountTotal = amount;
            decimal loopMax = year;
            decimal depreciationAmount;

            Console.WriteLine("\n  Year \t  Depreciation");
            Console.WriteLine("  ---- \t--------------");
           
            for (decimal depreciationCounter = 1; depreciationCounter <= loopMax; depreciationCounter++)
            {
                depreciationAmount = (amountTotal * (2 / year));
                amountTotal -= depreciationAmount;

                Console.WriteLine("{0,6:0}{1,16:c}", depreciationCounter, depreciationAmount);

            }
            Console.WriteLine();

        }
    }
}
