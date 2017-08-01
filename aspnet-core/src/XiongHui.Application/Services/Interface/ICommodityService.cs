using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XiongHui.Dto;
using XiongHui.Entities;

namespace XiongHui.Services.Interface
{
	interface ICommodityService : IApplicationService
	{
		Task<List<CommodityDto>> GetAllAsync(bool isDelete);
		Task<List<CommodityDto>> GetAllWithBarCodeAsync(string i_barCode);
		Task<List<CommodityDto>> GetAllWithFullNameAsync(string i_fullName);
		Task<List<CommodityDto>> GetAllWithRetailPricesAsync(decimal i_retailPrices);

		Task<List<CommodityDto>> GetAllWithRetailPricesAsync(decimal i_minRetailPrices, decimal i_maxRetailPrices);

		Task<Commodity> CreateAsync(CommodityDto i_commodityDto);
	}
}
