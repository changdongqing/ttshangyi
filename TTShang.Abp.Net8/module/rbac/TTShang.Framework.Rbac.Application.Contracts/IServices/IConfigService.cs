using Volo.Abp.Application.Services;
using TTShang.Framework.Ddd.Application.Contracts;
using TTShang.Framework.Rbac.Application.Contracts.Dtos.Config;

namespace TTShang.Framework.Rbac.Application.Contracts.IServices
{
    /// <summary>
    /// Config服务抽象
    /// </summary>
    public interface IConfigService : IYiCrudAppService<ConfigGetOutputDto, ConfigGetListOutputDto, Guid, ConfigGetListInputVo, ConfigCreateInputVo, ConfigUpdateInputVo>
    {

    }
}
