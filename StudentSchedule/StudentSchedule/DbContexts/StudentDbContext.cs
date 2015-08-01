using StudentSchedule.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentSchedule.DbContexts
{
    public class StudentDbContext : DbContext
    {
        public IDbSet<Student> Students { get; set;}
    }
}