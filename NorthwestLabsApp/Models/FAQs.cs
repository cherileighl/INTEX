using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("FAQs")]
    public class FAQs
    {
        [Key]
        [Required(ErrorMessage = "FAQID required")]
        [Display(Name = "FAQ ID")]
        public int FAQID { get; set; }

        [Required(ErrorMessage = "Question required")]
        [Display(Name = "Question")]
        public string Question { get; set; }

        [Required(ErrorMessage = "Answer required")]
        [Display(Name = "Answer")]
        public string Answer { get; set; }
    }
}