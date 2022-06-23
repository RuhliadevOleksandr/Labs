using System.Text;
using System.Collections.Generic;

namespace Builder
{
    /// <summary>
    /// Середня компанія, по розробці ПЗ
    /// </summary>
    public class MediumCompany
    {
        /// <summary>
        /// Директор компанії
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Директор компанії
        /// </summary>
        public Worker CompanyDirector { get; set; }

        /// <summary>
        /// Роботодавець компанії
        /// </summary>
        public Employer CompanyEmployer { get; set; }

        /// <summary>
        /// Команда розробників
        /// </summary>
        public List<Developer> DeveloperTeam { get; set; }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"\n    Назва: {CompanyName};\n");
            sb.AppendFormat($"\n    Директор: {CompanyDirector}\n");
            sb.AppendFormat($"\n    Роботодавець: {CompanyEmployer}\n");
            sb.AppendFormat($"\n    Команда розробників:  ");
            foreach (IEmployee employee in DeveloperTeam)
            {
                sb.AppendFormat($"{employee}\n");
            }
            return sb.AppendLine().ToString();
        }
    }
}
