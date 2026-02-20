using Hangfire;
using Hangfire.MemoryStorage;
using StackExchange.Redis;
using Volo.Abp.Auditing;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs.Hangfire;
using Volo.Abp.BackgroundWorkers;
using TTShang.Abp.Application;
using TTShang.Abp.SqlsugarCore;

namespace TTShang.Abp.Test
{
    [DependsOn(
        typeof(YiAbpSqlSugarCoreModule),
        typeof(YiAbpApplicationModule),
        
        typeof(AbpAutofacModule)
        )]
    public class YiAbpTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
