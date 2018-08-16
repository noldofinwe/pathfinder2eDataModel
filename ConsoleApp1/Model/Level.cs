using System;
using System.Collections.Generic;

namespace ConsoleApp1.Model
{
    [Serializable]
    public class Level
    {
        public List<object> Bonusses = new List<object>();

        public Level(List<object> bonusses)
        {
            Bonusses = bonusses;
        }
    }
}