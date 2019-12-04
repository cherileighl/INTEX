using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    public class Assays
    {
        [Required]
        [DisplayName("AssayID")]
        public int AssayID { get; set; }

        [Required(ErrorMessage = "Assay type required.")]
        [DisplayName("Assay Type")]
        [StringLength(30)]
        public string AssayType { get; set; }
    }
}