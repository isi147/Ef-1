using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25.Models
{
	public class Category : BaseEntity
	{
		public string Name { get; set; }

		public string Description { get; set; }


		// Navigation property
		public List<Product> Products { get; set; }
	}
}
