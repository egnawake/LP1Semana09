using System;

namespace AnimInterf
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Animal[] animals = new Animal[10];

            // Generate random animals
            Random rnd = new Random();
            for (int i = 0; i < animals.Length; i++)
            {
                int choice = rnd.Next(4);
                animals[i] = choice switch
                {
                    0 => new Dog(),
                    1 => new Cat(),
                    2 => new Bat(),
                    3 => new Bee(),
                    _ => null
                };
            }

            // Print animal details
            foreach (Animal a in animals)
            {
                Console.WriteLine(a);
                Console.WriteLine(a.Sound());
                
                if (a is IMammal)
                {
                    IMammal mammal = (IMammal)a;
                    Console.WriteLine("Number of nipples: {0}",
                        mammal.NumberOfNipples);
                }

                if (a is ICanFly)
                {
                    ICanFly f = (ICanFly)a;
                    Console.WriteLine("Number of wings: {0}",
                        f.NumberOfWings);
                }

                Console.WriteLine("");
            }
        }
    }
}
