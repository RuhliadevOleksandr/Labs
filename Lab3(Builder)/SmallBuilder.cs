using System.Collections.Generic;

namespace Builder
{
    /// <summary>
    /// Будівельник невеликої компанія
    /// </summary>
    public class SmallBuilder : ICompanyBuilder
    {
        /// <summary>
        /// Невелика компанія
        /// </summary>
        private SmallCompany _company;

        /// <summary>
        /// Дані компанії
        /// </summary>
        private DataContext _data = new DataContext();

        public void Reset()
        {
            _company = new SmallCompany();
        }

        public void CreateName()
        {
            _company.CompanyName = _data.CompanyNames[0].ToUpper();
        }

        public void AddDirector()
        {
            Person director = _data.CompanyDirectors[0];
            _company.CompanyDirector = new Worker()
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
            _company.DeveloperTeam = new List<IEmployee>
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
                _company.DeveloperTeam.Add(
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
        /// Повертає компанію
        /// </summary>
        /// <returns>Невелика компанія, по розробці ПЗ</returns>
        public SmallCompany GetCompany()
        {
            return _company;
        }
    }
}
