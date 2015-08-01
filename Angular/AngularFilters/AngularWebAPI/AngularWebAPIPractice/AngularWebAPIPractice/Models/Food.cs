using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularWebAPIPractice.Models
{
    public class Food
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Food Name is Required, fool!")]
        public string Name { get; set; }

    }
}