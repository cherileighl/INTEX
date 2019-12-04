using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Order_Discounts")]
    public class Order_Discounts
    {
        [Key]
        [Required(ErrorMessage = "OrderID required")]
        [Display(Name = "OrderID")]
        public int OrderID { get; set; }
    }
}