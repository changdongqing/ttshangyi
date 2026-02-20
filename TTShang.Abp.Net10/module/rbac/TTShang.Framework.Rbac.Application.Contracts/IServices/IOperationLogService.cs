using TTShang.Framework.Ddd.Application.Contracts;
using TTShang.Framework.Rbac.Application.Contracts.Dtos.OperLog;

namespace TTShang.Framework.Rbac.Application.Contracts.IServices
{
    /// <summary>
    /// OperationLog服务抽象
    /// </summary>
    public interface IOperationLogService : IYiCrudAppService<OperationLogGetListOutputDto, Guid, OperationLogGetListInputVo>
    {

    }
}
