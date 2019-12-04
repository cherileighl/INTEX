using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NorthwestLabsApp.Models
{
    [Table("Compounds")]
    public class Compounds
    {
        [Key]
        [Required(ErrorMessage = "LTNumber required")]
        [Display(Name = "LT Number")]
        public int LTNumber { get; set; }

        [Required(ErrorMessage = "OrderID required")]
        [Display(Name = "OrderID")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Compound name required")]
        [Display(Name = "Compound Name")]
        [StringLength(30)]
        public string CompoundName { get; set; }

        [Required(ErrorMessage = "Quantity required")]
        [Display(Name = "Quantity")]
        public int CompoundQty { get; set; }

        [Required(ErrorMessage = "Active status required")]
        [Display(Name = "Active")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "Weight required")]
        [Display(Name = "Weight")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Molecular mass required")]
        [Display(Name = "Molecular mass")]
        public decimal MolecularMass { get; set; }

        [Required(ErrorMessage = "MTD required")]
        [Display(Name = "MTD")]
        public decimal MTD { get; set; }
    }
}