namespace AnimInterf
{
    public class Bee : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Bzzz bzzz";
        }
    }
}
