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
            Console.WriteLine("\nFortsätt sortera listan:");
            Console.WriteLine("\n1. Välj 1 för att sortera på nationalitet\n2. Välj 2 för att sortera på årtal\n3. Välj 3 för att sortera på typ av pris\n4. Välj 4 för att lägga till en ny spelare\n5. Välj 5 för att visa listan\nVal:");
        }


        //Methods for delegate - not in use
        public delegate string TestDelegate(IGBWinners gbWinners);

        public static string SortList(List<IGBWinners> list, TestDelegate delle)
        {
            string by = "";
            foreach (var item in list)
            {
                by = delle(item);
                Console.WriteLine($"{item.FirstName} {item.LastName} {by}");
            }
            return by;
        }

        public static IEnumerable<IGBWinners> SortIE (IEnumerable<IGBWinners> GBlist)
        {
            

            foreach (var item in GBlist)
            {
                item.Nationality = "hej";
            }

            return GBlist;
        }

        public static string ByNationality(IGBWinners winners)
        {
            return winners.Nationality;
        }

        public static string ByClub(IGBWinners winners)
        {
            return winners.Club;
        }

        public static string ByName(IGBWinners winners)
        {
            return winners.FirstName + " " + winners.LastName;
        }

    }
}
