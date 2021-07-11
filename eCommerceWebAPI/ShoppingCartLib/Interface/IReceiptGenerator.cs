using ShoppingCartLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Interface
{
	public interface IReceiptGenerator
	{
		ShoppingCartReceipt GetReceipt(int shoppingCartId);
	}
}
