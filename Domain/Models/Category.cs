﻿using System;
namespace Domain.Models
{
	public class Category : BaseEntity
	{
		public string Name { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}

