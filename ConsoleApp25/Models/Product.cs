
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25.Models
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }

		public decimal UnitePrice { get; set; }

		public short UnitInStock { get; set; }

		// Foreign key
		public int CategoryId { get; set; }

		
		// Navigation property
		public Category Category { get; set; }
		public List<Order> Orders { get; set; }

	}
}
