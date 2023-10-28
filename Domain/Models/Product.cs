using System;
namespace Domain.Models
{
	public class Product : BaseEntity
	{
		
		public string Name { get; set; }
		public Category Category { get; set; }
		public decimal Price { get; set; }
		public DateTime CreatedDate { get; set; }
		
	}
}

