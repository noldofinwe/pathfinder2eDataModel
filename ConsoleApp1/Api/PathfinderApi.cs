using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Api
{
    public class PathfinderApi : IPathfinderApi
    {
        public Character CreateCharacter(string name)
        {
            var character = new Character(name);
            PathfinderModel.AddCharacter(name, character);
            return character;
        }

        public Ancestry[] GetAncestry()
        {
            return PathfinderModel.AncestryList.ToArray();
        }

        public Feat[] GetFeats()
        {
            return PathfinderModel.FeatList.ToArray();
        }

        public Character SetAncestry(string name, string ancestry)
        {
            var character = PathfinderModel.GetCharacter(name);
            var anc = PathfinderModel.GetAncestry(ancestry);
            character.Add(anc);

            return character;
        }
    }
}
