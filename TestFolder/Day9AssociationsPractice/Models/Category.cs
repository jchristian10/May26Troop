﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day9AssociationsPractice.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}