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
                MessageHelper.Msg("x ---- Menu ---- x", options: new Menu.MenuOptions(){ MarginTop = 4, TextColor = ConsoleColor.Blue });

                MessageHelper.Msg($"< {player.Name}'s Stats >", options: new Menu.MenuOptions(){ MarginTop = 2 });
                MessageHelper.Msg($"Level: {player.Level}", options: new Menu.MenuOptions(){ MarginTop = 1 });
                MessageHelper.Msg($"Health Points: {player.CurrentHP}/{player.HP}", options: new Menu.MenuOptions(){ MarginTop = 1 });
                MessageHelper.Msg($"Attack: {player.Attack}", options: new Menu.MenuOptions(){ MarginTop = 1 });
                MessageHelper.Msg($"Defense: {player.Defense}", options: new Menu.MenuOptions(){ MarginTop = 1 });
                
                MessageHelper.Msg($"Skills", options: new Menu.MenuOptions(){ MarginTop = 3, TextColor = ConsoleColor.Red });

                var skillsText = new StringBuilder();

                for (int i = 0; i < player.Skills.Count; i++)
                {
                    skillsText.Append($"{player.Skills[i].Name} [{i}] ");
                }

                MessageHelper.Msg(skillsText.ToString());
                MessageHelper.Msg($"Press X to get out of the Menu.", options: new Menu.MenuOptions(){ MarginTop = 8 });
                if (Console.ReadKey(false).Key == ConsoleKey.X)
                    break;
            }
        }
    }
}
