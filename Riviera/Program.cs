using Riviera.Domain;
using static Riviera.Domain.Helpers.MessageHelper;




Msg("Hello, welcome to riviera!", true);

Msg("Enter your Name:");

string userName = Console.ReadLine() ?? "Player1";

var player = new Player() 
{
 HP = 20,
 Name = userName,
};

Msg("Battle!");
Msg("An enemy appeared, press A to Attack!");


var battle = new BattleBase(player, Enemy.GenerateEnemy());

var encounterResult = battle.InitializeBattle();

if(encounterResult)
{
    Msg("Good Job winning your first battle!", true);
} else
{
    Msg("Lost in the tutorial...", true);
}