using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HushHush.Models
{
    public class DataContext : DbContext
    {
        public IDbSet<Post> Posts { get; set; }
    }
}