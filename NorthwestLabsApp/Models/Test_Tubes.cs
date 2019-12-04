using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Test_Tubes")]
    public class Test_Tubes
    {
        [Key]
        [Required]
        [Display(Name = "LT Number")]
        public int LTNumber { get; set; }

        [Required]
        [Display(Name = "Test Tube Number")]
        public int TestTubeNum { get; set; }

        [Required]
        [Display(Name = "Test ID")]
        public int TestID { get; set; }

        [Required]
        [Display(Name = "Concentration")]
        public decimal Concentration { get; set; }
    }
}