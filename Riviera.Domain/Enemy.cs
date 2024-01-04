using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
