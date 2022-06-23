using System.Collections.Generic;

namespace Builder
{
    public class DataContext
    {
        public List<string> CompanyNames => new List<string>()
        {
            "watson",
            "kaye"
        };

        public List<Person> CompanyDirectors => new List<Person>()
        {
            new Person()
            {
                FirstName = "Nathan",
                LastName = "Watson"
            },
            new Person()
            {
                FirstName = "Mercia",
                LastName = "Kaye"
            }
        };

        public List<Person> Employers => new List<Person>()
        {
            new Person()
            {
                FirstName = "Angie",
                LastName = "Kilgore"
            }
        };

        public List<Developer> TeamLeads => new List<Developer>()
        {
            new Developer()
            {
                FirstName = "Kristina",
                LastName = "Hughes",
                Level = DeveloperLevel.Senior
            },
            new Developer()
            {
                FirstName = "Leon",
                LastName = "Trenton",
                Level = DeveloperLevel.Senior
            }
        };

        public List<List<Developer>> Developers => new List<List<Developer>>()
        {
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
                }
            },
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
            }
        };
    }
}
