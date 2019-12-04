using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Invoices")]
    public class Invoices
    {
        [Key]
        [Required(ErrorMessage = "InvoiceID required")]
        [Display(Name = "InvoiceID")]
        public int InvoiceID { get; set; }

        [Required(ErrorMessage = "OrderID required")]
        [Display(Name = "OrderID")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Due date required")]
        [Display(Name = "Payment Due Date")]
        public string PmtDueDate { get; set; }

        [Display(Name = "Early Payment Date")]
        public string EarlyPmtDate { get; set; }

        //make money strings so you can add $?
        [Display(Name = "Advance")]
        public decimal AdvanceAmt { get; set; }

        [Display(Name = "Discount")]
        public decimal DiscountAmt { get; set; }

        [Required(ErrorMessage = "Subtotal required")]
        [Display(Name = "Subtotal")]
        public decimal Subtotal { get; set; }

        [Required(ErrorMessage = "Tax rate required")]
        [Display(Name = "Tax Rate")]
        public decimal TaxRate { get; set; }

        [Required(ErrorMessage = "Sales tax required")]
        [Display(Name = "Sales Tax")]
        public decimal SalesTax { get; set; }

        [Required(ErrorMessage = "Shipping required")]
        [Display(Name = "Shipping")]
        public decimal Shipping { get; set; }

        [Required(ErrorMessage = "Total required")]
        [Display(Name = "Total")]
        public decimal InvoiceTotal { get; set; }
    }
}