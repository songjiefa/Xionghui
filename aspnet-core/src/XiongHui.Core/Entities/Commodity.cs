using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;
using XiongHui.Types;

namespace XiongHui.Entities
{
	public class Commodity : Entity, IFullAudited
	{
		public virtual string BarCode { get; private set; }
		public virtual string FullName { get; private set; }
		public virtual string Surname { get; private set; }
	
		public virtual Prices RetailPrices { get; private set; }
		public virtual Prices WholeSalePrices { get; private set; }
		public virtual Prices CostPrices { get; private set; }

		public virtual DateTime CreationTime { get; set; }
		public long? CreatorUserId { get; set; }
		public long? LastModifierUserId { get; set; }
		public DateTime? LastModificationTime { get; set; }
		public long? DeleterUserId { get; set; }
		public DateTime? DeletionTime { get; set; }
		public bool IsDeleted { get; set; }

		public Commodity(
			string i_barCode,
			string i_fullName,
			Prices i_costPrice,
			Prices i_retailPrice,
			Prices i_wholeSalePrice,
			long? i_creatorUserId
			)
		{
			BarCode = i_barCode;
			FullName = i_fullName;
			CostPrices = i_costPrice;
			RetailPrices = i_retailPrice;
			WholeSalePrices = i_wholeSalePrice;

			CreatorUserId = i_creatorUserId;
			CreationTime = DateTime.Now;
			IsDeleted = false;
		}

		public void Update(
			string i_barCode,
			string i_fullName,
			Prices i_costPrice,
			Prices i_retailPrice,
			Prices i_wholeSalePrice,
			long? i_lastModifierUserId
			)
		{
			BarCode = i_barCode;
			FullName = i_fullName;
			CostPrices = i_costPrice;
			RetailPrices = i_retailPrice;
			WholeSalePrices = i_wholeSalePrice;

			LastModifierUserId = i_lastModifierUserId;
			LastModificationTime = DateTime.Now;
		}

		public void Delete(
			long i_deleteUserId
			)
		{
			IsDeleted = true;
			DeleterUserId = i_deleteUserId;
			DeletionTime = DateTime.Now;
		}
	}
}
