using EgzamDatabase.Model;
using StudentDatabase.BusnesLogic;

namespace StudentDatabase.Servise
{
    public class Studetnts
    {
        private static void AddStudent()
        {

            using (var context = new StudyContext("StudentsDatabase"))
            {

                var student = new Student
                {
                    LastName = "Karolina",
                    FirstMidName = "Aliukaite",
                    LectureDate = DateTime.Parse("2023-02-01")
                };

                context.Student.Add(student);
                context.SaveChanges();

            }
        }
        private static void AddStudentToDepartament()
        {
            using (var context = new StudyContext("StudentsDatabase"))
            {

                var student = (from s in context.Student
                               where s.LastName == "Olintyte"
                               select s).Single();
                Departament.departamentID = 2042;
                context.Add(student);
                context.SaveChanges();

            }
        }
        private static void ChangeStudent()
        {

            using (var context = new StudyContext("StudentsDatabase"))
            {

                var student = (from d in context.Student
                               where d.FirstMidName == "Petras"
                               select d).Single();
                student.LastName = "Kazlauskas";
                context.SaveChanges();

            }
        }


    }
}
