namespace ManyToManyPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oops : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CourseApplicationUsers", newName: "ApplicationUserCourses");
            DropPrimaryKey("dbo.ApplicationUserCourses");
            AddPrimaryKey("dbo.ApplicationUserCourses", new[] { "ApplicationUser_Id", "Course_CourseId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ApplicationUserCourses");
            AddPrimaryKey("dbo.ApplicationUserCourses", new[] { "Course_CourseId", "ApplicationUser_Id" });
            RenameTable(name: "dbo.ApplicationUserCourses", newName: "CourseApplicationUsers");
        }
    }
}
