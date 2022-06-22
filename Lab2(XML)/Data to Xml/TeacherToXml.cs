using LabModels;
using System.Xml;
using System.Collections.Generic;

namespace LabXML
{
    /// <summary>
    /// Клас для запису переліку екземплярів класа Викладач до XML файлу 
    /// </summary>
    public class TeacherToXml
    {
        private string _fileName;
        private XmlWriterSettings _settings;
        public TeacherToXml(string fileName, XmlWriterSettings settings = null)
        {
            _fileName = fileName;
            _settings = settings;
        }

        public void Start()
        {
            ClassesFromData<Teacher> classes = new ClassesFromData<Teacher>();
            List<Teacher> list = classes.GetList(NamesForFiles.TElement, new Teacher());
            using (XmlWriter writer = XmlWriter.Create(_fileName, _settings))
            {
                writer.WriteStartElement(NamesForFiles.TRoot);
                foreach (Teacher teacher in list)
                {
                    writer.WriteStartElement(NamesForFiles.TElement);
                    writer.WriteElementString(NamesForFiles.Id, teacher.Id.ToString());
                    writer.WriteElementString(NamesForFiles.FirstName, teacher.FirstName);
                    writer.WriteElementString(NamesForFiles.LastName, teacher.LastName);
                    writer.WriteElementString(NamesForFiles.Patronymic, teacher.Patronymic);
                    writer.WriteElementString(NamesForFiles.Experience, teacher.Experience.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }
    }
}
