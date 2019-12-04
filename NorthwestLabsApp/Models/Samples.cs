using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Samples")]
    public class Samples
    {
        [Key, Column(Order = 0)]
        [Required]
        [Display(Name = "Compound Sequence Code")]
        public int CompSeqCode{ get; set; }

        [Key, Column(Order = 1)]
        [Required]
        [Display(Name = "LT Number")]
        public int LTNumber { get; set; }

        [Required]
        [Display(Name = "Test ID")]
        public int TestID { get; set; }

        [Required]
        [Display(Name = "Assay ID")]
        public int AssayID { get; set; }

        [Required]
        [Display(Name = "Appearance")]
        public string Appearance { get; set; }

    }
}