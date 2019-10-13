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

            DelegateClass.SortList(vinnare, DelegateClass.ByNationality);
            Console.ReadLine();

            //RunProgram();
        }

        
        static void RunProgram()
        {
            do
            {
                Console.Clear();
                Display.DisplayList(vinnare);
                FilterClass.FilterPlayers(vinnare);
            } while (PlayAgainUserInput == "Y");
        }
        
            

    }
}
