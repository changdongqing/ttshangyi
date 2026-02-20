using TTShang.Abp.Domain;
using TTShang.Abp.SqlSugarCore;
using TTShang.Framework.AuditLogging.SqlSugarCore;
using TTShang.Framework.Mapster;
using TTShang.Framework.Rbac.SqlSugarCore;
using TTShang.Framework.SettingManagement.SqlSugarCore;
using TTShang.Framework.SqlSugarCore;
using TTShang.Framework.TenantManagement.SqlSugarCore;

namespace TTShang.Abp.SqlsugarCore
{
    [DependsOn(
        typeof(YiAbpDomainModule),
        typeof(YiFrameworkRbacSqlSugarCoreModule),
        typeof(YiFrameworkSettingManagementSqlSugarCoreModule),
        typeof(YiFrameworkAuditLoggingSqlSugarCoreModule),
        typeof(YiFrameworkTenantManagementSqlSugarCoreModule),
        typeof(YiFrameworkMapsterModule),
        typeof(YiFrameworkSqlSugarCoreModule)
    )]
    public class YiAbpSqlSugarCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddYiDbContext<YiDbContext>();
            //默认不开放，可根据项目需要是否Db直接对外开放
            //context.Services.AddTransient(x => x.GetRequiredService<ISqlSugarDbContext>().SqlSugarClient);
        }
    }
}