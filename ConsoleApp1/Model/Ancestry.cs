using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    public class Ancestry
    {
        public string Name;
        public int Hitpoints;
        public int Speed;
        public Size Size;
        
        public List<AbilityScoreSelection> Boosts = new List<AbilityScoreSelection>();
        public List<AbilityScoreSelection> Flaws = new List<AbilityScoreSelection>();
        public List<string> Languages = new List<string>();
        public List<string> Traits = new List<string>();
        public List<int> Features = new List<int>();
        public List<int> PossibleAncestryFeats = new List<int>();

        public Ancestry(string name,
                         int hitpoints,
                         Size size,
                         int speed,
                         List<AbilityScoreSelection> boosts,
                         List<AbilityScoreSelection> flaws,
                         List<string> languages,
                         List<string> traits,
                         List<int> features,
                         List<int> possibleAncestryFeats)
        {
            Name = name;
            Hitpoints = hitpoints;
            Size = size;
            Speed = speed;
            Boosts = boosts;
            Flaws = flaws;
            Languages = languages;
            Traits = traits;
            Features = features;
            PossibleAncestryFeats = possibleAncestryFeats;
        }
    }
}
