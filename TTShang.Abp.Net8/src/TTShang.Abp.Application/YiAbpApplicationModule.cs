using TTShang.Abp.Application.Contracts;
using TTShang.Abp.Domain;
using TTShang.Framework.Ddd.Application;
using TTShang.Framework.Rbac.Application;
using TTShang.Framework.SettingManagement.Application;
using TTShang.Framework.TenantManagement.Application;

namespace TTShang.Abp.Application
{
    [DependsOn(
        typeof(YiAbpApplicationContractsModule),
        typeof(YiAbpDomainModule),


        typeof(YiFrameworkRbacApplicationModule),
        
        typeof(YiFrameworkTenantManagementApplicationModule),
        typeof (YiFrameworkSettingManagementApplicationModule),

        typeof(YiFrameworkDddApplicationModule)
        )]
    public class YiAbpApplicationModule : AbpModule
    {
    }
}
