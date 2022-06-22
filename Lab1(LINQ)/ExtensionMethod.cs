using LabModels;

namespace LabLINQ
{
     /// <summary>
     /// Клас розширених методів
     /// </summary>
    public static class ExtensionMethod
    {
        /// <summary>
        /// Повертає прізвище та ініціали особи
        /// </summary>
        public static string GetSurnameAndInitials(this Person value)
        {
            return value.LastName + " " + value.FirstName[0] + "." + value.Patronymic[0] + ".";
        }
        /// <summary>
        /// Повертає прізвище та ім'я особи
        /// </summary>
        public static string GetLastAndFirstName(this Person person)
        {
            return person.LastName + " " + person.FirstName;
        }
    }
}
