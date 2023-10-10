using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25.Models
{
	public class AppUserDetails:BaseEntity
	{
        public string FirstName { get; set; }
		public string LastName { get; set; }
        public string Email { get; set; }

		//Foreign key
		public int AppUserId { get; set; }
		// Navigation property
		public AppUser AppUser { get; set; }
	}
}
