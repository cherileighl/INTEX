using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Tests")]
    public class Tests
    {
        [Key]
        [Required]
        [Display(Name = "Test ID")]
        public int TestID{ get; set; }

        [Required]
        [Display(Name = "Assay ID")]
        public int AssayID{ get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Test Code")]
        public string TestCode { get; set; }

        [Required]
        [Display(Name = "Employee ID")]
        public int EmpID { get; set; }

        //db has these as 'date', could cause problems        
        [Display(Name = "Scheduled Date")]
        public string ScheduledDate { get; set; }

        [Display(Name = "Completion Date")]
        public string CompletionDate { get; set; }

    }
}