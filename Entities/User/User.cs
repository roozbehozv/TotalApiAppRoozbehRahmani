using Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class User : BaseEntity
	{
		public User()
		{
			IsActive = true;
		}
		public int Id { get; set; }
		public bool IsActive { get; set; }
		[Required]
		[StringLength(100)]
		public string FirstName { get; set; }
		[Required]
		[StringLength(100)]
		public string LastName { get; set; }
		public string Fullname { get; set; }
		[Required, StringLength(100)]
		public string PasswordHash { get; set; }
		[Required]
		public int Age { get; set; }
		public Gender Gender { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime LastLoginDate { get; set; }
		public ICollection<Post> Posts { get; set; }



	}
}
