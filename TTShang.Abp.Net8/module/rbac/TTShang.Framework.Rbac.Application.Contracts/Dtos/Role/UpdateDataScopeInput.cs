using TTShang.Framework.Rbac.Domain.Shared.Enums;

namespace TTShang.Framework.Rbac.Application.Contracts.Dtos.Role
{
    public class UpdateDataScopeInput
    {
        public Guid RoleId { get; set; }

        public List<Guid>? DeptIds { get; set; }

        public DataScopeEnum DataScope { get; set; }
    }
}
