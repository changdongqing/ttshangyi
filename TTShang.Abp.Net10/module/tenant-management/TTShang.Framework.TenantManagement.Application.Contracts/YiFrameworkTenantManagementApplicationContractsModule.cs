using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;
using TTShang.Framework.Ddd.Application.Contracts;

namespace TTShang.Framework.TenantManagement.Application.Contracts
{
    [DependsOn(typeof(AbpTenantManagementDomainSharedModule),
        typeof(YiFrameworkDddApplicationContractsModule))]
    public class YiFrameworkTenantManagementApplicationContractsModule:AbpModule
    {

    }
}
