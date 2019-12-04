using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Literature_References")]
    public class Literature_References
    {
        [Key]
        [Required(ErrorMessage = "ReferenceID required")]
        [Display(Name = "ReferenceID")]
        public int ReferenceID { get; set; }

        [Required(ErrorMessage = "Title required")]
        [Display(Name = "Title")]
        [StringLength(50)]
        public string Title { get; set; }

        [Display(Name = "Author")]
        [StringLength(50)]
        public string Author { get; set; }

        [Display(Name = "Date Published")]
        public string DatePublished { get; set; }

        [Display(Name = "Edition")]
        public int Edition { get; set; }
    }
}