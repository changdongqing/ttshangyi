using TTShang.Abp.Tool.Application.Contracts;
using TTShang.Abp.Tool.Domain;

namespace TTShang.Abp.Tool.Application
{
    [DependsOn(typeof(YiAbpToolApplicationContractsModule),
        typeof(YiAbpToolDomainModule))]
    public class YiAbpToolApplicationModule:AbpModule
    {

    }
}
