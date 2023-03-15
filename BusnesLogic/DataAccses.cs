

using EgzamDatabase.Model;
using StudentDatabase.BusnesLogic;

namespace StudentDatabase.Migrations
{
    public class DataAccses
    {


        public void CreateStudent()

        {
            using (var context = new StudyContext("StudentsDatabase"))
            {

                List<Student> students = new List<Student>();

                students.Add(new Student
                {

                    FirstMidName = "Petras",
                    LastName = "Kazlauskas",
                    LectureDate = DateTime.Parse("2023-09-01")
                });
                students.Add(new Student
                {
                    FirstMidName = "Ona",
                    LastName = "Petryte",
                    LectureDate = DateTime.Parse("2023-09-01")
                });
                students.Add(new Student
                {
                    FirstMidName = "Arturas",
                    LastName = "Lasauskas",
                    LectureDate = DateTime.Parse("2023-02-01")
                });
                students.Add(new Student
                {
                    FirstMidName = "Gytis",
                    LastName = "Barzdukas",
                    LectureDate = DateTime.Parse("2023-09-01")
                });
                students.Add(new Student
                {
                    FirstMidName = "Lina",
                    LastName = "Linkyte",
                    LectureDate = DateTime.Parse("2023-09-01")
                });
                students.Add(new Student
                {
                    FirstMidName = "Peta",
                    LastName = "Justinyte",
                    LectureDate = DateTime.Parse("2022-09-01")
                });
                students.Add(new Student
                {
                    FirstMidName = "Laura",
                    LastName = "Noreikaite",
                    LectureDate = DateTime.Parse("2023-02-01")
                });
                students.Add(new Student
                {
                    FirstMidName = "Nina",
                    LastName = "Olintyte",
                    LectureDate = DateTime.Parse("2022-02-011")
                });



                context.Student.AddRange(students);

                context.SaveChanges();
            }
        }

        public void CreateDepartament()

        {
            using (var context = new StudyContext("StudentsDatabase"))
            {
                List<Departament> departament = new List<Departament>();
                {
                    departament.Add(new Departament { DepartamentID = 1050, Title = "Chemistry", Credits = 3, });
                    departament.Add(new Departament { DepartamentID = 4022, Title = "Microeconomics", Credits = 3, });
                    departament.Add(new Departament { DepartamentID = 4041, Title = "Macroeconomics", Credits = 3, });
                    departament.Add(new Departament { DepartamentID = 1045, Title = "Math", Credits = 4, });
                    departament.Add(new Departament { DepartamentID = 3141, Title = "Trigonometry", Credits = 4, });
                    departament.Add(new Departament { DepartamentID = 2021, Title = "Composition", Credits = 3, });
                    departament.Add(new Departament { DepartamentID = 2042, Title = "Literature", Credits = 4, });
                };


                context.Departament.AddRange(departament);

                context.SaveChanges();
            }

            static void CreateLectures(List<Departament> departament, List<Student> students)
            {
                using (var context = new StudyContext("StudentsDatabase"))
                {
                    List<Lecture> lecture = new List<Lecture>();

                    lecture.Add(new Lecture
                    {
                        StudentID = students.Single(s => s.LastName == "Kazlauskas").ID,
                        DepartamentID = departament.Single(c => c.Title == "Chemistry").DepartamentID,
                        Grade = Grade.A
                    });
                    lecture.Add(new Lecture
                    {
                        StudentID = students.Single(s => s.LastName == "Kazlauskas").ID,
                        DepartamentID = departament.Single(c => c.Title == "Microeconomics").DepartamentID,
                        Grade = Grade.C
                    });
                    lecture.Add(new Lecture
                    {
                        StudentID = students.Single(s => s.LastName == "Petryte").ID,
                        DepartamentID = departament.Single(c => c.Title == "Macroeconomics").DepartamentID,
                        Grade = Grade.B
                    });
                    lecture.Add(new Lecture
                    {
                        StudentID = students.Single(s => s.LastName == "Lasauskas").ID,
                        DepartamentID = departament.Single(c => c.Title == "Math").DepartamentID,
                        Grade = Grade.B
                    });
                    lecture.Add(new Lecture
                    {
                        StudentID = students.Single(s => s.LastName == "Lasauskas").ID,
                        DepartamentID = departament.Single(c => c.Title == "Trigonometry").DepartamentID,
                        Grade = Grade.B
                    });
                    lecture.Add(new Lecture
                    {
                        StudentID = students.Single(s => s.LastName == "Barzdukas").ID,
                        DepartamentID = departament.Single(c => c.Title == "Composition").DepartamentID,
                        Grade = Grade.B
                    });
                    lecture.Add(new Lecture
                    {
                        StudentID = students.Single(s => s.LastName == "Linkyte").ID,
                        DepartamentID = departament.Single(c => c.Title == "Chemistry").DepartamentID
                    });
                    lecture.Add(new Lecture
                    {
                        StudentID = students.Single(s => s.LastName == "Justinyte").ID,
                        DepartamentID = departament.Single(c => c.Title == "Microeconomics").DepartamentID,
                        Grade = Grade.B
                    });
                    lecture.Add(new Lecture
                    {
                        StudentID = students.Single(s => s.LastName == "Noreikaite").ID,
                        DepartamentID = departament.Single(c => c.Title == "Chemistry").DepartamentID,
                        Grade = Grade.B
                    });
                    lecture.Add(new Lecture
                    {
                        StudentID = students.Single(s => s.LastName == "Olintyte").ID,
                        DepartamentID = departament.Single(c => c.Title == "Composition").DepartamentID,
                        Grade = Grade.B
                    });
                    lecture.Add(new Lecture
                    {
                        StudentID = students.Single(s => s.LastName == "Olintyte").ID,
                        DepartamentID = departament.Single(c => c.Title == "Literature").DepartamentID,
                        Grade = Grade.B
                    });




                    foreach (Lecture e in lecture)
                    {
                        var lectureInDataBase = context.Lecture.Where(
                            s =>
                                 s.Student.ID == e.StudentID &&
                                 s.Departament.DepartamentID == e.DepartamentID).SingleOrDefault();
                        if (lectureInDataBase == null)
                        {
                            context.Lecture.Add(e);
                        }
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}

