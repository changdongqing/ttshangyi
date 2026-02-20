using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;
using TTShang.Abp.HttpApi.Client;

namespace TTShang.Abp.Client.Console
{
    [DependsOn(typeof(YiAbpHttpApiClientModule))]
    public class YiAbpClientConsoleModule:AbpModule
    {
    }
}
