using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;
using Volo.Abp.Timing;
using TTShang.Framework.SettingManagement.Domain;

namespace TTShang.Framework.SettingManagement.Application;

[DependsOn(
    typeof(AbpDddApplicationModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(YiFrameworkSettingManagementDomainModule),
    typeof(AbpTimingModule)

)]
public class YiFrameworkSettingManagementApplicationModule : AbpModule
{
}
