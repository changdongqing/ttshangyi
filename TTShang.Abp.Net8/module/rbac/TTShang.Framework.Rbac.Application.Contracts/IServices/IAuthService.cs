using Volo.Abp.Application.Dtos;
using TTShang.Framework.Rbac.Application.Contracts.Dtos.Account;

namespace TTShang.Framework.Rbac.Application.Contracts.IServices;

public interface IAuthService
{
    Task<AuthOutputDto?> TryGetAuthInfoAsync(string? openId, string authType, Guid? userId = null);
    Task<AuthOutputDto> CreateAsync(AuthCreateOrUpdateInputDto input);
}