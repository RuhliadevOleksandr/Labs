using System;
using System.Text;

namespace Bridge
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;


            Animal owl = new TawnyOwl( new GroupLifestyle(
                                                            WaysOfEating.Carnivorous, 
                                                            WaysOfLiving.Nocturnal,
                                                            AnimalGroups.Family
                                                           ) );

            Console.WriteLine(owl);

            Console.WriteLine();
            
            Animal hare = new WhiteHare( new SolitaryLifestyle(
                                                               WaysOfEating.Herbivorous,
                                                               WaysOfLiving.Crepuscular
                                                              ) );

            Console.WriteLine(hare);

            Console.ReadKey();
        }
    }
}
