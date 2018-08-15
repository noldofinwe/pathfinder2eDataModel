namespace ConsoleApp1.Model
{
    public class ProficiencyStat
    {
        public Proficiency Proficiency { get; set; }

        public AbilityScoreSelection MainAbility { get; set; }

        public ProficiencyStat(Proficiency proficiency, AbilityScoreSelection mainAbility)
        {
            Proficiency = Proficiency;
            MainAbility = mainAbility;
        }
    }
}
