using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Order_Statuses")]
    public class Order_Statuses
    {
        [Key]
        [Required(ErrorMessage = "Status code required")]
        [Display(Name = "Status Code")]
        [StringLength(30)]
        public string StatusCode { get; set; }

        [Required(ErrorMessage = "Status description required")]
        [Display(Name = "Status Description")]
        public string StatusDescription { get; set; }
    }
}