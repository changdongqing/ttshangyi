using Volo.Abp.Modularity;
using TTShang.Framework.Mapster;
using TTShang.Framework.Rbac.Domain;
using TTShang.Framework.SqlSugarCore;

namespace TTShang.Framework.Rbac.SqlSugarCore
{
    [DependsOn(
        typeof(YiFrameworkRbacDomainModule),

        typeof(YiFrameworkMapsterModule),
        typeof(YiFrameworkSqlSugarCoreModule)
        )]
    public class YiFrameworkRbacSqlSugarCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddYiDbContext<YiRbacDbContext>();
        }
    }
}