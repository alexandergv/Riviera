
namespace Riviera.Domain
{
    public class Enemy : SouledEntityBase
    {

        public static Enemy GenerateEnemy()
        {
            Enemy enemy = new()
            {
                HP = 10,
                Name = "Serpent",
                Defense = 5
            };

            return enemy;
        } 

        public int GiveExperience() 
        {
            int expGiven = 61;

            return expGiven;
        }
    }
}
