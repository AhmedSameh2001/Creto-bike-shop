using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CretoBikeShop.Data.Models
{
	public class Cart
	{
		[Required]
		public int Id { get; set; }
		public int Qantity { get; set; }
		public double TotalPrice { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
