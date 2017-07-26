using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using XiongHui.Types;

namespace XiongHui.Entities
{
	public class Bill : Entity<long>, IFullAudited
	{
		[ForeignKey("CommodityId")]
		public Commodity Commodity { get; set; }

		public long CommodityId { get; set; }

		public long? BillNumber { get; }
		public long? CreatorUserId { get; set; }
		public DateTime CreationTime { get; set; }
		public long? LastModifierUserId { get; set; }
		public DateTime? LastModificationTime { get; set; }
		public long? DeleterUserId { get; set; }
		public DateTime? DeletionTime { get; set; }
		public bool IsDeleted { get; set; }

		public Bill(Commodity i_commodity, long? i_createrUserId)
		{
			CommodityId = i_commodity.Id;
			Commodity = i_commodity;
			CreatorUserId = i_createrUserId;
			CreationTime = Clock.Now;
		}

		public void Delete(long i_deleterUserId)
		{
			DeleterUserId = i_deleterUserId;
			DeletionTime = Clock.Now;
		}
	}
}
