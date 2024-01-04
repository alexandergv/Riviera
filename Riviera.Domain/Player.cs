namespace Riviera.Domain
{
    public class Player : SouledEntityBase
    {
        public List<ISkill> Skills { get; set; } = new List<ISkill>();
    }
}