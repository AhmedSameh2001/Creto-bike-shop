using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CretoBikeShop.Data.Models
{
	public class Product
	{
		[Required]
		public int Id { get; set; }
		[Required]
		public string FullName { get; set; }
		public int Price { get; set; }
		public int? OldPrice { get; set; }
		[Required]
		public string Colors { get; set; }
		[Required]
		public string FrameSize { get; set; }
		[Required]
		public int WheelSize { get; set; }
		[Required]
		public int Qantity { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public string Video { get; set; }
		public List<ProductImage> ProductImage { get; set; }

		public int SliderId { get; set; }
		public Slider Slider { get; set; }

	}
}
