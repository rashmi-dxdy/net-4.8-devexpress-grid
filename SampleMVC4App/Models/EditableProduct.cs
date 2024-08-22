using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleMVC4App.Models
{
    public class EditableProduct
    {
        public int ProductID { get; set; }


        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(50, ErrorMessage = "Must be under 50 characters")]
        public string ProductName { get; set; }


        [Range(0, 10000, ErrorMessage = "Must be between 0 and 10000$")]
        public decimal? Price { get; set; }
    }
}