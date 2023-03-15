using StudentDatabase.BusnesLogic;

internal class Program
{
    private static void Main(string[] args)
    {
        static void ShowAllDepartamentStudent()
        {
            using (var context = new StudyContext("StudentsDatabase"))


            {
                var department = context.Departament.FirstOrDefault(d => d.DepartamentID == 2041);

                if (department.Student != null)
                {
                    foreach (var item in department.Student)
                    {
                        Console.WriteLine(item.ID);
                    }
                }
            }
        }
        static void ShowAllDepartamentLecture()
        {
            using (var context = new StudyContext("StudentsDatabase"))


            {
                var department = context.Departament.FirstOrDefault(d => d.DepartamentID == 2041);

                if (department.Lectures != null)
                {
                    foreach (var item in department.Lectures)
                    {
                        Console.WriteLine(item.LectureID);
                    }
                }
            }
        }
        static void ShowStudentsLecture()
        {
            using (var context = new StudyContext("StudentsDatabase"))


            {
                var student = context.Student.FirstOrDefault(s => s.LastName == "Lasauskas");

                if (student.Lectures != null)
                {
                    foreach (var item in student.Lectures)
                    {
                        Console.WriteLine(item.LectureID);
                    }
                }
            }
        }



    }

}