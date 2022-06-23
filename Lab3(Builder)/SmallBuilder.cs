using System.Collections.Generic;
using System.Globalization;

namespace Builder
{
    /// <summary>
    /// Будівельник невеликої компанія
    /// </summary>
    public class SmallBuilder : ICompanyBuilder
    {
        /// <summary>
        /// Директор компанії
        /// </summary>
        private string _companyName;

        /// <summary>
        /// Директор компанії
        /// </summary>
        private IEmployee _companyDirector;

        /// <summary>
        /// Команда розробників
        /// </summary>
        private List<IEmployee> _developerTeam = new List<IEmployee>();

        public void CreateName()
        {
            DataContext data = new DataContext();
            TextInfo textInfo = new CultureInfo("ua-UA", false).TextInfo;
            _companyName = textInfo.ToTitleCase(data.CompanyNames[0]);
        }

        public void AddDirector()
        {
            DataContext data = new DataContext();
            Person director = data.CompanyDirectors[0];
            _companyDirector = new Person()
            {
                FirstName = director.FirstName,
                LastName = director.LastName,
                Position = CompanyPosition.Director
            };
        }

        public void AddEmployer() { }

        public void AddDeveloperTeam()
        {
            DataContext data = new DataContext();

            Developer teamLead = data.TeamLeads[0];
            _developerTeam = new List<IEmployee>
            {
                new Developer()
                {
                    FirstName = teamLead.FirstName,
                    LastName = teamLead.LastName,
                    Level = teamLead.Level,
                    Position = CompanyPosition.TeamLead
                }
            };

            List<Developer> developers = data.Developers[0];
            foreach (Developer developer in developers)
            {
                _developerTeam.Add(
                                   new Developer()
                                   {
                                       FirstName = developer.FirstName,
                                       LastName = developer.LastName,
                                       Level = developer.Level,
                                       Position = CompanyPosition.Developer
                                   }
                                  );
            }
        }

        /// <summary>
        /// Створити компанію
        /// </summary>
        /// <returns>Невелика компанія, по розробці ПЗ</returns>
        public SmallCompany Build()
        {
            return new SmallCompany() 
            { 
                CompanyName = _companyName,
                CompanyDirector = _companyDirector, 
                DeveloperTeam = _developerTeam
            };
        }
    }
}
