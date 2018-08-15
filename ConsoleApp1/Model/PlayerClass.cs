using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class PlayerClass
    {
        public AbilityScoreSelection KeyAbilityScore { get; set; }
        public int Hitpoints { get; set; }
        public ProficiencyStat Perception { get; set; }
        public ProficiencyStat Fortitude { get; set; }
        public ProficiencyStat Reflex { get; set; }
        public ProficiencyStat Will { get; set; }
    }
}
