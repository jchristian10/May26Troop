using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Day9Associations.Models
{
    public class Movie
    {
        [Key]  //sets this property to be the primary key in the database
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Director { get; set; }

//These Properties create a joint relationshipe between this Movie class and the category class
        
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }


//-----------------------------------------------------------------------------------------------

    }
}