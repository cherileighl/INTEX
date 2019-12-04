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
        [Required(ErrorMessage = "Assay type required.")]
        [DisplayName("Assay Type")]
        [StringLength(30)]
        public string AssayType { get; set; }

        [DisplayName("Assay Description")]
        //database has varchar(MAX) - might need to specify string length?
        public string AssayDesc { get; set; }

        [DisplayName("Assay Protocol")]
        public string AssayProtocol { get; set; }

        [DisplayName("Days to Complete")]
        public int DaysToComplete { get; set; }

        [DisplayName("Materials")]
        public string Materials { get; set; }
    }
}