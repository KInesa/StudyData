namespace EgzamDatabase.Model
{
    public class Student
    {

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime LectureDate { get; set; }

        public virtual ICollection<Lecture> Lectures { get; set; }
        public int DepartamentId { get; }
        public object StudentID { get; }
    }
}


