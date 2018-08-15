using System;
using System.Collections.Generic;
using System.Text;

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
        }

        internal void Add(Ancestry ancestry)
        {
            Ancestry = ancestry;
            foreach (var boost in ancestry.Boosts)
            {
                switch (boost)
                {
                    case AbilityScoreSelection.Str:
                        Str.Add("ancestry", 2);
                        break;
                    case AbilityScoreSelection.Dex:
                        Dex.Add("ancestry", 2);
                        break;
                    case AbilityScoreSelection.Con:
                        Con.Add("ancestry", 2);
                        break;
                    case AbilityScoreSelection.Wis:
                        Wis.Add("ancestry", 2);
                        break;
                    case AbilityScoreSelection.Int:
                        Int.Add("ancestry", 2);
                        break;
                    case AbilityScoreSelection.Cha:
                        Cha.Add("ancestry", 2);
                        break;
                }
            }

            foreach (var flaw in ancestry.Flaws)
            {
                switch (flaw)
                {
                    case AbilityScoreSelection.Str:
                        Str.Add("ancestryFlaw", -2);
                        break;
                    case AbilityScoreSelection.Dex:
                        Dex.Add("ancestryFlaw", -2);
                        break;
                    case AbilityScoreSelection.Con:
                        Con.Add("ancestryFlaw", -2);
                        break;
                    case AbilityScoreSelection.Wis:
                        Wis.Add("ancestryFlaw", -2);
                        break;
                    case AbilityScoreSelection.Int:
                        Int.Add("ancestryFlaw", -2);
                        break;
                    case AbilityScoreSelection.Cha:
                        Cha.Add("ancestryFlaw", -2);
                        break;
                }
            }


        }
    }
}
