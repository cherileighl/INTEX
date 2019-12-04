using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Test_Types")]
    public class Test_Types
    {
        [Key]
        [Required]
        [StringLength(30)]
        [Display(Name="Test Code")]
        public string TestCode { get; set; }

        [Required]
        [Display(Name="Test Description")]
        public string TestDesc { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Assay Type")]
        public string AssayType { get; set; }

        [Required]
        [Display(Name = "Material Cost")]
        public decimal MaterialsCost { get; set; }

        [Required]
        [Display(Name="Base Price")]
        public decimal BasePrice { get; set; }

        [Required]
        [Display(Name="Hours")]
        public int Hours { get; set; }

        [Required]
        [Display(Name="Price Quote")]
        public decimal PriceQuote{ get; set; }

        // is bit in DB could be problematic
        [Required]
        [Display(Name="Required (True/False)")]
        public bool Required { get; set; }

    }
}