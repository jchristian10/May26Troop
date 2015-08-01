using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Day9AssociationsPractice.Models
{
    class Movie
    {
        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Director { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
