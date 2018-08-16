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
        public FeatAction FeatAction;
        
        public string FeatSubType;
        public List<string> Traits;
        public List<int> Prerequisites;
        public string PrerequisitesText;
        
        public string Frequency;
        public string Cost;
        public string Trigger;
        public string Requirements;
        public string Description;
        public string Special;

        public Feat(int id, string name, int level, FeatType featType, FeatAction featAction, string featSubType, List<string> traits, List<int> pre, string preText, string fre, string cost, string trigger, string req, string desc, string spec)
        {
            Id = id;
            Name = name;
            Level = level;
            FeatType = featType;
            FeatAction = featAction;
            FeatSubType = featSubType;
            Traits = traits;
            Prerequisites = pre;
            PrerequisitesText = preText;
            Frequency = fre;
            Cost = cost;
            Trigger = trigger;
            Requirements = req;
            Description = desc;
            Special = spec;
        } 
    }
}