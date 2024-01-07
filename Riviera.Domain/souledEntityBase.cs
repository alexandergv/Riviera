
namespace Riviera.Domain
{
    public abstract class SouledEntityBase
    {
        public int HP { get; set; } 
        public int CurrentHP { get; set; }
        public string Name { get; set; }
        public int Defense { get; set; }

        public int Attack { get; set; }
        public int Level { get; set; } = 1;
    }
}
