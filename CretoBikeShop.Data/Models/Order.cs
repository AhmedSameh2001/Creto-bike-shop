using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CretoBikeShop.Data.Models
{
	public class Order
	{
		[Required]
		public int Id { get; set; }
		[Required]
		public string Payment { get; set; }
		public double TotalPrice { get; set; }
		public int OrderProductId { get; set; }
		public OrderProduct OrderProduct { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }

		public List<Product> Products { get; set; }
	}
}
