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
            RunProgram();
        }

        
        static void RunProgram()
        {
            do
            {
                Console.Clear();
                Display.DisplayList(vinnare);
                SortClass.SortPlayers(vinnare);
            } while (PlayAgainUserInput == "Y");
        }
        
            

    }
}
