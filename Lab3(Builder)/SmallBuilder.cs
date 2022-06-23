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
        private Worker _companyDirector;

        /// <summary>
        /// Команда розробників
        /// </summary>
        private List<IEmployee> _developerTeam = new List<IEmployee>();

        /// <summary>
        /// Дані компанії
        /// </summary>
        private DataContext _data = new DataContext();
        public void CreateName()
        {
            TextInfo textInfo = new CultureInfo("ua-UA", false).TextInfo;
            _companyName = textInfo.ToTitleCase(_data.CompanyNames[0]);
        }

        public void AddDirector()
        {
            Person director = _data.CompanyDirectors[0];
            _companyDirector = new Worker()
            {
                FirstName = director.FirstName,
                LastName = director.LastName,
                Position = CompanyPosition.Director
            };
        }

        public void AddEmployer() { }

        public void AddDeveloperTeam()
        {
            Developer teamLead = _data.TeamLeads[0];
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

            List<Developer> developers = _data.Developers[0];
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
