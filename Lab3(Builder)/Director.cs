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
            _builder.Reset();
            switch (_builder)
            {
                case SmallBuilder _:
                    _builder.CreateName();
                    _builder.AddDirector();
                    _builder.AddDeveloperTeam();
                    break;
                case MediumBuilder _:
                    _builder.CreateName();
                    _builder.AddDirector();
                    _builder.AddEmployer();
                    _builder.AddDeveloperTeam();
                    break;
            }
        }
    }
}
