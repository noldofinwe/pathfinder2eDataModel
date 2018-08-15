using ConsoleApp1.Model;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    [Serializable]
    public class Feat
    {
        public int Id;
        public string Name;
        public int Level;
        public FeatType FeatType;
        public string FeatSubType;
        public List<string> Traits;
        public string Prerequisites;
        public string Frequency;
        public string Cost;
        public string Trigger;
        public string Requirements;
        public string Description;
        public string Special;

        public Feat(int id, string name, int level, FeatType featType, string featSubType, List<string> traits, string pre, string fre, string cost, string trigger, string req, string desc, string spec)
        {
            Id = id;
            Name = name;
            Level = level;
            FeatType = featType;
            FeatSubType = featSubType;
            Traits = traits;
            Prerequisites = pre;
            Frequency = fre;
            Cost = cost;
            Trigger = trigger;
            Requirements = req;
            Description = desc;
            Special = spec;
        } 
    }
}