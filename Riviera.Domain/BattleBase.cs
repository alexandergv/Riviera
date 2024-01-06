using static Riviera.Domain.Helpers.MessageHelper;
using static Riviera.Domain.Helpers.BattleHelper;


namespace Riviera.Domain
{
    public class BattleBase
    {
        private Player _Player = new();
        private Enemy _Enemy = new();

        public BattleBase(Player player, Enemy enemy)
        {
            _Player = player;
            _Enemy = enemy;
        }

        public bool BeginBattle()
        {
            bool playerWin = false;


            Console.Clear();

            ShowCenteredMsg("Enemy Encountered!", ConsoleColor.Black, ConsoleColor.Red);

            while (_Enemy.HP > 0 == _Player.HP > 0)
            {
                Console.Clear();

                Msg("Battle Initialized---------");
                Msg($"{_Enemy.Name}'s HP: {(_Enemy.HP > 0 ? _Enemy.HP : 0)}");
                Msg($"{_Player.Name}'s HP: {(_Player.HP > 0 ? _Player.HP : 0)}");

                Msg("Your turn---------");
                ShowPlayerSkills(_Player);

                var skillUsed = CheckSkillUsed(_Player, Console.ReadKey());

                if (skillUsed >= 0) 
                {
                    int damageDealt = GetDamageDealt(_Player, _Enemy, _Player.Skills[skillUsed]);
                    _Enemy.HP -= damageDealt;


                    Console.Clear();
                    Msg("Battle Initialized---------");
                    Msg($"{_Enemy.Name}'s HP: {(_Enemy.HP > 0 ? _Enemy.HP : 0)}");
                    Msg($"{_Player.Name}'s HP: {(_Player.HP > 0 ? _Player.HP : 0)}");

                    Msg($"Enemy {_Player.Name} used {_Player.Skills[skillUsed].Name}!");
                    Msg($"Enemy {_Enemy.Name} received -{damageDealt} damage!");



                    Thread.Sleep(1000);
                    damageDealt = 1;
                    _Player.HP -= damageDealt;
                    
                    Msg($"{_Player.Name} received -{damageDealt} damage!");

                    Thread.Sleep(1000);
                }


            }

            // Player Won
            if(_Player.HP > 0 ) 
            {
                playerWin = true;
                int expGained = _Enemy.GiveExperience();

                bool LeveledUp = _Player.GainExp(expGained);

                Msg($"{_Player.Name} gained {expGained} exp. points!");
                if (LeveledUp)
                {
                    Msg($"{_Player.Name} Leveled Up to {_Player.Level}!");
                }

                Thread.Sleep(1500);
            }

            return playerWin;
        }

    }
}
