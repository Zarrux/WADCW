using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WadCW.Models
{
    public class ProductViewModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
       [Required]
       [Range(1,9999999)]
        public decimal Price { get; set; }
        [DisplayName("Active")]
        public bool IsActive { get; set; }

        public string Description { get; set; }
        [DisplayName("Category")]
        public Category CategoryId { get; set; }
    }

    public enum Category
    {
        Smartphone,
        Tablet
    }
}