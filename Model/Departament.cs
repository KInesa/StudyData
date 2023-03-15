namespace EgzamDatabase.Model
{
    public class Departament
    {
        public int DepartamentID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Lecture> Lectures { get; set; }
        public virtual ICollection<Student> Student { get; set; }




    }
}
