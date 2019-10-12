using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExerciseProject
{
   public class FWPWinners : IGBWinners, IEnumerable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int WinningYear { get; set; }
        public string Nationality { get; set; }
        public string Club { get; set; }
        public Enum.WhatPrize WhatPrize { get; set; }

        public FWPWinners(string _club, string _firstName, string _lastName, string _nationality, int _winningYear, Enum.WhatPrize whatPrize)
        {
            WinningYear = _winningYear;
            FirstName = _firstName;
            LastName = _lastName;
            Nationality = _nationality;
            Club = _club;
            WhatPrize = whatPrize;
        }
        public FWPWinners()
        {

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
