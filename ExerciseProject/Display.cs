using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseProject
{
    public class Display
    {
        public static void DisplayList(List<IGBWinners> vinnare)
        {
            var byYear = vinnare.OrderBy(x => x.WinningYear);
            Console.WriteLine("\n");
            foreach (var winner in byYear)
            {
                Console.WriteLine($"Year: {winner.WinningYear} {winner.FirstName} {winner.LastName} Prize: {winner.WhatPrize} Nationality: {winner.Nationality} Club: {winner.Club}");
            }
        }
        public static void ChoseAgain()
        {
            Console.WriteLine("\nFortsätt filtrera listan:");
            Console.WriteLine("\n1. Välj 1 för att filtrera på nationalitet\n2. Välj 2 för att filtrera på årtal\n3. Välj 3 för att filtrera på typ av pris\n4. Välj 4 för att lägga till en ny spelare\n5. Välj 5 för att visa listan\nVal:");
        }

                    

    }
}
