using LabModels;
using System.Xml;
using System.Collections.Generic;

namespace LabXML
{
    /// <summary>
    /// Клас для запису переліку екземплярів класа Іспит до XML файлу 
    /// </summary>
    public class ExamToXml
    {
        private string _fileName;
        private XmlWriterSettings _settings;

        public ExamToXml(string fileName, XmlWriterSettings settings = null)
        {
            _fileName = fileName;
            _settings = settings;
        }

        public void Start()
        {
            ClassesFromData<Exam> classes = new ClassesFromData<Exam>();
            List<Exam> list = classes.GetList(NamesForFiles.EElement, new Exam());
            using (XmlWriter writer = XmlWriter.Create(_fileName, _settings))
            {
                writer.WriteStartElement(NamesForFiles.ERoot);
                foreach (Exam exam in list)
                {
                    writer.WriteStartElement(NamesForFiles.EElement);
                    writer.WriteElementString(NamesForFiles.StudentId, exam.StudentId.ToString());
                    writer.WriteElementString(NamesForFiles.DisciplineId, exam.DisciplineId.ToString());
                    writer.WriteElementString(NamesForFiles.Semester, exam.Semester.ToString());
                    writer.WriteElementString(NamesForFiles.Mark, exam.Mark.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
        }
    }
}
