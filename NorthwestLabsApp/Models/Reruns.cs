using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Reruns")]
    public class Reruns
    {
        [Key]
        [Required(ErrorMessage = "RerunID required")]
        [Display(Name = "RerunID")]
        public int RerunID { get; set; }

        [Required(ErrorMessage = "Approved by required")]
        [Display(Name = "Approved By")]
        [StringLength(30)]
        public string ApprovedBy { get; set; }

        [Required(ErrorMessage = "Approval date required")]
        [Display(Name = "Approval Date")]
        public string ApprovalDate { get; set; }
    }
}