using EgzamDatabase.Model;
using StudentDatabase.BusnesLogic;

namespace StudentDatabase.Servise
{
    public class Lectures
    {
        private static void AddLecture()
        {

            using (var context = new StudyContext("StudentsDatabase"))
            {

                var lecture = new Lecture
                {
                    LectureID = 321,
                    DepartamentID = 1045,
                    StudentID = 15

                };

                context.Lecture.Add(lecture);
                context.SaveChanges();

            }
        }
        private static void AddLectureToDepartament()
        {
            using (var context = new StudyContext("StudentsDatabase"))
            {

                var lecture = (from l in context.Lecture
                               where l.LectureID == 321
                               select l).Single();

                Departament.DepartamentID = 2042;
                context.Add(lecture);
                context.SaveChanges();

            }
        }
    }
}
