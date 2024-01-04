using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riviera.Domain
{
    public class Enemy
    {
        public  int HP { get; set; }
        public  string Name { get; set; } = "Enemy1";



        public static Enemy GenerateEnemy()
        {
            Enemy enemy = new()
            {
                HP = 10,
                Name = "Serpent"
            };

            return enemy;
        } 
    }
}
