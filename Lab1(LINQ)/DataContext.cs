using System.Collections.Generic;
using LabModels;

namespace LabLINQ
{
    /// <summary>
    /// Клас набір даних
    /// </summary>
    public class DataContext
    {
        public static List<Student> Students => new List<Student>()
        {
            new Student
            {
                Id = 1,
                LastName = "Романченко",
                FirstName = "Сергій",
                Patronymic = "Олександрович",
                Course =  1
            },
            new Student
            {
                Id = 2,
                LastName = "Дмитренко",
                FirstName = "Любов",
                Patronymic = "Петрівна",
                Course =  3
            },
            new Student
            {
                Id = 3,
                LastName = "Захарчук",
                FirstName = "Вікторія",
                Patronymic = "Євгеніївна",
                Course =  3
            },
            new Student
            {
                Id = 4,
                LastName = "Середа",
                FirstName = "Павло",
                Patronymic = "Миколайович",
                Course =  2
            },
            new Student
            {
                Id = 5,
                LastName = "Шинкаренко",
                FirstName = "Світлана",
                Patronymic = "Тарасівна",
                Course =  1
            }
        };

        public static List<Teacher> Teachers => new List<Teacher>()
        {
            new Teacher 
            { 
                Id = 1, 
                LastName = "Дмитриченко", 
                FirstName = "Славина", 
                Patronymic = "Охримівна", 
                Experience =  7
            },
            new Teacher 
            { 
                Id = 2, 
                LastName = "Панькевич", 
                FirstName = "Витомир", 
                Patronymic = "Захарович", 
                Experience =  13
            },
            new Teacher 
            { 
                Id = 3, 
                LastName = "Кучер", 
                FirstName = "Йовілла", 
                Patronymic = "Семенівна", 
                Experience =  3
            },
            new Teacher 
            { 
                Id = 4, 
                LastName = "Сивокінь", 
                FirstName = "Йосипа", 
                Patronymic = "Тимурівна", 
                Experience =  11
            },
            new Teacher 
            { 
                Id = 5, 
                LastName = "Калиниченко", 
                FirstName = "Ждан", 
                Patronymic = "Сарматович", 
                Experience =  15
            },
            new Teacher 
            { 
                Id = 6, 
                LastName = "Корнієць", 
                FirstName = "Павло", 
                Patronymic = "Герасимович", 
                Experience =  7
            },
            new Teacher 
            { 
                Id = 7, 
                LastName = "Атаманчук", 
                FirstName = "Домна", 
                Patronymic = "Федорівна", 
                Experience =  16
            }
        };

        public static List<Discipline> Disciplines => new List<Discipline>()
        {
            new Discipline 
            { 
                Id = 1, 
                Name = "Фізика", 
                Form = 0, 
                LecturerId = 7, 
                PractitionerId =  7
            },
            new Discipline 
            { 
                Id = 2, 
                Name = "Вища математика", 
                Form = (FormOfKnoledgeControl)1, 
                LecturerId = 4, 
                PractitionerId =  6
            },
            new Discipline 
            { 
                Id = 3, 
                Name = "Теорія ймовірностей", 
                Form = 0, 
                LecturerId = 5, 
                PractitionerId =  2
            },
            new Discipline 
            { 
                Id = 4, 
                Name = "Англійська мова", 
                Form = 0, 
                LecturerId = 1, 
                PractitionerId =  1
            },
            new Discipline 
            { 
                Id = 5, 
                Name = "Аналіз даних", 
                Form = 0, 
                LecturerId = 4, 
                PractitionerId =  2
            }
        };

        public static List<Exam> Exams => new List<Exam>()
        {
            new Exam { DisciplineId = 1, StudentId = 2, Mark = 78, Semester = 1},
            new Exam { DisciplineId = 1, StudentId = 3, Mark = 86, Semester = 2},
            new Exam { DisciplineId = 1, StudentId = 4, Mark = 93, Semester = 2},
            new Exam { DisciplineId = 2, StudentId = 3, Mark = 83, Semester = 3},
            new Exam { DisciplineId = 2, StudentId = 4, Mark = 77, Semester = 2},
            new Exam { DisciplineId = 4, StudentId = 1, Mark = 0, Semester = 2},
            new Exam { DisciplineId = 4, StudentId = 2, Mark = 0, Semester = 4},
            new Exam { DisciplineId = 5, StudentId = 2, Mark = 68, Semester = 6},
            new Exam { DisciplineId = 5, StudentId = 3, Mark = 75, Semester = 6}
        };
    }
}
