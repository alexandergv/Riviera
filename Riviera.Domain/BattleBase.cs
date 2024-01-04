using static Riviera.Domain.Helpers.MessageHelper;

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

        public bool InitializeBattle()
        {
            bool playerWin = false;

            while (_Enemy.HP > 0 == _Player.HP > 0)
            {
                Console.Clear();
                
                Msg("Battle Initialized---------");
                Msg($"{_Enemy.Name}'s HP: {_Enemy.HP}");
                Msg($"{_Player.Name}'s HP: {_Player.HP}");

                Msg("Your turn---------");


                if (KeyPressed(ConsoleKey.A)) 
                {
                    int damageDealt = 2;
                    _Enemy.HP -= damageDealt;


                    Console.Clear();
                    Msg("Battle Initialized---------");
                    Msg($"{_Enemy.Name}'s HP: {_Enemy.HP}");
                    Msg($"{_Player.Name}'s HP: {_Player.HP}"); 

                    Msg($"Enemy {_Enemy.Name} received -{damageDealt} damage!");



                    Thread.Sleep(1000);
                    damageDealt = 1;
                    _Player.HP -= damageDealt;
                    
                    Msg($"{_Player.Name} received -{damageDealt} damage!");

                    Thread.Sleep(1000);
                }


            }

            if(_Player.HP > 0 )
                playerWin = true;

            return playerWin;
        }

    }
}
