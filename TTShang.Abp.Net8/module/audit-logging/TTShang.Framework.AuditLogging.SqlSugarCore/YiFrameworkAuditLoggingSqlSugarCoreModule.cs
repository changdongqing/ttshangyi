using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using TTShang.Framework.AuditLogging.Domain;
using TTShang.Framework.AuditLogging.Domain.Repositories;
using TTShang.Framework.AuditLogging.SqlSugarCore.Repositories;
using TTShang.Framework.SqlSugarCore;

namespace TTShang.Framework.AuditLogging.SqlSugarCore
{
    [DependsOn(
        typeof(YiFrameworkAuditLoggingDomainModule),

        typeof(YiFrameworkSqlSugarCoreModule))]
    public class YiFrameworkAuditLoggingSqlSugarCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<IAuditLogRepository, SqlSugarCoreAuditLogRepository>();

        }
    }
}
