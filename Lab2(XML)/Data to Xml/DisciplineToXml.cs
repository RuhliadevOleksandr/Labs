using LabModels;
using System.Xml;
using System.Collections.Generic;

namespace LabXML
{
    /// <summary>
    /// Клас для запису переліку екземплярів класа Дисципліна до XML файлу 
    /// </summary>
    public class DisciplineToXml
    {
        private string _fileName;
        private XmlWriterSettings _settings;

        public DisciplineToXml(string fileName, XmlWriterSettings settings = null)
        {
            _fileName = fileName;
            _settings = settings;
        }

        public void Start()
        {
            ClassesFromData<Discipline> classes = new ClassesFromData<Discipline>();
            List<Discipline> list = classes.GetList(NamesForFiles.DElement, new Discipline());
            using (XmlWriter writer = XmlWriter.Create(_fileName, _settings))
            {
                writer.WriteStartElement(NamesForFiles.DRoot);
                foreach (Discipline discipline in list)
                {
                    writer.WriteStartElement(NamesForFiles.DElement);
                    writer.WriteElementString(NamesForFiles.Id, discipline.Id.ToString());
                    writer.WriteElementString(NamesForFiles.Name, discipline.Name);
                    writer.WriteElementString(NamesForFiles.Form, discipline.Form.ToString());
                    writer.WriteElementString(NamesForFiles.LecturerId, discipline.LecturerId.ToString());
                    writer.WriteElementString(
                                              NamesForFiles.PractitionerId,
                                              discipline.PractitionerId.ToString()
                                             );
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }
    }
}
