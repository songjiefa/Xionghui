using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XiongHui.Entities;

namespace XiongHui.Dto
{
	[AutoMapFrom(typeof(Commodity),typeof(Prices))]
	public class CommodityDto : EntityDto<long>, IFullAudited
	{
		public virtual string BarCode { get; private set; }
		public virtual string FullName { get; private set; }
		public virtual string Surname { get; private set; }

		public virtual Prices RetailPrices { get; private set; }

		public virtual Prices WholeSalePrices { get; private set; }
		public virtual Prices CostPrices { get; private set; }

		public long? CreatorUserId { get; set; }
		public DateTime CreationTime { get; set; }
		public long? LastModifierUserId { get; set; }
		public DateTime? LastModificationTime { get; set; }
		public long? DeleterUserId { get; set; }
		public DateTime? DeletionTime { get; set; }
		public bool IsDeleted { get; set; }
	}
}
