using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Referrals")]
    public class Referrals
    {
        [Key]
        [Required(ErrorMessage = "Referral code required")]
        [Display(Name = "Referral Code")]
        public int ReferralCode { get; set; }

        [Required(ErrorMessage = "CustomerID required")]
        [Display(Name = "CustomerID")]
        public int CustomerID { get; set; }

        [Display(Name = "NewCustID")]
        public int NewCustID { get; set; }
    }
}