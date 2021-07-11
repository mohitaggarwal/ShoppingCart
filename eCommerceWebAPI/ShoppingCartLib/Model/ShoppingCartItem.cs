using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
	public class ShoppingCartItem: Product
	{
		public int Quantity { get; set; }

		public ShoppingCartItem()
		{
		}

		public ShoppingCartItem(Product product)
			:base(product)
		{
		}
	}
}
