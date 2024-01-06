using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riviera.Domain.Helpers
{
    public static class MenuHelper
    {
        public static bool IsOpenMenu(ConsoleKeyInfo key, Player player)
        {
            bool result = false;

            if(key.Key == ConsoleKey.I)
            {
                OpenMenu(player);
            }

            return result;
        }

        public static void OpenMenu(Player player)
        {

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                MessageHelper.Msg("x---- Menu ----x", options: new { marginTop = 4 });
                Console.ResetColor();

                MessageHelper.Msg($"< {player.Name}'s Stats >", options: new { marginTop = 2 });
                MessageHelper.Msg($"Level: {player.Level}", options: new { marginTop = 1 });
                MessageHelper.Msg($"Health Points: {player.HP}", options: new { marginTop = 1 });
                MessageHelper.Msg($"Attack: {player.Attack}", options: new { marginTop = 1 });
                MessageHelper.Msg($"Defense: {player.Defense}", options: new { marginTop = 1 });
                
                Console.ForegroundColor = ConsoleColor.Red;
                MessageHelper.Msg($"Skills", options: new { marginTop = 3 });
                Console.ResetColor();

                var skillsText = new StringBuilder();

                for (int i = 0; i < player.Skills.Count; i++)
                {
                    skillsText.Append($"{player.Skills[i].Name} [{i}] ");
                }

                MessageHelper.Msg(skillsText.ToString());
                MessageHelper.Msg($"Press X to get out of the Menu.", options: new { marginTop = 8 });
                if (Console.ReadKey(false).Key == ConsoleKey.X)
                    break;
            }
        }
    }
}
