using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day8Lab1.Models
{
    public class Product
    {
        [Required(ErrorMessage="Product name is required!")]
        [MaxLength(50, ErrorMessage="Product name is too long!")]
        [Remote("ValidateProduct", "Products", ErrorMessage="Product must be unique!", HttpMethod="Post")]
        public string Name { get; set; }
        [Range(0,100,ErrorMessage="Product price must be greater than 0, and less than 100")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        
        public decimal Weight { get; set; }

    }
}