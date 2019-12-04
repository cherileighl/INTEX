using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Employee_Positions")]
    public class Employee_Positions
    {
        [Key]
        [Required(ErrorMessage = "Position code required")]
        [Display(Name = "Position Code")]
        [StringLength(30)]
        public string PositionCode { get; set; }

        [Required(ErrorMessage = "Position title required")]
        [Display(Name = "Position Title")]
        [StringLength(30)]
        public string PositionTitle { get; set; }
    }
}