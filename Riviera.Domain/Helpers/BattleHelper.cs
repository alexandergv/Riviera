
using System.Text;

namespace Riviera.Domain.Helpers
{
    public static class BattleHelper
    {
        public static void ShowPlayerSkills(Player player)
        {
            if (player.Skills.Count < 1) 
                throw new Exception("Player has no Skills to be shown.");

            MessageHelper.Msg($"{player.Name}'s skills: ");
            var skillsText = new StringBuilder();

            for (int i =0; i < player.Skills.Count ; i++)
            {
                skillsText.Append($"{player.Skills[i].Name} [{i}] ");
            }

            MessageHelper.Msg(skillsText.ToString());
        }

        public static int CheckSkillUsed(Player player, ConsoleKeyInfo key)
        {
            int result = -1;

            if (!int.TryParse(key.KeyChar.ToString(), out int keyNumber))
                return result;

            if ((player.Skills.Count - 1) >= keyNumber && player.Skills[keyNumber] != null)
                result = keyNumber;

            return result;
        }

        public static int GetDamageDealt(SouledEntityBase attacker, SouledEntityBase defender, ISkill skill)
        {
            int damageDealt;

            damageDealt = (skill.Power + attacker.Attack) - defender.Defense;

            if (damageDealt < 0) 
            {
                damageDealt = 1;
            }


            return damageDealt;
        }
    }
}
