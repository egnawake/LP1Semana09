namespace AnimInterf
{
    public class Bat : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Cheep cheep";
        }
    }
}
