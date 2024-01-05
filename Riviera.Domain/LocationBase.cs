using Riviera.Domain.Events;
using System.Text;

namespace Riviera.Domain
{
    public abstract class LocationBase
    {
        private int _Width { get; set; }
        private int _Height { get; set; }
        public string  GotoMessage { get; set; }
        public string  HeaderMessage { get; set; }
        public int EnemyRate { get; set; } = 0;
        public bool CanEncounterEnemies { get; set; } = false;
        public List<LocationBase> Choices { get; set; } = new List<LocationBase>();
        public List<LocationEvent> LocationEvents { get; set; } = new List<LocationEvent>();
        public StringBuilder LocationImage { get; set; } = new StringBuilder();
    }
}
