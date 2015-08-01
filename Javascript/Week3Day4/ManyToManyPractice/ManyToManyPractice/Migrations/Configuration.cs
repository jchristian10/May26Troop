namespace ManyToManyPractice.Migrations
{
    using ManyToManyPractice.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ManyToManyPractice.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ManyToManyPractice.Models.ApplicationDbContext context)
        {
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            ApplicationUser nick = userManager.FindByName("nick@codercamps.com");
            if (nick == null)
            {
                nick = new ApplicationUser
                {
                    FirstName = "Nick",
                    LastName = "Brittain",
                    Email = "nick@codercamps.com",
                    UserName = "nick@codercamps.com"
                };

                userManager.Create(nick, "123456");

                nick = userManager.FindByName("nick@codercamps.com");
            }

            Course math = new Course { Name = "Math" };
            Course english = new Course { Name = "English" };

            context.Courses.AddOrUpdate(c => c.Name, math, english);
            context.SaveChanges();

            nick.Courses.Add(math);
            nick.Courses.Add(english);

            if (!nick.Courses.Any(c=>c.Course.Name == "Math"))
            {
                nick.Courses.Add(new StudentCourse 
                    {
                        CourseId=math.CourseId
                    });
            }

            if(!nick.Courses.Any(c=>c.Course.Name == "English"))
            {
                nick.Courses.Add(new StudentCourse
                {
                    CourseId = english.CourseId
                });
            }
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
