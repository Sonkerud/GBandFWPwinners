using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseProject
{
    public class DelegateClass
    {
        public delegate List<IGBWinners> SortDelegate(List<IGBWinners> gbWinners);
        public delegate List<IGBWinners> FilterDelegate(List<IGBWinners> gbWinners, string input);

        static public void FilterPlayers(List<IGBWinners> vinnare)
        {
            Console.WriteLine("\nDu använder Delegates\n1. Välj 1 för att filtrera på nationalitet\n2. Välj 2 för att filtrera på årtal\n3. " +
                              "Välj 3 för att filtrera på typ av pris\n4. Välj 4 för att lägga till en ny spelare\n5. Välj 5 för att visa listan\nVal:");
            while (vinnare.Count != 0)
            {
                vinnare = SwitchenDelegate(vinnare);

                if (vinnare.Count != 0)
                {
                    Display.ChoseAgain();
                }
                else
                {
                    Console.WriteLine("Listan är tom. Starta om? (Y)es/(N)o");
                    Program.PlayAgainUserInput = Console.ReadLine();
                }
            }

        }

        public static List<IGBWinners> SortListWithDelegate(List<IGBWinners> list, SortDelegate delle)
        {
           return delle(list);
        }

        public static List<IGBWinners> FilterListWithDelegate(List<IGBWinners> list, FilterDelegate delle, string input)
        {
            return delle(list,input);
        }

        public static List<IGBWinners> SwitchenDelegate(List<IGBWinners> list)
        {

            int choice = FilterClass.ValidateIntInput("Ange en siffra mellan 1-5");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nVälj nationalitet: ");
                    //string nationality = Console.ReadLine();
                    //var listSortedByNationality = FilterListWithDelegate(list, FilterByNationality, nationality);

                    return Display.DisplayList(FilterListWithDelegate(list, FilterByNationality, Console.ReadLine()));

                case 2:
                    Console.WriteLine("\nFrån och med: ");
                    int startYear = FilterClass.ValidateIntervalInput(1990, 2000, "Ange ett årtal mellan 1990 och 2000");
                    Console.WriteLine("Till: ");
                    int endYear = FilterClass.ValidateIntervalInput(1990, 2000, "Ange ett årtal mellan 1990 och 2000");
                    var listSortedByYear = list.Where(x => x.WinningYear >= startYear && x.WinningYear <= endYear).ToList();
                    Display.DisplayList(listSortedByYear);

                    return listSortedByYear;

                case 3:
                    Console.WriteLine("\n1. Ballon d'or \n2. Fifa World Player");
                    int whatPrize = FilterClass.ValidateIntInput("Ange 1 eller 2");
                    var listSortedByPrize = list;
                    if (whatPrize == 1)
                    {
                        listSortedByPrize = list.Where(x => x.WhatPrize == Enum.WhatPrize.GoldenBall).OrderBy(x => x.WinningYear).ToList();
                        Display.DisplayList(listSortedByPrize);

                        return listSortedByPrize;
                    }
                    else if (whatPrize == 2)
                    {
                        listSortedByPrize = list.Where(x => x.WhatPrize == Enum.WhatPrize.FifaWorldPlayer).OrderBy(x => x.WinningYear).ToList();
                        Display.DisplayList(listSortedByPrize);

                        return listSortedByPrize;
                    }
                    else
                    {
                        Console.WriteLine("Ange en siffra mellan 1-3:");

                        return listSortedByPrize;
                    }
                case 4:
                    Data.AddPlayerToList(list);
                    return list;
                case 5:
                    Display.DisplayList(list);
                    return list;
                default:
                    Console.WriteLine("Felaktigt val. Prova igen");
                    return list;
            }
        }


        public static List<IGBWinners> FilterByNationality(List<IGBWinners> winners, string input)
        {
            return winners.Where(x => x.Nationality == input).ToList();
        }

        public static List<IGBWinners> SortByNationality(List<IGBWinners> winners)
        {
            return winners.OrderBy(x => x.Nationality).ToList();
        }

        public static List<IGBWinners> SortByClub(List<IGBWinners> winners)
        {
            return winners.OrderBy(x => x.Club).ToList();
        }

        public static List<IGBWinners> SortByName(List<IGBWinners> winners)
        {
            return winners.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
        }

        public static List<IGBWinners> SortByPrize(List<IGBWinners> winners)
        {
            return winners.OrderBy(x => x.WhatPrize).ThenBy(x => x.WinningYear).ToList();
        }
    }
}
