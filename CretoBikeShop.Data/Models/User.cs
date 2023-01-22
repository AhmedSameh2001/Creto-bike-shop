using CretoBikeShop.Core.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CretoBikeShop.Data.Models
{
	public class User : IdentityUser
	{

		[Required]
		public string FullName { get; set; }
		[Required]
		public string ImageUrl { get; set; }
		[Required]
		public string Email { get; set; }
		public bool isDelete { get; set; }
		public bool isSubscribe { get; set; }

		public UserType UserType { get; set; }

		public DateTime CreatedAt { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string UpdatedBy { get; set; }

		public int OrderId { get; set; }
		public Order Order { get; set; }
	}
}
