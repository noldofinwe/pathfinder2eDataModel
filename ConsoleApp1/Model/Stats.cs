using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    public class Stats
    {
        Dictionary<string, int> bonusses = new Dictionary<string, int>();

        public bool CanAddBonus(string bonus, int value)
        {
            if(bonusses.ContainsKey(bonus))
            {
                return false;
            }
            return true;
        }

        public void Add(string bonus, int value)
        {
            bonusses.Add(bonus, value);
        }

        public override string ToString()
        {
            int sum = 0;
            foreach( var value in bonusses.Values)
            {
                sum = sum + value;
            }
            return string.Format("{0}", sum);
        }
    }
}
