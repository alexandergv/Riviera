using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riviera.Domain
{
    public class Skill<SkillType> : ISkill where SkillType : Skill<SkillType>, new() 
    {
        public string Name { get; set; }

        public int Power { get; set; }

        public Element.ElementType ElementType { get; set; }



        public static SkillType GetSkill()
        {
            var skill = new SkillType();

            return skill;
        }

    }

    public interface ISkill
    {
        public string Name { get; set; }

        public int Power { get; set; }

        public Element.ElementType ElementType { get; set; }
    }
}
