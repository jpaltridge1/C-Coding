using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePortfolio04_JeffPaltridge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int trackTotal;
            

            Console.WriteLine("Welcome to the Unicorn Racing Game!");
            Console.WriteLine();


            trackTotal = GetVailidPositiveInterger();

            DrawTrack();

            DrawCharacters();

            GenerateRandomDieValue();

            GetValidCharacter();


            







        }

        private static int GetVailidPositiveInterger()
        {
            string trackLengthInput = "";
            int trackLength = 0;
            bool trackLengthExit = false;


            
            

            do
            {
                Console.Write("Enter the length of the track: ");
                trackLengthInput = Console.ReadLine();
                int.TryParse(trackLengthInput, out trackLength);

                if  (trackLength > 0)
                {
                    trackLengthExit = true;
                }

                else
                {
                    Console.WriteLine("Error: must provide an integer > 0.");
                    trackLengthExit = false;
                }

            } while (trackLengthExit == false);
                return trackLength;
        }

        private static void DrawTrack()
        {
            throw new NotImplementedException();
        }

        private static void DrawCharacters()
        {
            throw new NotImplementedException();
        }

        private static void GenerateRandomDieValue()
        {
            throw new NotImplementedException();
        }

        private static void GetValidCharacter()
        {
            throw new NotImplementedException();
        }

        
        
       
       
    }
}
