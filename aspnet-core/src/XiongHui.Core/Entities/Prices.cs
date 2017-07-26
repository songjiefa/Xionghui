using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;
using XiongHui.Types;

namespace XiongHui.Entities
{
	public class Prices : Entity<long>, IFullAudited
	{
		public decimal Price { get; private set; }

		public UnitType Unit { get; private set; }

		public long CommodityId { get; private set; }

		public CurrencyType CurrencyType { get; set; }
		public long? CreatorUserId { get; set; }
		public DateTime CreationTime { get; set; }
		public long? LastModifierUserId { get; set; }
		public DateTime? LastModificationTime { get; set; }
		public long? DeleterUserId { get; set; }
		public DateTime? DeletionTime { get; set; }
		public bool IsDeleted { get; set; }

		protected Prices(
			decimal i_price,
			UnitType i_unit,
			CurrencyType i_currencyType = CurrencyType.RMB)
		{
			Price = i_price;
			Unit = i_unit;
			CurrencyType = i_currencyType;
		}

		public static Prices Create(
			decimal i_price,
			UnitType i_unit,
			CurrencyType i_currencyType = CurrencyType.RMB)
		{
			return new Prices(i_price, i_unit, i_currencyType);
		}
	}
}
