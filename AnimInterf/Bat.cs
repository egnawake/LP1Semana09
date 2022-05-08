namespace AnimInterf
{
    public class Bat : Animal, IMammal
    {
        public int NumberOfNipples { get; } = 2;
        public override string Sound()
        {
            return base.Sound() + "Cheep cheep";
        }
    }
}
