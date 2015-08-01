using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManyToManyPractice.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string Name { get; set; }
        [InverseProperty("Student")]
        public virtual ICollection<StudentCourse> Users { get; set; }

    }
}