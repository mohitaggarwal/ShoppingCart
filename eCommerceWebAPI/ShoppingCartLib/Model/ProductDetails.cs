using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
	public class ProductDetails: Product
	{
		public bool IsExemptFromSalesTax { get; set; }
		public bool IsImported { get; set; }
	}
}
