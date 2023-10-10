using ConsoleApp25.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25.Models
{
	public class AppUser : BaseEntity
	{
        public string UserName { get; set; }

        public string Password { get; set; }

        public string RePassword { get; set; }

		public Roles Role { get; set; }


		// Navigation property
		public AppUserDetails AppUserDetail { get; set; }
		public List<Order> Orders { get; set; }

	}
}
