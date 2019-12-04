using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Results")]
    public class Results
    {
        [Key]
        [Required]
        [Display(Name = "ResultID")]
        public int ResultID { get; set; }

        [Required]
        [Display(Name = "TestID")]
        public int TestID { get; set; }

        [Required]
        [Display(Name = "RerunID")]
        public int RerunID { get; set; }

        [Required]
        [Display(Name = "LTNumber")]
        public int LTNumber { get; set; }

        [Required]
        [Display(Name = "OrderID")]
        public int OrderID { get; set; }

        [Required]
        [Display(Name = "FilePath")]
        public string FilePath { get; set; }

        [Required]
        [Display(Name = "Comments")]
        public string Comments { get; set; }

        [Required]
        [Display(Name = "CompletedBy")]
        [StringLength(30)]
        public string CompletedBy { get; set; }
    }
}