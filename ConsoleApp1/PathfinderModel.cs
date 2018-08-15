using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    public static class PathfinderModel
    {
        public static List<Ancestry> AncestryList;
        public static List<Feat> FeatList;
        public static List<Background> BackgroundList;
        public static Dictionary<string, Character> Characters = new Dictionary<string, Character>();
        static PathfinderModel()
        {
            FeatList = GetFeats();
            AncestryList = GetAncestry();
            BackgroundList = GetBackground();
        }

        internal static void AddCharacter(string name, Character character)
        {
            Characters.Add(name, character);
        }

        private static List<Feat> GetFeats()
        {
            var dir = "Data\\Feat";
            var files = Directory.GetFiles(dir);
            var list = new List<Feat>();
            foreach (var file in files)
            {
                using (StreamReader reader = File.OpenText(file))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    var feat = (Feat)serializer.Deserialize(reader, typeof(Feat));
                    list.Add(feat);
                }
            }
            return list;
        }

        internal static Ancestry GetAncestry(string ancestry)
        {
            return AncestryList.FirstOrDefault(p => p.Name == ancestry);
        }

        internal static Character GetCharacter(string name)
        {
            return Characters[name];
        }

        private static List<Ancestry> GetAncestry()
        {
            var dir = "Data\\Ancestry";
            var files = Directory.GetFiles(dir);
            var list = new List<Ancestry>();
            foreach (var file in files)
            {
                using (StreamReader reader = File.OpenText(file))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    var feat = (Ancestry)serializer.Deserialize(reader, typeof(Ancestry));
                    list.Add(feat);
                }
            }
            return list;
        }

        private static List<Background> GetBackground()
        {
            var dir = "Data\\Background";
            var files = Directory.GetFiles(dir);
            var list = new List<Background>();
            foreach (var file in files)
            {
                using (StreamReader reader = File.OpenText(file))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    var feat = (Background)serializer.Deserialize(reader, typeof(Background));
                    list.Add(feat);
                }
            }
            return list;
        }
    }
}
