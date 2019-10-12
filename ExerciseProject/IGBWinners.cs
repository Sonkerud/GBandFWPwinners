namespace ExerciseProject
{
    public interface IGBWinners
    {
        string Club { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Nationality { get; set; }
        int WinningYear { get; set; }
        public Enum.WhatPrize WhatPrize { get; set; }


       
    }
}