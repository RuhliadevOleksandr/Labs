using LabModels;
using System.Linq;
using System.Collections.Generic;

namespace LabXML
{
    /// <summary>
    /// Клас запитів
    /// </summary>
    public class Queries
    {
        XmlToData data = new XmlToData();

        public IEnumerable<Student> GetListOfStudents()
        {
            return from s in data.Students
                   select s.ToStudent();
        }

        public IEnumerable<string> GetNamesOfDisciplines()
        {
            return data.Disciplines.Select(d => d.Element(NamesForFiles.Name).Value);
        }
        
        public IEnumerable<(string, uint)> GetListOfTeachers()
        {
            return from t in data.Teachers
                   select (
                           t.ToTeacher().GetSurnameAndInitials(),
                           (uint)t.Element(NamesForFiles.Experience)
                          );
        }

        public IEnumerable<Discipline> GetSelectedDisciplines()
        {
            return from d in data.Disciplines
                   where (uint)d.Element(NamesForFiles.Id) > 2 
                     &&  d.Element(NamesForFiles.Form).Value == "Залік"
                   select d.ToDiscipline();
        }

        public IEnumerable<Exam> GetMarks(int min, int max)
        {
            return data.Exams.Where(
                                    e => (decimal)e.Element(NamesForFiles.Mark) >= min
                                      && (decimal)e.Element(NamesForFiles.Mark) <= max
                                   ).OrderBy(
                                             e => (decimal)e.Element(NamesForFiles.Mark)
                                            ).Select(e => e.ToExam());
        }

        public IEnumerable<Teacher> GetExperiencedTeachers()
        {
            return data.Teachers.OrderBy(
                                         t => (uint)t.Element(NamesForFiles.Experience)
                                        ).Where(
                                                t=>(uint)t.Element(NamesForFiles.Experience) >= 10
                                               ).Select(t => t.ToTeacher());
        }

        public IEnumerable<(string, decimal)> GetStudentsPassedExam()
        {
            return from s in data.Students
                   from e in data.Exams
                   where (uint)s.Element(NamesForFiles.Id) == 
                         (uint)e.Element(NamesForFiles.StudentId) 
                         && (decimal)e.Element(NamesForFiles.Mark) >= 60
                   select (
                           s.ToStudent().GetLastAndFirstName(), 
                           (decimal)e.Element(NamesForFiles.Mark)
                          );
        }

        public IEnumerable<string> GetAllLastAndFirstNames()
        {
            return data.Students.Select(
                                        s => s.ToStudent().GetLastAndFirstName()
                                       ).Concat(
                                                data.Teachers
                                                .Select(t => t.ToTeacher().GetLastAndFirstName())
                                               );
        }

        public IEnumerable<(string, string)> GetLecturersOfDisciplines()
        {
            return from d in data.Disciplines
                   join t in data.Teachers 
                   on (uint)d.Element(NamesForFiles.LecturerId) 
                   equals (uint)t.Element(NamesForFiles.Id)
                   select (
                           d.Element(NamesForFiles.Name).Value, 
                           t.ToTeacher().GetSurnameAndInitials()
                          );
        }

        public IEnumerable<(Student, IEnumerable<Exam>)> GetNumberOfDisciplinesInStudents()
        {
            return data.Students.GroupJoin(
                                       data.Exams,
                                       s => (uint)s.Element(NamesForFiles.Id),
                                       e => (uint)e.Element(NamesForFiles.StudentId),
                                       (s, e) => (s.ToStudent(), e.Select(t => t.ToExam()))
                                      );
        }

        public IEnumerable<(string, decimal)> GetStudentsMarks()
        {
            return from s in data.Students
                   join e in data.Exams 
                   on (uint)s.Element(NamesForFiles.Id) 
                   equals (uint)e.Element(NamesForFiles.StudentId) 
                   into temp
                   from t in temp.DefaultIfEmpty()
                   select (
                           s.ToStudent().GetLastAndFirstName(), 
                           t == null ? 0 : (decimal)t.Element(NamesForFiles.Mark)
                          );
        }

        public Discipline GetDisciplineWithCredit()
        {
            return data.Disciplines.Aggregate(
                                          new Discipline
                                          {
                                              Id = 0,
                                              Name = string.Empty,
                                              Form = 0
                                          },
                                          (total, next) =>
                                          {
                                              if(next.Element(NamesForFiles.Form).Value == "Залік")
                                              {
                                                  total.Name += " " + 
                                                  next.Element(NamesForFiles.Name).Value + ", ";
                                              }
                                              return total;
                                          }
                                         );
        }

        public Dictionary<string, List<(string, decimal)>> GetMarksByPractitioner()
        {
            return data.Teachers.Join(
                                      data.Disciplines,
                                      t => (uint)t.Element(NamesForFiles.Id),
                                      d => (uint)d.Element(NamesForFiles.PractitionerId),
                                      (t, d) => 
                                      (
                                       Teacher: t.ToTeacher().GetSurnameAndInitials(), 
                                       Id: (uint)d.Element(NamesForFiles.Id)
                                      )
                                     ).Join(
                                            data.Exams,
                                            t => t.Id,
                                            e => (uint)e.Element(NamesForFiles.DisciplineId),
                                            (t, e) => (
                                                       t.Teacher, 
                                                       Mark: (decimal)e.Element(NamesForFiles.Mark)
                                                      )
                                           ).GroupBy(
                                                     r => r.Teacher
                                                    ).ToDictionary(g => g.Key, g => g.ToList());
        }

        public IEnumerable<(string, int)> GetSuccessfulExams()
        {
            return from s in data.Students
                   join e in data.Exams 
                   on (uint)s.Element(NamesForFiles.Id) 
                   equals (uint)e.Element(NamesForFiles.StudentId)
                   where (decimal)e.Element(NamesForFiles.Mark) >= 60
                   group s by s.Element(NamesForFiles.LastName) into g
                   select (g.Key.Value, g.Count());
        }

        public ILookup<char, string> GetDisciplinesInAlphabetical()
        {
            return (from d in data.Disciplines
                    orderby d.Element(NamesForFiles.Name).Value
                    select d
                   ).ToLookup(
                              d => d.Element(NamesForFiles.Name).Value[0], 
                              d => d.Element(NamesForFiles.Name).Value
                             );
        }

        public (string, decimal) GetHighestMarkDiscipline()
        {
            return (from d in data.Disciplines
                    join e in data.Exams 
                    on (uint)d.Element(NamesForFiles.Id) 
                    equals (uint)e.Element(NamesForFiles.DisciplineId)
                    orderby (decimal)e.Element(NamesForFiles.Mark) descending
                    select (
                            d.Element(NamesForFiles.Name).Value,
                            (decimal)e.Element(NamesForFiles.Mark)
                           )
                   ).FirstOrDefault();
        }
    }
}
