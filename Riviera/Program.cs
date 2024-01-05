using Riviera;
using Riviera.Domain;
using Riviera.Domain.Location;
using Riviera.Domain.Skills;
using static Riviera.Domain.Helpers.MessageHelper;



Msg("Hello, welcome to riviera!", true);

Msg("Enter your Name:");

Console.Write("        ");
string userName = Console.ReadLine() ?? "Player1";

var player = new Player() 
{
 HP = 20,
 Name = userName,
 Attack = 2,
 Defense = 3,
};

// Starting player skill
player.Skills.Add(SwordSlashSkill.GetSkill());

Console.Clear();
Console.WriteLine("        ");


while (true)
{
    Renderer.RenderLocation(new FirstWorld(), player);
}

//Console.ReadKey();


//Msg("Battle!");

//var battle = new BattleBase(player, Enemy.GenerateEnemy());

//var encounterResult = battle.BeginBattle();

//if(encounterResult)
//{
//    Msg("Good Job winning your first battle!", true);
//} else
//{
//    Msg("Lost in the tutorial...", true);
//}