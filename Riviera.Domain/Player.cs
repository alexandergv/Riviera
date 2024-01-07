namespace Riviera.Domain
{
    public class Player : SouledEntityBase
    {
        public List<ISkill> Skills { get; set; } = new List<ISkill>();
        public int CurrentHP { get; set; }
        public int ExperiencePoints { get; set; } = 0;
        public int PosX { get; set; } = 1;
        public int PosY { get; set; } = 1;

        public Player(int hp)
        {
            this.HP = hp;
            this.CurrentHP = hp;
        }


        public void LevelUp()
        {
            this.Level++;
        }


        public bool GainExp(int exp) 
        {
            bool leveledUp = false;

            this.ExperiencePoints += exp;
            int pointsToLvlUp = GetTotalPointsToLvlUp();

            if (this.ExperiencePoints >= pointsToLvlUp)
            {
                this.ExperiencePoints = ExperiencePoints - pointsToLvlUp;
                this.LevelUp();
                leveledUp = true;
            }

            return leveledUp;
        }

        public int GetTotalPointsToLvlUp()
        {
            int basePoints = 60;

            if (this.Level > 1)
                 basePoints = (int)Math.Ceiling(basePoints * (this.Level + 0.5));

            return basePoints;
        }
    }
}