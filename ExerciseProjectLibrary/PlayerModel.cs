using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProjectLibrary
{
    public class PlayerModel : IPlayerModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public EnumPosition MyProperty { get; set; }

    }

}
