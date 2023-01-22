using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CretoBikeShop.Data.Models
{
	public class Feedback :BaseEntity
	{
		[Required]
		public int Id { get; set; }
		public string Description { get; set; }
		[Range(0,5)]
		[Required]
		public int Rate { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }
	}
}
