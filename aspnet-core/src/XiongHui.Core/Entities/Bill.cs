using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;
using XiongHui.Types;

namespace XiongHui.Entities
{
	public class Bill : Entity, IFullAudited
	{
		public Dictionary<Commodity,int> CommodityList { get; set; }

		public Prices TotoalPrice
		{
			get
			{
				decimal prices = 0;
				foreach(var commodity in CommodityList)
				{
					prices += commodity.Key.RetailPrices.Price;
				}
				return new Prices(prices,UnitType.Package);
			}
		}
		public long? CreatorUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public long? LastModifierUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime? LastModificationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public long? DeleterUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime? DeletionTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
