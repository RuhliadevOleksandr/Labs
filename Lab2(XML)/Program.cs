using System;
using System.Xml;
using System.Text;

namespace LabXML
{
    public class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;

            XmlWriterSettings settings = new XmlWriterSettings { Indent = true };

            DisciplineToXml disciplineToXml = new DisciplineToXml(NamesForFiles.DXml, settings);
            ExamToXml examToXml = new ExamToXml(NamesForFiles.EXml, settings);
            StudentToXml studentToXml = new StudentToXml(NamesForFiles.SXml, settings);
            TeacherToXml teacherToXml = new TeacherToXml(NamesForFiles.TXml, settings);

            disciplineToXml.Start();
            examToXml.Start();
            studentToXml.Start();
            teacherToXml.Start();


            Queries q = new Queries();

            Console.OutputEncoding = Encoding.UTF8;


            WriteTitle("Прості запити");

            OutputQueries.ShowListOfStudents(q.GetListOfStudents());

            OutputQueries.ShowNamesOfDisciplines(q.GetNamesOfDisciplines());

            OutputQueries.ShowListOfTeachers(q.GetListOfTeachers());

            OutputQueries.ShowSelectedDisciplines(q.GetSelectedDisciplines());

            OutputQueries.ShowMarks(q.GetMarks(75, 84), 75, 84);


            WriteTitle("Оператори поділу");
            OutputQueries.ShowExperiencedTeachers(q.GetExperiencedTeachers());


            WriteTitle("З'єднання");

            OutputQueries.ShowStudentsPassedExam(q.GetStudentsPassedExam());

            OutputQueries.ShowAllLastAndFirstNames(q.GetAllLastAndFirstNames());

            OutputQueries.ShowLecturersOfDisciplines(q.GetLecturersOfDisciplines());

            OutputQueries.ShowDisciplinesInStudents(q.GetNumberOfDisciplinesInStudents());
            
            OutputQueries.ShowStudentsMarks(q.GetStudentsMarks());


            WriteTitle("Функції агрегування");

            OutputQueries.ShowDisciplineWithCredit(q.GetDisciplineWithCredit());

            OutputQueries.ShowMarksByPractitioner(q.GetMarksByPractitioner());

            OutputQueries.ShowSuccessfulExams(q.GetSuccessfulExams());


            WriteTitle("Перетворення даних");

            OutputQueries.ShowDisciplinesInAlphabetical(q.GetDisciplinesInAlphabetical());


            WriteTitle("Отримання елемента");

            OutputQueries.ShowHighestMarkDiscipline(q.GetHighestMarkDiscipline());


            Console.ReadLine();
        }
        public static void WriteTitle(string title)
        {
            Output.ColorOutput(string.Format($"\n{title}:"), ConsoleColor.Green);
        }
    }
}