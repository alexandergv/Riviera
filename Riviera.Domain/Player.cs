namespace Riviera.Domain
{
    public class Player : SouledEntityBase
    {
        public List<ISkill> Skills { get; set; } = new List<ISkill>();

        public int PosX { get; set; } = 1;
        public int PosY { get; set; } = 1;
    }
}