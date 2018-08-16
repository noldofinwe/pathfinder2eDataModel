using ConsoleApp1.Model;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    [Serializable]
    public class Character
    {

        public string Name { get; set; }

        public Stats Str { get; set; }
        public Stats Dex { get; set; }
        public Stats Con { get; set; }
        public Stats Wis { get; set; }
        public Stats Int { get; set; }
        public Stats Cha { get; set; }

        public Ancestry Ancestry { get; set; }
        public PlayerClass PlayerClass { get; set; }

        public Dictionary<string, Skill> skills = new Dictionary<string, Skill>();

        public Character(string name)
        {
            Name = name;

            Str = new Stats();
            Dex = new Stats();
            Con = new Stats();
            Wis = new Stats();
            Int = new Stats();
            Cha = new Stats();

            Str.Add("base", 10);
            Dex.Add("base", 10);
            Con.Add("base", 10);
            Wis.Add("base", 10);
            Int.Add("base", 10);
            Cha.Add("base", 10);

            // Todo: create initial skills
        }

        public void Add(Ancestry ancestry)
        {
            Ancestry = ancestry;
            foreach (var boost in ancestry.Boosts)
            {
                Boost(boost, "ancestry", 2);
            }

            foreach (var flaw in ancestry.Flaws)
            {
                Boost(flaw, "ancestryFlaw", -2);
            }
        }

        public void Add(Background background)
        {
            skills.Add(string.Format("Lore ({0})", background.LoreSkill), new Skill(Proficiency.Trained, AbilityScoreSelection.Int, true));
            // Todo: Add Background ability and feat
        }

        public void Add(PlayerClass playerClass)
        {
            PlayerClass = playerClass;
            Boost(playerClass.KeyAbilityScore, "keyClassAbility", 2);
            // Todo: set skills
        }

        private void Boost(AbilityScoreSelection boost, string name, int value)
        {
            switch (boost)
            {
                case AbilityScoreSelection.Str:
                    Str.Add(name, value);
                    break;
                case AbilityScoreSelection.Dex:
                    Dex.Add(name, value);
                    break;
                case AbilityScoreSelection.Con:
                    Con.Add(name, value);
                    break;
                case AbilityScoreSelection.Wis:
                    Wis.Add(name, value);
                    break;
                case AbilityScoreSelection.Int:
                    Int.Add(name, value);
                    break;
                case AbilityScoreSelection.Cha:
                    Cha.Add(name, value);
                    break;
            }
        }

      
    }
}
