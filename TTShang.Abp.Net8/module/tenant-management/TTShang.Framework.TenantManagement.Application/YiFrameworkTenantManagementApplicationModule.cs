using Volo.Abp.Modularity;
using TTShang.Framework.Ddd.Application;
using TTShang.Framework.TenantManagement.Domain;

namespace TTShang.Framework.TenantManagement.Application
{
    [DependsOn(typeof(YiFrameworkTenantManagementDomainModule))]
    public class YiFrameworkTenantManagementApplicationModule: AbpModule
    {

    }
}
