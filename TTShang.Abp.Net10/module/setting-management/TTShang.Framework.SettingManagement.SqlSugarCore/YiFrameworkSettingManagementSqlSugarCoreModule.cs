using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using TTShang.Framework.SettingManagement.Domain;
using TTShang.Framework.SqlSugarCore;

namespace TTShang.Framework.SettingManagement.SqlSugarCore
{
    [DependsOn(
        typeof(YiFrameworkSettingManagementDomainModule),
        typeof(YiFrameworkSqlSugarCoreModule)
        )]
    public class YiFrameworkSettingManagementSqlSugarCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var services = context.Services;
            services.AddTransient<ISettingRepository, SqlSugarCoreSettingRepository>();
        }
    }
}
