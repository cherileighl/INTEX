using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwestLabsApp.Models
{
    [Table("Company_Information")]
    public class Company_Information
    {
        [Key]
        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(30)]
        public string CompanyPhone { get; set; }

        [Required]
        [StringLength(30)]
        public string CompanyEmail { get; set; }

        [Required]
        [StringLength(30)]
        public string CompanyFax { get; set; }

        [Required]
        [StringLength(50)]
        public string MailingAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string PhysicalAddress { get; set; }

        [Required]
        [StringLength(30)]
        public string CompanyURL { get; set; }

        [Required]
        public DateTime DateFounded { get; set; }
    }
}