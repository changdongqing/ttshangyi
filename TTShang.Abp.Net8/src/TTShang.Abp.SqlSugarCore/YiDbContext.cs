using Microsoft.Extensions.Logging;
using SqlSugar;
using Volo.Abp.DependencyInjection;
using TTShang.Framework.Rbac.SqlSugarCore;
using TTShang.Framework.SqlSugarCore;

namespace TTShang.Abp.SqlSugarCore
{
    public class YiDbContext : SqlSugarDbContext
    {
        public YiDbContext(IAbpLazyServiceProvider lazyServiceProvider) : base(lazyServiceProvider)
        {
        }
    }
}
