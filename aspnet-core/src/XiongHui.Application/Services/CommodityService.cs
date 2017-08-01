//using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.Zero.EntityFrameworkCore;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XiongHui.Dto;
using XiongHui.Entities;
using XiongHui.EntityFrameworkCore;
using XiongHui.EntityFrameworkCore.Repositories.Interface;
using XiongHui.Services.Interface;


namespace XiongHui.Services
{
	class CommodityService : XiongHuiAppServiceBase, ICommodityService
	{
		private readonly ICommodityRepository<Commodity,long> m_commodityRepository;

		public CommodityService(ICommodityRepository<Commodity,long> i_commodityRepository)
		{
			m_commodityRepository = i_commodityRepository;			
		}

		public Task<Commodity> CreateAsync(CommodityDto i_commodityDto)
		{
			var commodity = Mapper.Map<Commodity>(i_commodityDto);
			var result = m_commodityRepository.InsertAsync(commodity);

			return result;
		}

		public async Task<List<CommodityDto>> GetAllAsync(bool isDelete)
		{
			var commodities = await m_commodityRepository
				.GetAll()
				.WhereIf(isDelete,m=>m.IsDeleted == isDelete)
				.OrderByDescending(m=>m.FullName)
				.ToListAsync();
			
			return ObjectMapper.Map<List<CommodityDto>>(commodities);
		}

		public Task<List<CommodityDto>> GetAllWithBarCodeAsync(string i_barCode)
		{

			var commodities = m_commodityRepository.GetAllWithBarCodeAsync(i_barCode);
			return Mapper.Map<Task<List<CommodityDto>>>(commodities);
			 
			
		}

		public Task<List<CommodityDto>> GetAllWithFullNameAsync(string i_fullName)
		{
			var commodities = m_commodityRepository.GetAllWithFullNameAsync(i_fullName);
			return Mapper.Map<Task<List<CommodityDto>>>(commodities);
		}

		public Task<List<CommodityDto>> GetAllWithRetailPricesAsync(decimal i_retailPrices)
		{
			var commodities = m_commodityRepository.GetAllWithRetailPricesAsync(i_retailPrices);
			return Mapper.Map<Task<List<CommodityDto>>>(commodities);
		}

		public Task<List<CommodityDto>> GetAllWithRetailPricesAsync(decimal i_minRetailPrices, decimal i_maxRetailPrices)
		{
			var commodities = m_commodityRepository.GetAllWithRetailPricesAsync(i_minRetailPrices, i_maxRetailPrices);
			return Mapper.Map<Task<List<CommodityDto>>>(commodities);
		}

		
			
	}
}
