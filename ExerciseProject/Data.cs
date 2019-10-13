using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseProject
{
    public class Data
    {
        public static void AddData(List<IGBWinners> vinnare)
        {

            vinnare.Add(new GBWinners("Barcelona", "Johan", "Cruyff", "Netherlands", 1974, Enum.WhatPrize.GoldenBall));

            vinnare.Add(new GBWinners { WinningYear = 1990, FirstName = "Lothar", LastName = "Matthäus", Nationality = "Germany", Club = "Inter", WhatPrize = Enum.WhatPrize.GoldenBall });
            vinnare.Add(new GBWinners { WinningYear = 1991, FirstName = "Jean-Pierre", LastName = "Papin", Nationality = "France", Club = "Marseille", WhatPrize = Enum.WhatPrize.GoldenBall });
            vinnare.Add(new GBWinners { WinningYear = 1992, FirstName = "Marco", LastName = "Van Basten", Nationality = "Netherlands", Club = "Milan", WhatPrize = Enum.WhatPrize.GoldenBall });
            vinnare.Add(new GBWinners { WinningYear = 1993, FirstName = "Roberto", LastName = "Baggio", Nationality = "Italy", Club = "Juventus", WhatPrize = Enum.WhatPrize.GoldenBall });
            vinnare.Add(new GBWinners { WinningYear = 1994, FirstName = "Hristo", LastName = "Stoichkov", Nationality = "Bulgaria", Club = "Barcelona", WhatPrize = Enum.WhatPrize.GoldenBall });
            vinnare.Add(new GBWinners { WinningYear = 1995, FirstName = "George", LastName = "Weah", Nationality = "Liberia", Club = "Milan", WhatPrize = Enum.WhatPrize.GoldenBall });
            vinnare.Add(new GBWinners { WinningYear = 1996, FirstName = "Matthias", LastName = "Sammer", Nationality = "Germany", Club = "Dortmund", WhatPrize = Enum.WhatPrize.GoldenBall });
            vinnare.Add(new GBWinners { WinningYear = 1997, FirstName = "Ronaldo", LastName = "de Lima", Nationality = "Brazil", Club = "Barcelona", WhatPrize = Enum.WhatPrize.GoldenBall });
            vinnare.Add(new GBWinners { WinningYear = 1998, FirstName = "Zinedine", LastName = "Zidane", Nationality = "France", Club = "Juventus", WhatPrize = Enum.WhatPrize.GoldenBall });
            vinnare.Add(new GBWinners { WinningYear = 1999, FirstName = "Rivaldo", LastName = "Ferreira", Nationality = "Brazil", Club = "Barcelona", WhatPrize = Enum.WhatPrize.GoldenBall });

            vinnare.Add(new FWPWinners { WinningYear = 1991, FirstName = "Lothar", LastName = "Matthäus", Nationality = "Germany", Club = "Inter", WhatPrize = Enum.WhatPrize.FifaWorldPlayer });
            vinnare.Add(new FWPWinners { WinningYear = 1992, FirstName = "Marco", LastName = "Van Basten", Nationality = "Netherlands", Club = "Milan", WhatPrize = Enum.WhatPrize.FifaWorldPlayer });
            vinnare.Add(new FWPWinners { WinningYear = 1993, FirstName = "Roberto", LastName = "Baggio", Nationality = "Italy", Club = "Juventus", WhatPrize = Enum.WhatPrize.FifaWorldPlayer });
            vinnare.Add(new FWPWinners { WinningYear = 1994, FirstName = "Romario", LastName = "de Souza Faria", Nationality = "Brazil", Club = "Barcelona", WhatPrize = Enum.WhatPrize.FifaWorldPlayer });
            vinnare.Add(new FWPWinners { WinningYear = 1995, FirstName = "George", LastName = "Weah", Nationality = "Liberia", Club = "Milan", WhatPrize = Enum.WhatPrize.FifaWorldPlayer });
            vinnare.Add(new FWPWinners { WinningYear = 1996, FirstName = "Ronaldo", LastName = "de Lima", Nationality = "Brazil", Club = "Barcelona", WhatPrize = Enum.WhatPrize.FifaWorldPlayer });
            vinnare.Add(new FWPWinners { WinningYear = 1997, FirstName = "Ronaldo", LastName = "de Lima", Nationality = "Brazil", Club = "Inter", WhatPrize = Enum.WhatPrize.FifaWorldPlayer });
            vinnare.Add(new FWPWinners { WinningYear = 1998, FirstName = "Zinedine", LastName = "Zidane", Nationality = "France", Club = "Juventus", WhatPrize = Enum.WhatPrize.FifaWorldPlayer });
            vinnare.Add(new FWPWinners { WinningYear = 1999, FirstName = "Rivaldo", LastName = "Ferreira", Nationality = "Brazil", Club = "Barcelona", WhatPrize = Enum.WhatPrize.FifaWorldPlayer });

        }

        public static void AddPlayerToList(List<IGBWinners> list)
        {
            Console.WriteLine("Lägg till ny vinnare. Välj 1 för Ballon d'or. Välj 2 för Fifa World Player");
            int choice = FilterClass.ValidateIntervalInput(1, 2, "Välj en siffra mellan 1-2");

            switch (choice)
            {
                case 1:
                    {
                        IGBWinners player = new GBWinners();
                        player.WhatPrize = Enum.WhatPrize.GoldenBall;
                        AddPlayerInput(player);
                        list.Add(player);
                        break;
                    }
                case 2:
                    {
                        IGBWinners player = new FWPWinners();
                        player.WhatPrize = Enum.WhatPrize.FifaWorldPlayer;
                        AddPlayerInput(player);
                        list.Add(player);
                        break;
                    }
                    
            }
        }

        public static void AddPlayerInput(IGBWinners player)
        {
            Console.WriteLine("Förnamn:");
            player.FirstName = Console.ReadLine();
            Console.WriteLine("Efternamn:");
            player.LastName = Console.ReadLine();
            Console.WriteLine("Nationalitet:");
            player.Nationality = Console.ReadLine();
            Console.WriteLine("Årtal:");
            player.WinningYear = FilterClass.ValidateIntInput("Ange ett årtal, fyra siffror");
            Console.WriteLine("Klubblag:");
            player.Club = Console.ReadLine();
        }

    }
}
