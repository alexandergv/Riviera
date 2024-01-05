using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riviera.Domain.Location
{
    public class ForestLake : LocationBase
    {
        public ForestLake() 
        {
            this.HeaderMessage = "You arrived to a medium-sized lake!, the water looks so clear :)";
            this.CanEncounterEnemies = true;
            this.GotoMessage = "You hear water flowing and feel a cold breeze from over there...";
            this.EnemyRate = 100;
        }
    }
}
