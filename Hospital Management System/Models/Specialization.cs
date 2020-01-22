using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class Specialization
    {
        [Key]
        public byte Id { get; set; }

        [Required(ErrorMessage="Please enter Specialization")]
        [StringLength(20)]
        [Display(Name="Specialization")]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        //public int DoctorId { get; set; }
        //public Doctor Doctor { get; set; }
    }
}