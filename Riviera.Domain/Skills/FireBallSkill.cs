using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riviera.Domain.Skills
{
    public class FireBallSkill: Skill<FireBallSkill>
    {
        public FireBallSkill()
        {
            this.Name = "FireBall";
            this.Power = 5;
            this.ElementType = Element.ElementType.Fire;
        }

    }
}
