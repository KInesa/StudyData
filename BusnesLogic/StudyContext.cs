using EgzamDatabase.Model;
using Microsoft.EntityFrameworkCore;

namespace StudentDatabase.BusnesLogic
{
    public class StudyContext : DbContext

    {
        internal readonly object Configuration;

        public StudyContext(string v) : base() { }

        public DbSet<Student> Student { get; set; }
        public DbSet<Lecture> Lecture { get; set; }
        public DbSet<Departament> Departament { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
            => option.UseSqlServer($"Server = localhost,Database = StudentsDatabase, Trusted_Connection = true, Encrypt = False");


    }
}
