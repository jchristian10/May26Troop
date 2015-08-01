namespace Day12Auth.Migrations
{
    using Day12Auth.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Day12Auth.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Day12Auth.Models.ApplicationDbContext context)
        {
            RoleStore<Role> roleStore = new RoleStore<Role>(context);//Dependancy injection
            RoleManager<Role> roleManager = new RoleManager<Role>(roleStore);

            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            if (!roleManager.RoleExists("Admin"))
            {
                roleManager.Create(new Role
                    {
                        Name = "Admin"
                    });
            }

            if (!roleManager.RoleExists("User"))
            {
                roleManager.Create(new Role
                    {
                        Name = "User"
                    });
            }

            ApplicationUser adminUser = userManager.FindByEmail("josh@codercamps.com");
            adminUser.FirstName = "Josh";
            adminUser.LastName = "Christiansen";
            if (adminUser != null)
            {
                if (!userManager.IsInRole(adminUser.Id, "Admin"))
                {
                    userManager.AddToRole(adminUser.Id, "Admin");      
                        
                }
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
