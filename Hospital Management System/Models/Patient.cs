using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage="Please enter Firstname")]
        [Display(Name="Firstname")]
        public string Firstname { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Please enter Lastname")]
        [Display(Name = "Lastname")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please enter date of birth")]
        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Please enter Gender")]
        [Display(Name = "Gender")]
        [StringLength(1)]
        public string Gender { get; set; }
    }
}