using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TTShang.Abp.Tool.Domain.Shared;
using TTShang.Abp.Tool.Domain.Shared.Options;

namespace TTShang.Abp.Tool.Domain
{
    [DependsOn(typeof(YiAbpToolDomainSharedModule))]
    public class YiAbpToolDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            Configure<ToolOptions>(configuration.GetSection("ToolOptions"));
            var toolOptions = new ToolOptions();
            configuration.GetSection("ToolOptions").Bind(toolOptions);
            if (!Directory.Exists(toolOptions.TempDirPath))
            {
                Directory.CreateDirectory(toolOptions.TempDirPath);
            }
            
        }
    }
}
