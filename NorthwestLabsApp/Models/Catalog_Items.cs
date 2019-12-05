using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    public class Catalog_Items
    {
        [Required]
        [Display(Name = "Assay Type")]
        [StringLength(30)]
        public string AssayType { get; set; }

        [Required]
        [Display(Name = "Assay Type")]
        public string AssayDesc { get; set; }

        [Required]
        [Display(Name = "Assay Type")]
        public string AssayProtocol { get; set; }

        [Required]
        [Display(Name = "Assay Type")]
        public string Materials { get; set; }

        [Required]
        [Display(Name = "Assay Type")]
        [StringLength(50)]
        public string Title { get; set; }
    }
}