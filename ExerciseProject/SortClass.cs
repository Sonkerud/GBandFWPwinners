using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseProject
{
    public class SortClass
    {
        static public void SortPlayers(List<IGBWinners> vinnare)
        {
            Console.WriteLine("\n1. Välj 1 för att sortera på nationalitet\n2. Välj 2 för att sortera på årtal\n3. " +
                              "Välj 3 för att sortera på typ av pris\n4. Välj 4 för att lägga till en ny spelare\n5. Välj 5 för att visa listan\nVal:");
            while (vinnare.Count != 0)
            {
                vinnare = Switchen(vinnare);

                if (vinnare.Count != 0)
                {
                    Display.ChoseAgain();
                }
                else
                {
                    Console.WriteLine("Listan är tom. Starta om? (Y)es/(N)o");
                    Program.yes = Console.ReadLine();
                }
            }
            
        }

        static List<IGBWinners> Switchen(List<IGBWinners> list)
        {

            int choice = ValidateIntInput("Ange en siffra mellan 1-3");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nVälj nationalitet: ");
                    string nationality = Console.ReadLine();
                    var listSortedByNationality = list.Where(x => x.Nationality.ToLower() == nationality.ToLower()).ToList();
                    Display.DisplayList(listSortedByNationality);
                    
                    return listSortedByNationality;

                case 2:
                    Console.WriteLine("\nFrån och med: ");
                    int startYear = ValidateIntervalInput(1990,2000,"Ange ett årtal mellan 1990 och 2000");
                    Console.WriteLine("Till: ");
                    int endYear = ValidateIntervalInput(1990,2000,"Ange ett årtal mellan 1990 och 2000");
                    var listSortedByYear = list.Where(x => x.WinningYear >= startYear && x.WinningYear <= endYear).ToList();
                    Display.DisplayList(listSortedByYear);
                    
                    return listSortedByYear;

                case 3:
                    Console.WriteLine("\n1. Ballon d'or \n2. Fifa World Player");
                    int whatPrize = ValidateIntInput("Ange 1 eller 2");
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
                case 4: Data.AddPlayer(list);
                    return list;
                case 5: Display.DisplayList(list);
                    return list;
                default:
                    Console.WriteLine("Felaktigt val. Prova igen");
                    return list;
            }
        }

        public static int ValidateIntInput(string text = "Ange en siffra")
        {
            bool inmatning = false;
            int output = 0;
            while (!inmatning)
            {
                try
                {
                    output = int.Parse(Console.ReadLine());
                    inmatning = true;
                    return output;
                }
                catch
                {
                    Console.WriteLine(text);
                }
            }
            return output;
        }

        public static int ValidateIntervalInput(int _startNumber = 0000, int _endNumber = 3000, string text = "Ange en siffra")
        {
            bool inmatning = false;
            int output = 0;
            while (!inmatning)
            {
                try
                {
                    output = int.Parse(Console.ReadLine());
                    if (output < _startNumber || output > _endNumber)
                    {
                        Console.WriteLine(text);
                    }
                    else
                    {
                        inmatning = true;
                        return output;
                    }
                }
                catch
                {
                    Console.WriteLine(text);
                }
            }
            return output;
        }

    }
}
