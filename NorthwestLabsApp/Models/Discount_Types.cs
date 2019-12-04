using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Discount_Types")]
    public class Discount_Types
    {
        [Key]
        [Required(ErrorMessage = "Discount type required")]
        [Display(Name = "Discount type")]
        [StringLength(30)]
        public string DiscountType { get; set; }

        [Required(ErrorMessage = "Discount rate required")]
        [Display(Name = "Discount Rate")]
        public decimal DiscountRate { get; set; }
    }
}