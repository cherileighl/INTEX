using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Assay_References")]
    public class Assay_References
    {
        [Key]
        [Required(ErrorMessage = "Assay type required.")]
        [Display(Name = "Assay Type")]
        [StringLength(30)]
        public string AssayType { get; set; }

        [Required(ErrorMessage = "ReferenceID required.")]
        [Display(Name = "ReferenceID")]
        public int ReferenceID { get; set; }
    }
}