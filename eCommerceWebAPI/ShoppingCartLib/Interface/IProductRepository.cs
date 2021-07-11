using ShoppingCartLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Interface
{
	public interface IProductRepository
	{
		List<ShoppingCartItem> GetShoppingCartProducts(int shoppingCartId);
		ProductDetails GetProduct(int productId);
	}
}
