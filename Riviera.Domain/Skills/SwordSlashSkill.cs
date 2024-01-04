using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riviera.Domain.Skills
{
    public class SwordSlashSkill : Skill<SwordSlashSkill>
    {
        public SwordSlashSkill() 
        {
            this.Name = "Sword Slash";
            this.Power = 10;
            this.ElementType = Element.ElementType.Melee;
        }
    }
}
