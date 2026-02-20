using Volo.Abp.Caching;
using Volo.Abp.Domain;
using TTShang.Abp.Domain.Shared;
using TTShang.Framework.AuditLogging.Domain;
using TTShang.Framework.Mapster;
using TTShang.Framework.Rbac.Domain;
using TTShang.Framework.SettingManagement.Domain;
using TTShang.Framework.TenantManagement.Domain;

namespace TTShang.Abp.Domain
{
    [DependsOn(
        typeof(YiAbpDomainSharedModule),

        typeof(YiFrameworkTenantManagementDomainModule),
        typeof(YiFrameworkRbacDomainModule),
        typeof(YiFrameworkAuditLoggingDomainModule),
        typeof(YiFrameworkSettingManagementDomainModule),

        typeof(YiFrameworkMapsterModule),
        typeof(AbpDddDomainModule),
        typeof(AbpCachingModule)
        )]
    public class YiAbpDomainModule : AbpModule
    {

    }
}