using Volo.Abp.Modularity;
using TTShang.Abp.HttpApi.Client;

namespace TTShang.Abp.Client.WebApi
{
    [DependsOn(typeof(YiAbpHttpApiClientModule))]
    public class YiAbpClientWebApiModule:AbpModule
    {
    }
}
