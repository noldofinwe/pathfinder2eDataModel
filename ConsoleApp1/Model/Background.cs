using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    [Serializable]
    public class Background
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<AbilityScoreSelection> Selection = new List<AbilityScoreSelection>();
        public int SkillFeat { get; set; }

        public string LoreSkill { get; set; }

        public Background(string name, string description, int skillFeat, string loreSkill, List<AbilityScoreSelection> selection)
        {
            Name = name;
            Description = description;
            SkillFeat = skillFeat;
            LoreSkill = loreSkill;
            Selection = selection;
        }
    }
}
