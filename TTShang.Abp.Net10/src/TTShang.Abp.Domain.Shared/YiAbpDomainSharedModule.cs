using Volo.Abp.Domain;
using Volo.Abp.SettingManagement;
using TTShang.Framework.AuditLogging.Domain.Shared;
using TTShang.Framework.Rbac.Domain.Shared;

namespace TTShang.Abp.Domain.Shared
{
    [DependsOn(
        typeof(YiFrameworkRbacDomainSharedModule),
        typeof(YiFrameworkAuditLoggingDomainSharedModule),

        typeof(AbpSettingManagementDomainSharedModule),
        typeof(AbpDddDomainSharedModule))]
    public class YiAbpDomainSharedModule : AbpModule
    {

    }
}