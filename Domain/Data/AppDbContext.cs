using System;
using Domain.Models;

namespace Domain.Data
{
	public class AppDbContext
	{
		public Category[] Categories()
		{
			return new Category[]
			{
				new Category{Id=1, Name = "Phone", CreatedDate = new DateTime(2023, 10, 25) },
				new Category{Id=2, Name = "TV", CreatedDate = new DateTime(2023, 10, 26) },
				new Category{Id=3, Name = "Console", CreatedDate = new DateTime(2023, 10, 27) },
				new Category{Id=4, Name = "Home", CreatedDate = new DateTime(2023, 10, 27) },
			};


		}


		public Product[] Products()
		{
			return new Product[]
			{
				new Product{Id=1, Name = "Iphone15", Price = 3500, CreatedDate = new DateTime(2023, 10,23), Category = Categories().FirstOrDefault(m=> m.Id == 1) },
                new Product{Id=1, Name = "Samsung", Price = 2000, CreatedDate = new DateTime(2023, 10,24),},
                new Product{Id=1, Name = "Iphone15", Price = 3500, CreatedDate = new DateTime(2023, 10,25),},
                new Product{Id=1, Name = "Iphone15", Price = 3500, CreatedDate = new DateTime(2023, 10,26),}
            };
		}
	}
}

