using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riviera.Domain
{
    public abstract class SouledEntityBase
    {
        public int HP { get; set; } 
        public string Name { get; set; }
        public int Defense { get; set; }

        public int Attack { get; set; }
    }
}
