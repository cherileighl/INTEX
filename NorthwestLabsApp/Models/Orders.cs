using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [Required(ErrorMessage = "OrderID required")]
        [Display(Name = "OrderID")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "CustomerID required")]
        [Display(Name = "CustomerID")]
        public int CustomerID { get; set; }

        [Display(Name = "Date Arrived")]
        public DateTime DateArrived { get; set; }

        [Display(Name = "Received By")]
        [StringLength(30)]
        public string ReceivedBy { get; set; }

        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }

        [Display(Name = "Confirmation Date")]
        public DateTime? ConfirmationDate { get; set; }

        [Display(Name = "Comments")]
        public string Comments { get; set; }

        [Required(ErrorMessage = "Rush order required")]
        [Display(Name = "Rush Order")]
        public bool RushOrder { get; set; }

        [Display(Name = "Price")]
        public decimal? Price { get; set; }

        [Display(Name = "Discount Type")]
        public string DiscountType { get; set; }

        [Required(ErrorMessage = "Status code required")]
        [Display(Name = "Status Code")]
        [StringLength(30)]
        public string StatusCode { get; set; }

        [Display(Name = "Original Price Quote")]
        public decimal? OrgPriceQuote { get; set; }

        [Display(Name = "Adjusted Price Quote")]
        public decimal? AdjustedPriceQuote { get; set; }

        [Display(Name = "Data Report")]
        public string DataReport { get; set; }

        [Display(Name = "Summary Report")]
        public string SummaryReport { get; set; }
    }
}