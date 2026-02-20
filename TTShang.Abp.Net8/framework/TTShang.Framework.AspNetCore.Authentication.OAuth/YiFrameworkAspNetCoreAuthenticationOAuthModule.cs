using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using TTShang.Framework.Core;


namespace TTShang.Framework.AspNetCore.Authentication.OAuth
{
    /// <summary>
    /// 本模块轮子来自 AspNet.Security.OAuth.QQ;
    /// </summary>
    [DependsOn(typeof(YiFrameworkAspNetCoreModule))]
    public class YiFrameworkAspNetCoreAuthenticationOAuthModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var service = context.Services;
            service.AddHttpClient();
        }
    }
}
