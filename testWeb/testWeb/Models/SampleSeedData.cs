using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace testWeb.Models
{
    public class SampleSeedData:DropCreateDatabaseIfModelChanges<UniversityDbContext>
    {
        protected override void Seed(UniversityDbContext context)
        {
            context.Semesters.Add(new Semester() { Name = "1st Semister" });
            context.Semesters.Add(new Semester() { Name = "2nd Semister" });
            context.Semesters.Add(new Semester() { Name = "3rd Semister" });
            context.Semesters.Add(new Semester() { Name = "4th Semister" });
            context.Semesters.Add(new Semester() { Name = "5th Semister" });
            context.Semesters.Add(new Semester() { Name = "6th Semister" });
            context.Semesters.Add(new Semester() { Name = "7th Semister" });
            context.Semesters.Add(new Semester() { Name = "8th Semister" });
            context.Semesters.Add(new Semester() { Name = "9th Semister" });
            context.SaveChanges();

            context.Designations.Add(new Designation() {Name = "Professor"});
            context.Designations.Add(new Designation() { Name = "Asst.Professor" });
            context.Designations.Add(new Designation() { Name = "General Teacher" });
            context.SaveChanges();

            context.Rooms.Add(new Room() {RoomNumber = "1st Floor 001"});
            context.Rooms.Add(new Room() { RoomNumber = "2nd Floor 002" });
            context.Rooms.Add(new Room() { RoomNumber = "3rd Floor 003" });
            context.Rooms.Add(new Room() { RoomNumber = "4th Floor 004" });
            context.Rooms.Add(new Room() { RoomNumber = "5th Floor 005" });
            context.SaveChanges();


        }
    }
}