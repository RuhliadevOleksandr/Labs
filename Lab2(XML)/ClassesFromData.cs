using System;
using LabModels;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LabXML
{
    /// <summary>
    /// Клас методів для створення переліків екземплярів класів: Дисципліна, Іспит, Студент та Викладач із консолі
    /// </summary>
    public class ClassesFromData<T> where T : class
    {
        public List<T> GetList(string elementName, T template)
        {
            ConsoleKey key;
            
            List<T> list = new List<T>();
            do
            {
                T temp = null;
                key = ConsoleKey.Enter;
                switch (template)
                {
                    case Discipline _:
                        temp = (T)Convert.ChangeType(GetDiscipline(), typeof(T));
                        break;
                    case Exam _:
                        temp = (T)Convert.ChangeType(GetExam(), typeof(T));
                        break;
                    case Student _:
                        temp = (T)Convert.ChangeType(GetStudent(), typeof(T));
                        break;
                    case Teacher _:
                        temp = (T)Convert.ChangeType(GetTeacher(), typeof(T));
                        break;
                }
                list.Add(temp);
                key = DataFromConsole.AskToAdd(elementName, key);
                if (key == ConsoleKey.N)
                {
                    break;
                }
            }
            while (key == ConsoleKey.Y);
            return list;
        }

        private Discipline GetDiscipline()
        {
            Output.OutputTitle(string.Format($"\nEnter {NamesForFiles.DElement}:"));
            return new Discipline
            {
                Id = DataFromConsole.GetUNumber(NamesForFiles.DElement, NamesForFiles.Id),
                Name = DataFromConsole.GetWord(
                                               NamesForFiles.DElement,
                                               NamesForFiles.Name,
                                               new Regex(@"\w+")
                                              ),
                Form = DataFromConsole.GetForm(NamesForFiles.DElement, NamesForFiles.Form),
                LecturerId = DataFromConsole.GetUNumber(
                                                        NamesForFiles.DElement,
                                                        NamesForFiles.LecturerId
                                                       ),
                PractitionerId = DataFromConsole.GetUNumber(
                                                            NamesForFiles.DElement,
                                                            NamesForFiles.PractitionerId
                                                           )
            };
        }

        private Exam GetExam()
        {
            Output.OutputTitle(string.Format($"\nEnter {NamesForFiles.EElement}:"));
            return new Exam
            {
                StudentId = DataFromConsole.GetUNumber(
                                                       NamesForFiles.EElement,
                                                       NamesForFiles.StudentId
                                                      ),
                DisciplineId = DataFromConsole.GetUNumber(
                                                          NamesForFiles.EElement,
                                                          NamesForFiles.DisciplineId
                                                         ),
                Semester = DataFromConsole.GetUNumber(
                                                      NamesForFiles.EElement,
                                                      NamesForFiles.Semester
                                                     ),
                Mark = DataFromConsole.GetDecimal(
                                                  NamesForFiles.EElement,
                                                  NamesForFiles.Mark
                                                 )
            };
        }

        private Student GetStudent()
        {
            Output.OutputTitle(string.Format($"\nEnter {NamesForFiles.SElement}:"));
            return new Student
            {
                Id = DataFromConsole.GetUNumber(NamesForFiles.SElement, NamesForFiles.Id),
                FirstName = DataFromConsole.GetWord(
                                                    NamesForFiles.SElement,
                                                    NamesForFiles.FirstName,
                                                    new Regex("^[А-ЩЬЮЯҐЄІЇа-щьюяґєіїa-zA-Z]+$")
                                                   ),
                LastName = DataFromConsole.GetWord(
                                                   NamesForFiles.SElement,
                                                   NamesForFiles.LastName,
                                                   new Regex("^[А-ЩЬЮЯҐЄІЇа-щьюяґєіїa-zA-Z]+$")
                                                  ),
                Patronymic = DataFromConsole.GetWord(
                                                     NamesForFiles.SElement,
                                                     NamesForFiles.Patronymic,
                                                     new Regex("^[А-ЩЬЮЯҐЄІЇа-щьюяґєіїa-zA-Z]+$")
                                                    ),
                Course = DataFromConsole.GetUNumber(NamesForFiles.SElement, NamesForFiles.Course)
            };
        }

        private Teacher GetTeacher()
        {
            Output.OutputTitle(string.Format($"\nEnter {NamesForFiles.TElement}:"));
            return new Teacher
            {
                Id = DataFromConsole.GetUNumber(NamesForFiles.TElement, NamesForFiles.Id),
                FirstName = DataFromConsole.GetWord(
                                                    NamesForFiles.TElement,
                                                    NamesForFiles.FirstName,
                                                    new Regex("^[А-ЩЬЮЯҐЄІЇа-щьюяґєіїa-zA-Z]+$")
                                                   ),
                LastName = DataFromConsole.GetWord(
                                                   NamesForFiles.TElement,
                                                   NamesForFiles.LastName,
                                                   new Regex("^[А-ЩЬЮЯҐЄІЇа-щьюяґєіїa-zA-Z]+$")
                                                  ),
                Patronymic = DataFromConsole.GetWord(
                                                     NamesForFiles.TElement,
                                                     NamesForFiles.Patronymic,
                                                     new Regex("^[А-ЩЬЮЯҐЄІЇа-щьюяґєіїa-zA-Z]+$")
                                                    ),
                Experience = DataFromConsole.GetUNumber(
                                                        NamesForFiles.TElement,
                                                        NamesForFiles.Experience
                                                       )
            };
        }
    }
}
