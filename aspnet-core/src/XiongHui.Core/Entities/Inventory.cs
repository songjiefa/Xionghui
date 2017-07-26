using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace XiongHui.Entities
{
	class Inventory : Entity<long>, IFullAudited
	{
		[ForeignKey("CommodityId")]
		public Commodity Commodity { get; set; }
		public long CommodityId { get; set; }

		public long Amount { get; set; }
		public long? CreatorUserId { get ; set ; }
		public DateTime CreationTime { get ; set ; }
		public long? LastModifierUserId { get ; set ; }
		public DateTime? LastModificationTime { get ; set ; }
		public long? DeleterUserId { get ; set ; }
		public DateTime? DeletionTime { get ; set ; }
		public bool IsDeleted { get ; set ; }
	}
}
