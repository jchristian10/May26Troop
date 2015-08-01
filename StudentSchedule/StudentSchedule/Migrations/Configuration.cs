namespace StudentSchedule.Migrations
{
    using StudentSchedule.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSchedule.DbContexts.StudentDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentSchedule.DbContexts.StudentDbContext context)
        {

            Student[] students = new Student[]
            {
                new Student {FirstName = "Josh", LastName="Christiansen"},
                new Student {FirstName = "David", LastName="Whaley"},
                new Student {FirstName = "Brett", LastName="Isachode"}
            };

            context.Students.AddOrUpdate(s => new { s.FirstName, s.LastName }, students);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
