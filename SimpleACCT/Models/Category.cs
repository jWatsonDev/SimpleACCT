using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleACCT.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Category/Job Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string DateAdded { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}