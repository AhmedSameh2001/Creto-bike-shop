using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CretoBikeShop.Data.Models
{
	public class CommentEvaluation
	{
		[Required]
		public int Id { get; set; }
		public string Comment { get; set; }
		[Range(0,5)]
		public int Rate { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }

		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
