using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day9Associations.Models
{
    public class Category
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }  //When entity framework builds the database, the "virtual" type will make sure that the database does not have a "virtual" type

    }
}