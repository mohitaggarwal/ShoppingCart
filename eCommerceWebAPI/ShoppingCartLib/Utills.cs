using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
	public class Utills
	{
		public static double RoundNearest(double value)
		{
			return Math.Round(value * 20) / 20.0;
		}
	}
}
