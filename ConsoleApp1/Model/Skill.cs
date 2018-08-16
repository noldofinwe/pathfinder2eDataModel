using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    [Serializable]
    public class Skill : ProficiencyStat
    {
        public bool Signature;
        public Skill(Proficiency proficiency, AbilityScoreSelection mainAbility, bool signature) :base(proficiency, mainAbility)
        {
            Signature = signature;
        }
    }
}
