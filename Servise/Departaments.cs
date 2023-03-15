
using EgzamDatabase.Model;
using StudentDatabase.BusnesLogic;



namespace StudentDatabase.Servise
{
    public class Departaments
    {


        private static void AddDepartament()
        {

            using (var context = new StudyContext("StudentsDatabase"))
            {

                var departament = new Departament
                {
                    DepartamentID = 3105,
                    Title = "Phisick",
                    Credits = 4
                };

                context.Add(departament);
                context.SaveChanges();

            }
        }

        private void AddStudentToDepartament(Student student)
        {

            using (var context = new StudyContext("StudentsDatabase"))
            {

                var departament = (from d in context.Departament
                                   where d.Title == "Phisick"
                                   select d).Single();
                student.LastName = "Noreikaite";
                context.SaveChanges();

            }
        }
        private void AddLectureToDepartament(Lectures lecture)
        {

            using (var context = new StudyContext("StudentsDatabase"))
            {

                var departament = (from d in context.Departament
                                   where d.Title == "Phisick"
                                   select d).Single();
                lecture.lectureId = 321;
                context.Add(departament);
                context.SaveChanges();

            }
        }
    }
}
