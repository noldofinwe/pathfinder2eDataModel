using System.Collections.Generic;

namespace ConsoleApp1.Model
{
    public class PlayerClass
    {
        public AbilityScoreSelection KeyAbilityScore { get; set; }
        public int Hitpoints { get; set; }
        public int TrainedSkills { get; set; }
        public string Name { get; set; }
        public ProficiencyStat Perception { get; set; }
        public ProficiencyStat Fortitude { get; set; }
        public ProficiencyStat Reflex { get; set; }
        public ProficiencyStat Will { get; set; }
        public SpellCastingType SpellCastingType { get; set; }
        public List<string> SignatureSkills;
        public Dictionary<string, Proficiency> WeaponArmourProficiencies = new Dictionary<string, Proficiency>();
        public Dictionary<int, Level> LevelUpScheme = new Dictionary<int, Level>();

        public PlayerClass(string name, AbilityScoreSelection keyAbilityScore, int hitpoints, int trainedSkills, 
                            ProficiencyStat perception, ProficiencyStat fortitude, ProficiencyStat reflex, ProficiencyStat will,
                            SpellCastingType spellCastingType, List<string> signatureSkills, Dictionary<string, Proficiency> weaponArmourProficiencies,
                            Dictionary<int, Level> levelUpScheme)
        {
            Name = name;
            KeyAbilityScore = keyAbilityScore;
            Hitpoints = hitpoints;
            TrainedSkills = trainedSkills;
            Perception = perception;
            Fortitude = fortitude;
            Reflex = reflex;
            Will = will;
            SpellCastingType = spellCastingType;
            SignatureSkills = signatureSkills;
            WeaponArmourProficiencies = weaponArmourProficiencies;
            LevelUpScheme = levelUpScheme;

        }
    }
}
