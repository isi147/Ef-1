namespace ConsoleApp25.Models
{
	public class Order :BaseEntity
	{
        public string Address { get; set; }

        public int AppUserId { get; set; }

		// Navigation property
		public AppUser AppUser { get; set; }
		public List<Product> Products { get; set; }
	}
}
