using System.Collections.Generic;

namespace Builder
{
    /// <summary>
    /// Будівельник компанії середніх розмірів
    /// </summary>
    public class MediumBuilder : ICompanyBuilder
    {
        /// <summary>
        /// Середня компанія
        /// </summary>
        private MediumCompany _company;

        /// <summary>
        /// Дані компанії
        /// </summary>
        private DataContext _data = new DataContext();

        public void Reset()
        {
            _company = new MediumCompany();
        }

        public void CreateName()
        {
            _company.CompanyName = _data.CompanyNames[1].ToUpper();
        }

        public void AddDirector()
        {
            Person director = _data.CompanyDirectors[1];
            _company.CompanyDirector = new Worker()
            {
                FirstName = director.FirstName,
                LastName = director.LastName,
                Position = CompanyPosition.Director
            };
        }

        public void AddEmployer()
        {
            Person employer = _data.Employers[0];
            _company.CompanyEmployer = new Employer()
            {
                FirstName = employer.FirstName,
                LastName = employer.LastName,
                NumberOfEmployees = 0
            };
        }

        public void AddDeveloperTeam()
        {
            Developer teamLead = _data.TeamLeads[1];
            _company.DeveloperTeam = new List<Developer>
            {
                new Developer()
                {
                    FirstName = teamLead.FirstName,
                    LastName = teamLead.LastName,
                    Level = teamLead.Level,
                    Position = CompanyPosition.TeamLead
                }
            };
            _company.CompanyEmployer.NumberOfEmployees += 1;

            List<Developer> developers = _data.Developers[1];
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
                _company.CompanyEmployer.NumberOfEmployees += 1;
            }
        }

        /// <summary>
        /// Повертає компанію
        /// </summary>
        /// <returns>Середня компанія, по розробці ПЗ</returns>
        public MediumCompany GetCompany()
        {
            return _company;
        }
    }
}
