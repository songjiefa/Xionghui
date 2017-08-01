using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XiongHui.Entities;

namespace XiongHui.EntityFrameworkCore.Repositories.Interface
{
	public interface ICommodityRepository<T1, T2> : IRepository<Commodity, long>
	{
		Task<List<Commodity>> GetAllWithBarCodeAsync(string i_barCode);
		Task<List<Commodity>> GetAllWithFullNameAsync(string i_fullName);
		Task<List<Commodity>> GetAllWithRetailPricesAsync(decimal i_retailPrices);

		Task<List<Commodity>> GetAllWithRetailPricesAsync(decimal i_minRetailPrices, decimal i_maxRetailPrices);
	}
}
