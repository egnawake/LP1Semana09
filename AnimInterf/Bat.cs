namespace AnimInterf
{
    public class Bat : Animal
    {
        public override string Sound()
        {
            base.Sound() + "Cheep cheep";
        }
    }
}
