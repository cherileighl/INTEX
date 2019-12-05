using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwestLabsApp.Models
{
    [Table("Customers")]
    public class Customers
    {
        [Key]
        [Required(ErrorMessage = "CustomerID required")]
        [Display(Name = "CustomerID")]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Username required")]
        [Display(Name = "Username")]
        [StringLength(30)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password required")]
        [Display(Name = "Password")]
        [StringLength(30)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "First Name required")]
        [Display(Name = "First Name")]
        [StringLength(30)]
        public string CustFirstName { get; set; }

        [Required(ErrorMessage = "Last Name required")]
        [Display(Name = "Last Name")]
        [StringLength(30)]
        public string CustLastName { get; set; }

        [Required(ErrorMessage = "Primary phone required")]
        [Display(Name = "Primary Phone")]
        [StringLength(30)]
        [Phone]
        public string CustPrimaryPhone { get; set; }

        [Display(Name = "Secondary Phone")]
        [StringLength(30)]
        public string CustSecondaryPhone { get; set; }

        [Required(ErrorMessage = "Address line 1 required")]
        [Display(Name = "Address Line 1")]
        [StringLength(30)]
        public string CustAddress1 { get; set; }

        [Display(Name = "Address Line 2")]
        [StringLength(30)]
        public string CustAddress2 { get; set; }

        [Required(ErrorMessage = "City required")]
        [Display(Name = "City")]
        [StringLength(30)]
        public string CustCity { get; set; }

        [Required(ErrorMessage = "State required")]
        [Display(Name = "State")]
        [StringLength(30)]
        public string CustState { get; set; }

        [Required(ErrorMessage = "Zipcode required")]
        [Display(Name = "Zipcode")]
        [StringLength(5)]
        public string CustZip { get; set; }

        [Required(ErrorMessage = "Email required")]
        [Display(Name = "Email")]
        [StringLength(30)]
        [EmailAddress]
        public string CustEmail { get; set; }

        [Required(ErrorMessage = "Balance required")]
        [Display(Name = "Balance")]
        public decimal Balance { get; set; }

        [Required(ErrorMessage = "Order volume required")]
        [Display(Name = "Order Volume")]
        public int OrderVolume { get; set; }
    }
}