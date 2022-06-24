using System;

namespace Composite
{
    public class Program
    {
        static void Main()
        {
            Environment meadow = new Environment("Meadow");
            meadow.Add(new WhiteHare());


            Environment wood = new Environment("Wood");
            wood.Add(new TawnyOwl());
            wood.Add(meadow);

            Console.WriteLine($"\nEating:\n{wood.WaysOfEating()}");
            Console.WriteLine($"\nLiving:\n{wood.WaysOfLiving()}");

            Console.ReadKey();
        }
    }
}
