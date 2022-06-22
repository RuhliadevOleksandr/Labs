using System;
using LabModels;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LabXML
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

        /// <summary>
        /// Перевіряє рядок на пусте або відсутнє значення
        /// </summary>
        public static string Validate(this string value)
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value", "Value cannot be null.");
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Приводить елемент XML документу до класу Дисципліна
        /// </summary>
        public static Discipline ToDiscipline(this XElement xElement)
        {
            XmlRootAttribute root = new XmlRootAttribute(NamesForFiles.DElement);
            XmlSerializer serializer = new XmlSerializer(typeof(Discipline), root);
            return (Discipline)serializer.Deserialize(xElement.CreateReader());
        }

        /// <summary>
        /// Приводить елемент XML документу до класу Іспит
        /// </summary>
        public static Exam ToExam(this XElement xElement)
        {
            XmlRootAttribute root = new XmlRootAttribute(NamesForFiles.EElement);
            XmlSerializer serializer = new XmlSerializer(typeof(Exam), root);
            return (Exam)serializer.Deserialize(xElement.CreateReader());
        }

        /// <summary>
        /// Приводить елемент XML документу до класу Студент
        /// </summary>
        public static Student ToStudent(this XElement xElement)
        {
            XmlRootAttribute root = new XmlRootAttribute(NamesForFiles.SElement);
            XmlSerializer serializer = new XmlSerializer(typeof(Student), root);
            return (Student)serializer.Deserialize(xElement.CreateReader());
        }

        /// <summary>
        /// Приводить елемент XML документу до класу Викладач
        /// </summary>
        public static Teacher ToTeacher(this XElement xElement)
        {
            XmlRootAttribute root = new XmlRootAttribute(NamesForFiles.TElement);
            XmlSerializer serializer = new XmlSerializer(typeof(Teacher), root);
            return (Teacher)serializer.Deserialize(xElement.CreateReader());
        }
    }
}
