using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    public class Assay_References
    {
        [Required(ErrorMessage = "Assay type required.")]
        [Display(Name = "Assay Type")]
        [StringLength(30)]
        public string AssayType { get; set; }

        [Required(ErrorMessage = "ReferenceID required.")]
        [Display(Name = "ReferenceID")]
        public int ReferenceID { get; set; }
    }
}