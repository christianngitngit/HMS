using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class OccupancyStatus
    {
        [Key]
        public byte Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name="Room Status")]
        public string Status { get; set; }
        
        public bool Active { get; set; }

    }
}