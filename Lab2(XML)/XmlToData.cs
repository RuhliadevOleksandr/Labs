using System.Xml.Linq;
using System.Collections.Generic;

namespace LabXML
{
    /// <summary>
    /// Клас для зчитування переліку екземплярів класів: Дисципліна, Іспит, Студент та Викладач із XML файлу
    /// </summary>
    public class XmlToData
    {
        public IEnumerable<XElement> Disciplines
        {
            get
            {
                XDocument disciplines = XDocument.Load(NamesForFiles.DXml);
                return disciplines.Descendants(NamesForFiles.DElement);
            }
        }

        public IEnumerable<XElement> Exams
        {
            get
            {
                XDocument exams = XDocument.Load(NamesForFiles.EXml);
                return exams.Descendants(NamesForFiles.EElement);
            }
        }

        public IEnumerable<XElement> Students
        {
            get
            {
                XDocument students = XDocument.Load(NamesForFiles.SXml);
                return students.Descendants(NamesForFiles.SElement);
            }
        }

        public IEnumerable<XElement> Teachers
        {
            get
            {
                XDocument teachers = XDocument.Load(NamesForFiles.TXml);
                return teachers.Descendants(NamesForFiles.TElement);
            }
        }
    }
}
