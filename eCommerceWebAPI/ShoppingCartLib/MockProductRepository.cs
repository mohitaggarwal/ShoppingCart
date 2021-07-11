using ShoppingCartLib.Interface;
using ShoppingCartLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
	public class MockProductRepository : IProductRepository
	{
		private List<ProductDetails> products = new List<ProductDetails>
		{
			new ProductDetails
			{
				ProductId = 1,
				Name = "Willow Bat",
				Description = "Lycan T20 Hard Plastic Cricket Bat for Tennis Ball, Wind Ball",
				Cost = 399,
				IsExemptFromSalesTax = false,
				IsImported = true
			},
			new ProductDetails
			{
				ProductId = 2,
				Name = "The Psychology of Money",
				Description = "The Psychology of Money Paperback – 1 September 2020",
				Cost = 173.85,
				IsExemptFromSalesTax = true,
				IsImported = false
			},
			new ProductDetails
			{
				ProductId = 3,
				Name = "Cherise Tapri Puneri Gauti Chai",
				Description = "Cherise Tapri Puneri Gauti Chai, Instant Tea Premix (23 g x 7 Sachets)",
				Cost = 251,
				IsExemptFromSalesTax = true,
				IsImported = true
			},
			new ProductDetails
			{
				ProductId = 4,
				Name = "Mi 11X",
				Description = "Mi 11X 5G Celestial Silver 6GB RAM 128GB ROM | SD 870 | DisplayMate A+ rated E4 AMOLED",
				Cost = 29999,
				IsExemptFromSalesTax = false,
				IsImported = true
			}
		};

		public ProductDetails GetProduct(int productId)
		{
			return products.FirstOrDefault(x => x.ProductId == productId);
		}

		public List<ShoppingCartItem> GetShoppingCartProducts(int shoppingCartId)
		{
			return products.Select(
				x => new ShoppingCartItem(x)
				{
					Quantity = shoppingCartId
				}).ToList();
		}
	}
}
