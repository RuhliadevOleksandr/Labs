using System;
using System.Text;

namespace Builder
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;


            SmallBuilder smallCompany = new SmallBuilder();

            Director director = new Director(smallCompany);

            director.PerformBuild();

            SmallCompany small = smallCompany.Build();


            MediumBuilder mediumCompany = new MediumBuilder();

            director = new Director(mediumCompany);

            director.PerformBuild();

            MediumCompany medium = mediumCompany.Build();


            Console.WriteLine($"Невелика компанія: {small}");
            Console.WriteLine($"Середня компанія: {medium}");

            Console.ReadKey();
        }
    }
}
