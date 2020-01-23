﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePortfolio01_JeffPaltridge
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Purpose: Amortization program
                
                Input: Principle, Anual Interest Rate, Number of years to pay off loan
                
                Process(es): Calculate and write  monthly payment,  get and write  principle amount, get  and write annual interest rate , convert anual interest rate to monthly,
                             get and write number of years, calculate number of months,
                                
                
                Output:  Example:
                            -----------------------------------
                            | Amortization Payment Calculator |
                            -----------------------------------
                            This program is used to calculate the monthly payments on a loan.
                            Enter principle amount of the loan: 20000
                            Enter annual interest rate in percentage: 7.5
                            Enter number of years to pay off the loan: 5
                            Monthly payment amount is: $400.76
                            Principle amount is: $20000.00
                            Annual interest rate: 7.5%
                            Number of payments: 60
                            Number of years: 5
                
                Author: Jeff Paltridge
                Last modified: 2020.01.20
            */
            // Math.Pow((1+r),n)
            // rate /12 /100 to get proper %
            // A = P((r(Math.Pow((1 + r), n))) / (Math.Pow((1 + r), n) - 1));

            String Principle, Interest, Years;

            double amortInput, rateInput, numPayments, amountPerMonth;

            Console.Write("\t*************************************\n");
            Console.Write("\t*                                   *\n");
            Console.Write("\t*  Amortization Payment Calculator  *\n");
            Console.Write("\t*                                   *\n");
            Console.Write("\t*************************************\n");
            Console.WriteLine("\n\tThis Program is used to Calculate the Monthly Payments of a Loan.\n");
            
            Console.Write("Enter the Principle amount of the loan: ");
            Principle = Console.ReadLine();
            amortInput = double.Parse(Principle);

            Console.Write("\nEnter the Annual interest rate in percentage: ");
            Interest = Console.ReadLine();
            rateInput = Double.Parse(Interest);


            Console.Write("\nEnter the number of Years: ");
            Years = Console.ReadLine();

            


        }
    }
}
