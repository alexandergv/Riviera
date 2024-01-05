
namespace Riviera.Domain.Location
{
    public class FirstWorld : LocationBase
    {
        public FirstWorld() 
        {
            this.HeaderMessage = "Welcome to Riviera again!, you're in the forest.";
            this.CanEncounterEnemies = true;
            this.GotoMessage = "First World";
            this.Choices.Add(new ForestLake());
        }
    }
}
