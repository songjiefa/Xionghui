using System;
using System.Collections.Generic;
using System.Text;

namespace XiongHui.Types
{
	public class Prices
	{
		public decimal Price { get; private set; }

		public UnitType Unit { get; private set; }

		public string Currency { get; set; }

		public Prices(decimal i_price,UnitType i_unit,string i_currency = "￥")
		{
			Price = i_price;
			Unit = i_unit;
			Currency = i_currency;
		}
	}
}
