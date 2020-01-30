using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1

            string inputNumber, answer;
            double number1;

            Console.Write("Enter the Number: ");
            inputNumber = Console.ReadLine();

            number1 = double.Parse(inputNumber);

            if (number1 > 0)
            {
                answer = "p";
            }
            else if (number1 < 0)
            {
                answer = "n";
            }

            else
            {
                answer = "z";
            }

            switch (answer)
            {
                case "p":
                    {
                        Console.WriteLine($"The Number {number1} is Positive!");
                    }
                        break;

                case "n" :
                    {
                        Console.WriteLine($"The Number {number1} is Negative!");
                    }
                        break;

                case "z":
                    {
                        Console.WriteLine($"The Number {number1} is Zero!");
                    }
                        break;
                                                                          
            }//eos

            Console.ReadKey();

            //End Question 1

            //Question 2

            string ageInput, ageAnswer;
            double age1;
            const double child = 0.00;
            const double student = 9.80;
            const double adult = 11.35;
            const double senior = 10.00;

            Console.Write("Please Enter Customer Age: ");
            ageInput = Console.ReadLine();
            age1 = double.Parse(ageInput);

          

        }
    }
}
