using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExerciseProject
{
    class Program
    {
        static List<IGBWinners> vinnare = new List<IGBWinners>();
        public static string PlayAgainUserInput = "";
                      
        static void Main(string[] args)
        {
            Data.AddData(vinnare);
            ChooseFilterFunction();
           
        }

        static void RunDelegateProgram()
        {
            do
            {
                Console.Clear();
                Display.DisplayList(vinnare);
                DelegateClass.FilterPlayers(vinnare);
            } while (PlayAgainUserInput == "Y");

                        
        }


        static void RunLINQProgram()
        {
            do
            {
                Console.Clear();
                Display.DisplayList(vinnare);
                FilterClass.FilterPlayers(vinnare);
            } while (PlayAgainUserInput == "Y");
        }

        static void ChooseFilterFunction() 
        {
            Console.WriteLine("1. Välj 1 för LINQ\n2. Välj 2 för Delegates");
            int playerInput = FilterClass.ValidateIntervalInput(1,2,"Ange en siffra mellan 1 och 2:");
            switch (playerInput)
            {
                case 1: RunLINQProgram();
                    break;
                case 2: RunDelegateProgram();
                    break;
                default: break;
            }

        }
            

    }
}
