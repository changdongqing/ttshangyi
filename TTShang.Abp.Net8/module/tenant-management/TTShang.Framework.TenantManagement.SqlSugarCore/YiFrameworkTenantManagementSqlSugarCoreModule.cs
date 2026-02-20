using Volo.Abp.Modularity;
using TTShang.Framework.TenantManagement.Domain;

namespace TTShang.Framework.TenantManagement.SqlSugarCore
{
    [DependsOn(typeof(YiFrameworkTenantManagementDomainModule))]
    public class YiFrameworkTenantManagementSqlSugarCoreModule : AbpModule
    {
    }
}
