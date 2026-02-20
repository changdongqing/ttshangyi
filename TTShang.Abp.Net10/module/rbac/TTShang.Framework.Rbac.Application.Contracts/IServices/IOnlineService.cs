using Volo.Abp.Application.Dtos;
using TTShang.Framework.Rbac.Domain.Shared.Model;

namespace TTShang.Framework.Rbac.Application.Contracts.IServices
{
    public interface IOnlineService
    {
      Task< PagedResultDto<OnlineUserModel>> GetListAsync(OnlineUserModel online);
    }
}
