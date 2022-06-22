using LabModels;
using System.Linq;
using System.Collections.Generic;

namespace LabLINQ
{
    /// <summary>
    /// Клас запитів
    /// </summary>
    public class Queries
    {
        public IEnumerable<Student> GetListOfStudents()
        {
            return from student in DataContext.Students
                   select student;
        }

        public IEnumerable<string> GetNamesOfDisciplines()
        {
            return DataContext.Disciplines.Select(d => d.Name);
        }
        
        public IEnumerable<(string, uint)> GetListOfTeachers()
        {
            return from t in DataContext.Teachers
                   select (t.GetSurnameAndInitials(), t.Experience);
        }

        public IEnumerable<Discipline> GetSelectedDisciplines()
        {
            return from d in DataContext.Disciplines
                   where d.Id > 2 && (d.Form == 0)
                   select d;
        }

        public IOrderedEnumerable<Exam> GetMarks(int min, int max)
        {
           return DataContext.Exams.Where(e => e.Mark >= min && e.Mark <= max).OrderBy(e => e.Mark);
        }

        public IEnumerable<Teacher> GetExperiencedTeachers()
        {
            return DataContext.Teachers.OrderBy(
                                                t => t.Experience
                                               ).Where(t => t.Experience >= 10);
        }

        public IEnumerable<(string, decimal)> GetStudentsPassedExam()
        {
            return from s in DataContext.Students
                   from e in DataContext.Exams
                   where s.Id == e.StudentId && e.Mark >= 60
                   select (s.GetLastAndFirstName(), e.Mark);
        }

        public IEnumerable<string> GetAllLastAndFirstNames()
        {
            return DataContext.Students.Select(
                                                s => s.GetLastAndFirstName()
                                               ).Concat(
                                                        DataContext.Teachers
                                                        .Select(t => t.GetLastAndFirstName())
                                                       );
        }

        public IEnumerable<(string, string)> GetLecturersOfDisciplines()
        {
            return from d in DataContext.Disciplines
                   join t in DataContext.Teachers on d.LecturerId equals t.Id
                   select (d.Name, t.GetSurnameAndInitials());
        }

        public IEnumerable<(Student, IEnumerable<Exam>)> GetNumberOfDisciplinesInStudents()
        {
            return DataContext.Students.GroupJoin(
                                                  DataContext.Exams,
                                                  s => s.Id,
                                                  e => e.StudentId,
                                                  (student, exam) => (student, exam)
                                                 );
        }

        public Discipline GetDisciplineWithCredit()
        {
            return DataContext.Disciplines.Aggregate(
                                                     new Discipline
                                                     {
                                                         Id = 0,
                                                         Name = string.Empty,
                                                         Form = 0
                                                     },
                                                      (total, next) =>
                                                      {
                                                          if (next.Form == 0)
                                                          {
                                                              total.Name += " " + next.Name + ", ";
                                                          }
                                                          return total;
                                                      }
                                                    );
        }

        public Dictionary<string, List<(string, decimal)>> GetMarksByPractitioner()
        {
            return DataContext.Teachers.Join(
                                             DataContext.Disciplines,
                                             t => t.Id,
                                             d => d.PractitionerId,
                                             (t, d) => (Teacher: t.GetSurnameAndInitials(), d.Id)
                                            ).Join(DataContext.Exams,
                                                   t => t.Id,
                                                   e => e.DisciplineId,
                                                   (t, e) => (t.Teacher, e.Mark)
                                                  ).GroupBy(r => r.Teacher
                                                           ).ToDictionary(g => g.Key, 
                                                                          g => g.ToList());
        }

        public IEnumerable<(string, int)> GetSuccessfulExams()
        {
            return from s in DataContext.Students
                   join e in DataContext.Exams on s.Id equals e.StudentId
                   where e.Mark >= 60
                   group s by s.LastName into g
                   select (g.Key, g.Count());
        }

        public ILookup<char, string> GetDisciplinesInAlphabetical()
        {
            return (from d in DataContext.Disciplines
                    orderby d.Name
                    select d
                   ).ToLookup(d => d.Name[0], d => d.Name);
        }

        public (string, decimal) GetHighestMarkDiscipline()
        {
            return (from d in DataContext.Disciplines
                    join e in DataContext.Exams on d.Id equals e.DisciplineId
                    orderby e.Mark descending
                    select (d.Name, e.Mark)
                   ).FirstOrDefault();
        }
    }
}
