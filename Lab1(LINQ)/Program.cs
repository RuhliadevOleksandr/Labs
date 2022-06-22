using System;
using System.Text;

namespace LabLINQ
{
    class Program
    {
        static void Main()
        {
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{title}:");
            Console.ResetColor();
        }
    }
}