using LabModels;
using System.Xml;
using System.Collections.Generic;

namespace LabXML
{
    /// <summary>
    /// Клас для запису переліку екземплярів класа Студент до XML файлу 
    /// </summary>
    public class StudentToXml
    {
        private string _fileName;
        private XmlWriterSettings _settings;
        public StudentToXml(string fileName, XmlWriterSettings settings = null)
        {
            _fileName = fileName;
            _settings = settings;
        }

        public void Start()
        {
            ClassesFromData<Student> classes = new ClassesFromData<Student>();
            List<Student> list = classes.GetList(NamesForFiles.SElement, new Student());
            using (XmlWriter writer = XmlWriter.Create(_fileName, _settings))
            {
                writer.WriteStartElement(NamesForFiles.SRoot);
                foreach (Student student in list)
                {
                    writer.WriteStartElement(NamesForFiles.SElement);
                    writer.WriteElementString(NamesForFiles.Id, student.Id.ToString());
                    writer.WriteElementString(NamesForFiles.FirstName, student.FirstName);
                    writer.WriteElementString(NamesForFiles.LastName, student.LastName);
                    writer.WriteElementString(NamesForFiles.Patronymic, student.Patronymic);
                    writer.WriteElementString(NamesForFiles.Course, student.Course.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }
    }
}
