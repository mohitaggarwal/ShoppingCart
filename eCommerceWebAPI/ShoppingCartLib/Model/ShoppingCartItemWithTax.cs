using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
	public class ShoppingCartItemWithTax: ShoppingCartItem
	{
		public double TotalCostPrice { get; set; }
		public double BasicSalesTax { get; set; }
		public double ImportDutyTax { get; set; }
		public double TotalSalesTax { get; set; }

		public ShoppingCartItemWithTax() { }
		public ShoppingCartItemWithTax(ShoppingCartItem shoppingCartProduct)
			:base(shoppingCartProduct)
		{
			Quantity = shoppingCartProduct.Quantity;
		}
	}
}
