using TTShang.Framework.Rbac.Domain.Entities;
using TTShang.Framework.SqlSugarCore.Abstractions;

namespace TTShang.Framework.Rbac.Domain.Repositories
{
    public interface IDeptRepository : ISqlSugarRepository<DeptAggregateRoot, Guid>
    {
        Task<List<Guid>> GetChildListAsync(Guid deptId);
        Task<List<DeptAggregateRoot>> GetListRoleIdAsync(Guid roleId);
    }
}
