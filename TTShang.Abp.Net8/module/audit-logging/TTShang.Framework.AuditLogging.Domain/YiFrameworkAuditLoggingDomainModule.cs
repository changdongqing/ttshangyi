using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Auditing;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using TTShang.Framework.AuditLogging.Domain.Shared;

namespace TTShang.Framework.AuditLogging.Domain
{
    [DependsOn(typeof(YiFrameworkAuditLoggingDomainSharedModule),
        
        
        typeof(AbpDddDomainModule),
        typeof(AbpAuditingModule)
        )]
    public class YiFrameworkAuditLoggingDomainModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

        }
    }
}
