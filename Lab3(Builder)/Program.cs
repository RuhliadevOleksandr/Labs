using System;
using System.Text;
using System.Collections.Generic;

namespace Builder
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            SmallBuilder smallCompany = new SmallBuilder();

            smallCompany.CreateName("watson");
            smallCompany.AddDirector(
                                     new Person() 
                                     { 
                                         FirstName = "Nathan",
                                         LastName = "Watson"
                                     }
                                    );
            smallCompany.AddDeveloperTeam(
                                            new List<Developer>()
                                            {
                                                new Developer()
                                                {
                                                    FirstName = "Katerina",
                                                    LastName = "Washington",
                                                    Level = DeveloperLevel.Junior
                                                },
                                                new Developer()
                                                {
                                                    FirstName = "Kyle",
                                                    LastName = "Jackson",
                                                    Level = DeveloperLevel.Junior
                                                },
                                                new Developer()
                                                {
                                                    FirstName = "Kyra",
                                                    LastName = "Blaese",
                                                    Level = DeveloperLevel.Middle
                                                },
                                                new Developer()
                                                {
                                                    FirstName = "Richard ",
                                                    LastName = "Ward",
                                                    Level = DeveloperLevel.Middle
                                                },
                                                new Developer()
                                                {
                                                    FirstName = "David",
                                                    LastName = "Fisher",
                                                    Level = DeveloperLevel.Middle
                                                },
                                            },
                                            new Developer()
                                            {
                                                FirstName = "Kristina",
                                                LastName = "Hughes", 
                                                Level = DeveloperLevel.Senior
                                            }
                                         );

            SmallCompany small = smallCompany.Build();

            MediumBuilder mediumCompany = new MediumBuilder();

            mediumCompany.CreateName("kaye");
            mediumCompany.AddDirector(
                                     new Person()
                                     {
                                         FirstName = "Mercia",
                                         LastName = "Kaye"
                                     }
                                    );
            mediumCompany.AddEmployer(
                                      new Person()
                                      {
                                          FirstName = "Angie",
                                          LastName = "Kilgore"
                                      }
                                     );
            mediumCompany.AddDeveloperTeam(
                                            new List<Developer>()
                                            {
                                                new Developer()
                                                {
                                                    FirstName = "Fonseca",
                                                    LastName = "Wilhelmina",
                                                    Level = DeveloperLevel.Middle
                                                },
                                                new Developer()
                                                {
                                                    FirstName = "Garza",
                                                    LastName = "Dunne",
                                                    Level = DeveloperLevel.Junior
                                                },
                                                new Developer()
                                                {
                                                    FirstName = "Kyra",
                                                    LastName = "Tachibana",
                                                    Level = DeveloperLevel.Middle
                                                },
                                                new Developer()
                                                {
                                                    FirstName = "Richard ",
                                                    LastName = "O'Connor",
                                                    Level = DeveloperLevel.Junior
                                                },
                                                new Developer()
                                                {
                                                    FirstName = "Louis",
                                                    LastName = "Kruse",
                                                    Level = DeveloperLevel.Middle
                                                },
                                            },
                                            new Developer()
                                            {
                                                FirstName = "Leon",
                                                LastName = "Trenton",
                                                Level = DeveloperLevel.Senior
                                            }
                                         );

            MediumCompany medium = mediumCompany.Build();

            Console.WriteLine($"Невелика компанія: {small}");
            Console.WriteLine($"Середня компанія: {medium}");

            Console.ReadKey();
        }
    }
}
