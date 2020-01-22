using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HMS.Models;
using System.ComponentModel.DataAnnotations;

namespace HMS.ViewModels
{
	public class RoomFormViewModel
	{
		public IEnumerable<RoomType> RoomTypes { get; set; }
		public IEnumerable<OccupancyStatus> OccupancyStatus { get; set; }

		public int Id { get; set; }

		[Required(ErrorMessage="Please enter Room No.")]
		[Display(Name = "Room No")]
		[StringLength(10)]
		public string RoomNo { get; set; }

		[Required(ErrorMessage="Please enter Price.")]
		public double Price { get; set; }

		[Required(ErrorMessage="Please select Room Type.")]
		[Display(Name="Room Type")]
		public byte RoomTypeId { get; set; }        

		[Required]
		public byte OccupancyStatusId { get; set; }        

		public string Title
		{
			get
			{
				return Id != 0 ? "Edit Room" : "New Room";            
			}
		}

		public RoomFormViewModel()
		{
			Id = 0;
		}

		public RoomFormViewModel(Room room)
		{
			Id = room.Id;
			RoomNo = room.RoomNo;
			Price = room.Price;
			RoomTypeId = room.RoomTypeId;
			OccupancyStatusId = room.OccupancyStatusId;
		}
	}
}