using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using XiongHui.Entities;
using XiongHui.EntityFrameworkCore.Repositories.Interface;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace XiongHui.EntityFrameworkCore.Repositories
{
	public class CommodityRepository : AbpZeroTemplateRepositoryBase<Commodity, long>, ICommodityRepository<Commodity,long>
	{
		public CommodityRepository(IDbContextProvider<XiongHuiDbContext> i_dbContextProvider) : base(i_dbContextProvider)
		{
			
		}

		public Task<List<Commodity>> GetAllWithBarCodeAsync(string i_barCode)
		{
			return GetAllListAsync(m=> m.BarCode.Equals(i_barCode));
		}

		public Task<List<Commodity>> GetAllWithFullNameAsync(string i_fullName)
		{
			return GetAllListAsync(m => m.FullName.Contains(i_fullName));
		}

		public Task<List<Commodity>> GetAllWithRetailPricesAsync(decimal i_retailPrices)
		{
			return GetAllListAsync(m => m.RetailPrices.Price.Equals(i_retailPrices));
		}

		public Task<List<Commodity>> GetAllWithRetailPricesAsync(decimal i_minRetailPrices, decimal i_maxRetailPrices)
		{
			return GetAllListAsync(
				m => m.RetailPrices.Price >= i_minRetailPrices &&
				m.RetailPrices.Price <= i_maxRetailPrices);
		}
	}
}
