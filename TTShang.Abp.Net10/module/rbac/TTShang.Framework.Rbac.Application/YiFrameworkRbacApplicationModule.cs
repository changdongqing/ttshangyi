using Lazy.Captcha.Core.Generator;
using Microsoft.Extensions.DependencyInjection;
using TTShang.Framework.Ddd.Application;
using TTShang.Framework.Rbac.Application.Contracts;
using TTShang.Framework.Rbac.Domain;

namespace TTShang.Framework.Rbac.Application
{
    [DependsOn(
        typeof(YiFrameworkRbacApplicationContractsModule),
        typeof(YiFrameworkRbacDomainModule),


        typeof(YiFrameworkDddApplicationModule)
        )]
    public class YiFrameworkRbacApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var service = context.Services;

            service.AddCaptcha(options =>
            {
                options.CaptchaType = CaptchaType.ARITHMETIC;
            });
        }

        public async override Task OnApplicationInitializationAsync(ApplicationInitializationContext context)
        {
        }
    }
}
