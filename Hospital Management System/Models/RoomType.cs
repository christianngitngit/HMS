using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class RoomType
    {
        [Key]
        public byte Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name="Room Type")]
        public string RoomTypeDescription { get; set; }
    }
}