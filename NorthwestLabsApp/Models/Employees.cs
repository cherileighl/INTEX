using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    [Table("Employees")]
    public class Employees
    {
        [Key]
        [Required(ErrorMessage = "EmployeeID required")]
        [Display(Name = "EmployeeID")]
        public int EmpID { get; set; }

        [Required(ErrorMessage = "Username required")]
        [Display(Name = "Username")]
        [StringLength(30)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password required")]
        [Display(Name = "Password")]
        [StringLength(30)]
        public string Password { get; set; }

        [Required(ErrorMessage = "First name required")]
        [Display(Name = "First Name")]
        [StringLength(30)]
        public string EmpFirstName { get; set; }

        [Required(ErrorMessage = "Last name required")]
        [Display(Name = "Last name")]
        [StringLength(30)]
        public string EmpLastName { get; set; }

        [Required(ErrorMessage = "Hourly wage required")]
        [Display(Name = "Hourly Wage")]
        public string HourlyWage { get; set; }

        [Required(ErrorMessage = "Position code required")]
        [Display(Name = "Position Code")]
        [StringLength(30)]
        public string PositionCode { get; set; }
    }
}