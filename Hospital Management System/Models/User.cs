using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage="Username is required")]
        public string Username { get; set; }
        
        [StringLength(50)]
        [Display(Name="First Name")]
        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Display(Name="Last Name")]
        [Required(ErrorMessage="Lastname is required")]
        public string LastName { get; set; }

        [StringLength(50)]
        [Required]
        [EmailAddress(ErrorMessage="Email address is not valid")]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }
}