using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Payments")]
    public class Payments
    {
        [Key]
        [Required(ErrorMessage = "PaymentID required")]
        [Display(Name = "PaymentID")]
        public int PmtID { get; set; }

        [Required(ErrorMessage = "OrderID required")]
        [Display(Name = "OrderID")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Amount required")]
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }

        //hard code this and make it a dropdown
        //maybe add method table?
        [Required(ErrorMessage = "Method required")]
        [Display(Name = "Method")]
        [StringLength(30)]
        public string Method { get; set; }
    }
}