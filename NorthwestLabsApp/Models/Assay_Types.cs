using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    public class Assay_Types
    {
        [Required(ErrorMessage = "Assay Type required.")]
        [DisplayName("Assay Type")]
        public string AssayType { get; set; }

        [Required(ErrorMessage = "Assay Type required.")]
        [DisplayName("Assay Type")]
        public string AssayDesc { get; set; }

        [Required(ErrorMessage = "Assay Type required.")]
        [DisplayName("Assay Type")]
        public string AssayProtocol { get; set; }

        [Required(ErrorMessage = "Assay Type required.")]
        [DisplayName("Assay Type")]
        public int DaysToComplete { get; set; }
    }
}