using System.Collections.Generic;
using System.Globalization;

namespace Builder
{
    /// <summary>
    /// Будівельник компанії середніх розмірів
    /// </summary>
    public class MediumBuilder : ICompanyBuilder
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
        /// Роботодавець компанії
        /// </summary>
        private Employer _сompanyEmployer;

        /// <summary>
        /// Команда розробників
        /// </summary>
        private List<Developer> _developerTeam = new List<Developer>();

        /// <summary>
        /// Дані компанії
        /// </summary>
        private DataContext _data = new DataContext();

        public void CreateName()
        {
            TextInfo textInfo = new CultureInfo("ua-UA", false).TextInfo;
            _companyName = textInfo.ToTitleCase(_data.CompanyNames[1]);
        }

        public void AddDirector()
        {
            Person director = _data.CompanyDirectors[1];
            _companyDirector = new Worker()
            {
                FirstName = director.FirstName,
                LastName = director.LastName,
                Position = CompanyPosition.Director
            };
        }

        public void AddEmployer()
        {
            Person employer = _data.Employers[0];
            _сompanyEmployer = new Employer()
            {
                FirstName = employer.FirstName,
                LastName = employer.LastName,
                NumberOfEmployees = 0
            };
        }

        public void AddDeveloperTeam()
        {
            Developer teamLead = _data.TeamLeads[1];
            _developerTeam = new List<Developer>
            {
                new Developer()
                {
                    FirstName = teamLead.FirstName,
                    LastName = teamLead.LastName,
                    Level = teamLead.Level,
                    Position = CompanyPosition.TeamLead
                }
            };
            _сompanyEmployer.NumberOfEmployees += 1;

            List<Developer> developers = _data.Developers[1];
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
                _сompanyEmployer.NumberOfEmployees += 1;
            }
        }

        /// <summary>
        /// Створити компанію
        /// </summary>
        /// <returns>Середня компанія, по розробці ПЗ</returns>
        public MediumCompany Build()
        {
            return new MediumCompany()
            {
                CompanyName = _companyName,
                CompanyDirector = _companyDirector,
                CompanyEmployer = _сompanyEmployer,
                DeveloperTeam = _developerTeam
            };
        }
    }
}
