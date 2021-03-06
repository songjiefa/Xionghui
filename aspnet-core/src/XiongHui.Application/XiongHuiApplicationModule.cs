﻿using System.Reflection;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Modules;
using Abp.Reflection.Extensions;
using XiongHui.Authorization;
using XiongHui.Authorization.Roles;
using XiongHui.Authorization.Users;
using XiongHui.MultiTenancy;
using XiongHui.Roles.Dto;
using XiongHui.Users.Dto;
using AutoMapper;

namespace XiongHui
{
    [DependsOn(
        typeof(XiongHuiCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class XiongHuiApplicationModule : AbpModule
    {

        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<XiongHuiAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(XiongHuiApplicationModule).GetAssembly());

            // TODO: Is there somewhere else to store these, with the dto classes
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Role and permission
                cfg.CreateMap<Permission, string>().ConvertUsing(r => r.Name);
                cfg.CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);    

                cfg.CreateMap<CreateRoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                cfg.CreateMap<RoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());

                IRepository<Role, int> repository = IocManager.Resolve<IRepository<Role, int>>();
                // User and role
                cfg.CreateMap<UserRole, string>().ConvertUsing(  (r) =>  {
                    //TODO: Fix, this seems hacky
                    Role role = repository.FirstOrDefault(r.RoleId);
                    return role.DisplayName;
                });

                IocManager.Release(repository);
                
                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

                cfg.CreateMap<CreateUserDto, User>();
                cfg.CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
            });
        }
    }
}