using Volo.Abp.Modularity;
using TTShang.Framework.Ddd.Application.Contracts;
using TTShang.Framework.Rbac.Domain.Shared;

namespace TTShang.Framework.Rbac.Application.Contracts
{
    [DependsOn(
        typeof(YiFrameworkRbacDomainSharedModule),


        typeof(YiFrameworkDddApplicationContractsModule))]
    public class YiFrameworkRbacApplicationContractsModule : AbpModule
    {

    }
}