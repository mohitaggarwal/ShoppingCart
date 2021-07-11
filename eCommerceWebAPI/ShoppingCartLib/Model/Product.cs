using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
	public class Product
	{
		public int ProductId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Cost { get; set; }

		public Product() { }
		public Product(Product product)
		{
			ProductId = product.ProductId;
			Name = product.Name;
			Description = product.Description;
			Cost = product.Cost;
		}
	}
}
