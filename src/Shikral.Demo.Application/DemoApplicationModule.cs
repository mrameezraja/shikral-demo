﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Shikral.Demo.Authorization;

namespace Shikral.Demo
{
    [DependsOn(
        typeof(DemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
