using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CretoBikeShop.Data.Models
{
	public class News : BaseEntity
	{
		[Required]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public string ImageUrl { get; set; }

		public string Auther { get; set; }
		public User AutherId { get; set; }
	}
}
