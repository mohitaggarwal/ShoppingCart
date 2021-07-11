using ShoppingCartLib.Interface;
using ShoppingCartLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
	public class ReceiptGenerator : IReceiptGenerator
	{
		private IProductRepository _productRepository;

		public ReceiptGenerator(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public ShoppingCartReceipt GetReceipt(int shoppingCartId)
		{
			ShoppingCartReceipt shoppingCartReceipt = new ShoppingCartReceipt();
			shoppingCartReceipt.CartItems = new List<ShoppingCartItemWithTax>();
			var cartProducts = _productRepository.GetShoppingCartProducts(shoppingCartId);
			if(cartProducts != null)
			{
				if (cartProducts.Count > 0)
				{
					double totalCost = 0, totalBasicSalesTax = 0, totalImportDutyTax = 0, grandTotal = 0;
					foreach (var cartProduct in cartProducts)
					{
						var productDetail = _productRepository.GetProduct(cartProduct.ProductId);
						if (productDetail != null)
						{
							double totalCostPrice = productDetail.Cost * cartProduct.Quantity;
							double basicSalesTax = 0;
							if (!productDetail.IsExemptFromSalesTax)
								basicSalesTax = Utills.RoundNearest((10 * totalCostPrice) / 100); // 10% sales tax
							double imprtDutyTax = 0;
							if (productDetail.IsImported)
								imprtDutyTax = Utills.RoundNearest((5 * totalCostPrice) / 100); // 5% import duty tax

							ShoppingCartItemWithTax shoppingCartProductWithTax = new ShoppingCartItemWithTax(cartProduct)
							{
								TotalCostPrice = totalCostPrice,
								BasicSalesTax = basicSalesTax,
								ImportDutyTax = imprtDutyTax,
								TotalSalesTax = basicSalesTax + imprtDutyTax
							};
							shoppingCartReceipt.CartItems.Add(shoppingCartProductWithTax);
							totalCost += totalCostPrice;
							totalBasicSalesTax += basicSalesTax;
							totalImportDutyTax += imprtDutyTax;
							grandTotal += totalCostPrice + basicSalesTax + imprtDutyTax;
						}
					}
					shoppingCartReceipt.TotalCostPrice = Utills.RoundNearest(totalCost);
					shoppingCartReceipt.BasicSalesTax = Utills.RoundNearest(totalBasicSalesTax);
					shoppingCartReceipt.ImportDutyTax = Utills.RoundNearest(totalImportDutyTax);
					shoppingCartReceipt.GrandTotal = Utills.RoundNearest(grandTotal);
				}
			}
			return shoppingCartReceipt;
		}
	}
}
