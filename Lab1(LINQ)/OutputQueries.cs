using System;
using LabModels;
using System.Linq;
using System.Collections.Generic;

namespace LabLINQ
{
    /// <summary>
    /// Клас виводу в консоль результати запитів
    /// </summary>
    public static class OutputQueries
    {
        public static void WriteSubtitle(string subtitle)
        {
            Console.WriteLine($"\n  {subtitle}:");
        }

        public static void ShowListOfStudents(IEnumerable<Student> students)
        {
            WriteSubtitle("Перелік всіх студентів");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void ShowNamesOfDisciplines(IEnumerable<string> namesOfDisciplines)
        {
            WriteSubtitle("Перелік всіх назв відповідних дисциплін");
            foreach (string name in namesOfDisciplines)
            {
                Console.WriteLine(name);
            }
        }

        public static void ShowListOfTeachers(IEnumerable<(string, uint)> teachers)
        {
            WriteSubtitle("Перелік всіх вчителів");
            foreach ((string teacher, uint experience) in teachers)
            {
                Console.WriteLine($"Викладач: {teacher}(стаж: {experience})");
            }
        }

        public static void ShowSelectedDisciplines(IEnumerable<Discipline> disciplines)
        {
            WriteSubtitle("Перелік дисциплін, первинний ключ яких > 2 і форма контролю-\"Залік\"");
            foreach (Discipline discipline in disciplines)
            {
                Console.WriteLine(discipline);
            }
        }

        public static void ShowMarks(IOrderedEnumerable<Exam> marks, int min, int max)
        {
            string s = string.Format(
                                     $"Перелік оцінок, які у межах від {0} до {1},"
                                     + "відсортовані за зростанням", min, max
                                    );
            WriteSubtitle(s);
            foreach (Exam exam in marks)
            {
                Console.WriteLine(exam);
            }
        }

        public static void ShowExperiencedTeachers(IEnumerable<Teacher> teachers)
        {
            WriteSubtitle("Перелік вчителів, відсортовані за стажем, що мають стаж >= 10 років");
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher);
            }
        }

        public static void ShowStudentsPassedExam(IEnumerable<(string, decimal)> tuples)
        {
            WriteSubtitle("Перелік студентів, що склали іспити");
            foreach ((string student, decimal mark) in tuples)
            {
                Console.WriteLine($"{student}: {mark}");
            }
        }

        public static void ShowAllLastAndFirstNames(IEnumerable<string> lastAndFirstNames)
        {
            WriteSubtitle("Перелік прізвищ та імен усіх студентів та викладачів");
            foreach (string lastAndFirstName in lastAndFirstNames)
            {
                Console.WriteLine(lastAndFirstName);
            }
        }

        public static void ShowLecturersOfDisciplines(IEnumerable<(string, string)> tuples)
        {
            WriteSubtitle("Перелік дисциплін, які викладають відповідні лектори");
            foreach ((string discipline, string lecturer) in tuples)
            {
                Console.WriteLine($"{discipline} - {lecturer}");
            }
        }

        public static void ShowDisciplinesInStudents(IEnumerable<(Student, IEnumerable<Exam>)> t)
        {
            WriteSubtitle("Кількість дисциплін у кожного із студентів");
            foreach ((Student student, IEnumerable<Exam> exams) in t)
            {
                Console.WriteLine($"{student.LastName} {student.FirstName}: {exams.Count()}");
            }
        }

        public static void ShowDisciplineWithCredit(Discipline disciplineWithCredit)
        {
            WriteSubtitle("Перелік дисциплін, що мають форму - \"Залік\", виведенних в рядок");
            Console.WriteLine($"{disciplineWithCredit.Name} - Заліки");
        }

        public static void ShowMarksByPractitioner(Dictionary<string, List<(string, decimal)>> t)
        {
            WriteSubtitle("Перелік всіх оцінок згрупованих за практиками");
            foreach (KeyValuePair<string, List<(string, decimal)>> keyValuePair in t)
            {
                Console.Write($"{keyValuePair.Key}:");
                foreach ((_, decimal mark) in keyValuePair.Value)
                {
                    Console.Write($" {mark};");
                }
                Console.WriteLine();
            }
        }

        public static void ShowSuccessfulExams(IEnumerable<(string, int)> successfulExams)
        {
            WriteSubtitle("Кількість успішно складених тестів");
            foreach ((string Name, int Count) in successfulExams)
            {
                Console.WriteLine($"{Name}: {Count}");
            }
        }

        public static void ShowDisciplinesInAlphabetical(ILookup<char, string> disciplines)
        {
            WriteSubtitle("Перелік всіх дисциплін, згрупованих за першою буквою");
            foreach (IGrouping<char, string> discipline in disciplines)
            {
                Console.WriteLine(discipline.Key);
                foreach (string name in discipline)
                {
                    Console.WriteLine(" " + name);
                }
            }
        }

        public static void ShowHighestMarkDiscipline((string discipline, decimal mark) tuple)
        {
            WriteSubtitle("Найперша оцінка, серед відсортованих за спаданням");
            Console.WriteLine($"{tuple.discipline}: {tuple.mark}");
        }
    }
}
