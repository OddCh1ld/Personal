using BalloonMaker.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloonMaker
{
    /// <summary>
    /// First Version
    /// </summary>
    class Program
    {     //comment

        public static void Main(string[] args)
        {
            List<Balloon> PartyDecorations = new List<Balloon>();
            string userInput = "";
            string inputColor = "";
            string inputSize = "";
            int inputPsi = 0;

            while (userInput != "pop it")
            {
                Console.WriteLine("Would you like to 'create', see your 'bouquet', or 'pop it'?");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "create")
                {
                    try
                    {
                        Console.WriteLine("Pick a color: 'blue', 'red', 'green', 'orange', 'pink', 'yellow', 'black', or 'purple'?"); // Limit color choices to a set list to prevent random user input
                        inputColor = Console.ReadLine().ToLower();

                        Console.WriteLine("Pick a size: 'large', 'medium', or 'small'?");
                        inputSize = Console.ReadLine().ToLower();

                        Console.WriteLine("How much air does the balloon need? Enter a psi.");
                        bool psicheck;
                        psicheck = int.TryParse(Console.ReadLine(), out inputPsi); //check old code for successful try parse
                        if (psicheck)
                        {

                            Balloon inputBalloon = new Balloon(inputColor, inputSize, inputPsi);

                            PartyDecorations.Add(inputBalloon);
                        }
                        else
                        {
                            throw new ArgumentException("Please use a valid input format", "psicheck");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                if (userInput == "bouquet")
                {
                    foreach (Balloon balloon in PartyDecorations)
                    {
                        Console.WriteLine(balloon.ToString());
                    }
                }
            }
        }
    }
}

