using System.Collections.Generic;

namespace Builder
{ 
    /// <summary>
    /// Директор, який констроює продукт
    /// </summary>
    public class Director
    {
        /// <summary>
        /// Об'єкт-будівельник
        /// </summary>
        private ICompanyBuilder _builder;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="builder">Об'єкт-будівельник</param>
        public Director(ICompanyBuilder builder)
        {
            _builder = builder;
        }

        /// <summary>
        /// Виконати побудову компанії
        /// </summary>
        public void PerformBuild()
        {
            switch (_builder)
            {
                case SmallBuilder _:
                    _builder.CreateName(string.Empty);
                    _builder.AddDirector(new Person());
                    _builder.AddDeveloperTeam(new List<Developer>(), new Developer());
                    break;
                case MediumBuilder _:
                    _builder.CreateName(string.Empty);
                    _builder.AddDirector(new Person());
                    _builder.AddEmployer(new Person());
                    _builder.AddDeveloperTeam(new List<Developer>(), new Developer());
                    break;
            }
        }
    }
}
