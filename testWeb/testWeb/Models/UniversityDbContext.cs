using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace testWeb.Models
{
    public class UniversityDbContext:DbContext
    {
        public DbSet<Department> Departments { set; get; }
        public DbSet<Student> Students { set; get; }
        public DbSet<Semester> Semesters { set; get; }
        public DbSet<Course> Courses { set; get; }
        public DbSet<Designation> Designations { set; get; }
        public DbSet<Room> Rooms { set; get; }
        public DbSet<AllocateRoom> AllocateRooms { set; get; }
        public DbSet<Teacher> Teachers { set; get; }
        public DbSet<StudentRegistration> StudentRegistrations { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Code First to ignore PluralizingTableName convention
            // If you keep this convention then the generated tables will have pluralized names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }


    }
}