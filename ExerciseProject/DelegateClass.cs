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


        public static List<IGBWinners> SortListWithDelegate(List<IGBWinners> list, SortDelegate delle)
        {
           return delle(list);
        }

        public static List<IGBWinners> FilterListWithDelegate(List<IGBWinners> list, FilterDelegate delle, string input)
        {
            return delle(list,input);
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

    }
}
