using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a method that holds the actual code for this case
             * the B case will CALL the method to execute this action is reffered to as calling the statement
             * calling requires your code to use the method name
             * 
             * your program will branch to the requested  
             * 
             * 
             * the syntax for a method requires
             * 
             * accesstype returndatatype MethodName([list of parameters])
             * {
             *      //your method code
             * }//eom
             * 
             * 
             * accesstype:  public or private
             *              protected, internal, have static reference
             *              
             *  returndatatype: if you are returning nothing use the keyword void
             *                  otherwise, return a single value such as int, double, decimal ect.
             *                  
             *  MethodName: continious string of characters which will be used within
             *                your program code to reference this coding block
             *  
             *  it is best to use a meaningful name
             *  
             *  [list of parameters] this is a set of local variables that will be used to recieve values from the calling statement
             *                  a parameter is a set of datatype variable name
             *                  parameters are separated by using a comma ,
             *                  
             * 
             */

            string menuOption;
            bool flag = false;


            while (flag == false)
            {
                Console.WriteLine("Select a Menu Option:");
                Console.WriteLine("A) to Case A");
                Console.WriteLine("B) to Case B");
                Console.WriteLine("C) to Case C");
                Console.WriteLine("X) to Exit");
                Console.Write("Please Enter your selection: ");
                menuOption = Console.ReadLine();


                switch (menuOption.ToUpper())
                {

                    case "A":
                        {
                            Even_Or_Odds();
                            break;
                        }


                    case "B":
                        {
                            Heads_or_Tails_Game();//calling statement
                            break;
                        }


                    case "C":
                        {
                            break;
                        }


                    default:
                        {
                            flag = true;
                            break;
                        }

                }

            }
        }
            

        
     static public void Heads_or_Tails_Game()//method header
     {

        string inputString;
        do
        {

            Console.WriteLine("Enter  a H (Heads) or T (Tails) or Q (Quit)");
            inputString = Console.ReadLine();
            if (inputString.ToUpper() == "H")
            {
                Console.WriteLine("Heads");
            }
            else if (inputString.ToUpper() == "T")
            {
                Console.WriteLine("Tails");
            }

        } while (!inputString .ToUpper().Equals("Q"));
        
     }
      
        static public void Even_Or_Odds()
        {


        }
    }//eom
}
