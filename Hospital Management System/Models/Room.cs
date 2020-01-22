using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Room No")]
        [StringLength(10)]
        public string RoomNo { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public byte RoomTypeId { get; set; }

        public RoomType RoomType { get; set; }

        [Required]
        public byte OccupancyStatusId { get; set; }

        public OccupancyStatus OccupancyStatus { get; set; }
    }
}