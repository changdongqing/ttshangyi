using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
using TTShang.Framework.Rbac.Domain.Entities;
using TTShang.Framework.Rbac.Domain.Shared.Dtos;

namespace TTShang.Framework.Rbac.Domain.Managers
{
    public interface IAccountManager : IDomainService
    {
        string CreateRefreshToken(Guid userId);
        Task<string> GetTokenByUserIdAsync(Guid userId,Action<UserRoleMenuDto>? getUserInfo=null);
        Task LoginValidationAsync(string userName, string password, Action<UserAggregateRoot>? userAction = null);
        Task RegisterAsync(string userName, string password, long? phone,string? nick);
        Task<bool> RestPasswordAsync(Guid userId, string password);
        Task UpdatePasswordAsync(Guid userId, string newPassword, string oldPassword);
    }
}
