using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
	public class ShoppingCartReceipt
	{
		public double TotalCostPrice { get; set; }
		public double BasicSalesTax { get; set; }
		public double ImportDutyTax { get; set; }
		public double GrandTotal { get; set; }
		public List<ShoppingCartItemWithTax> CartItems { get; set; }
	}
}
