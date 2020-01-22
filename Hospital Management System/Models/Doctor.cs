using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HMS.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Please enter Firstname")]
        [Display(Name = "Firstname")]
        public string Firstname { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Please enter Lastname")]
        [Display(Name = "Lastname")]
        public string Lastname { get; set; }

        public Specialization Specialization { get; set; }

        [Required(ErrorMessage="Please select Specialization")]
        [Display(Name="Specialization")]
        public byte SpecializationId { get; set; }
    }
}