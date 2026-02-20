using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace TTShang.Framework.AuditLogging.Domain.Shared
{
    [DependsOn(typeof(AbpDddDomainSharedModule))]
    public class YiFrameworkAuditLoggingDomainSharedModule:AbpModule
    {

    }
}
