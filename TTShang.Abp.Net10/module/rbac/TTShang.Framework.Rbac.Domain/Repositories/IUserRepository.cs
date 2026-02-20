using Volo.Abp.Domain.Repositories;
using TTShang.Framework.Rbac.Domain.Entities;
using TTShang.Framework.Rbac.Domain.Shared.Dtos;
using TTShang.Framework.SqlSugarCore.Abstractions;

namespace TTShang.Framework.Rbac.Domain.Repositories
{
    public interface IUserRepository : ISqlSugarRepository<UserAggregateRoot>
    {
        /// <summary>
        /// 获取用户的所有信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<UserAggregateRoot> GetUserAllInfoAsync(Guid userId);
        /// <summary>
        /// 批量获取用户的所有信息
        /// </summary>
        /// <param name="userIds"></param>
        /// <returns></returns>
        Task<List<UserAggregateRoot>> GetListUserAllInfoAsync(List<Guid> userIds);

    }
}
