using TTShang.Framework.Ddd.Application.Contracts;
using TTShang.Framework.Rbac.Domain.Shared.OperLog;

namespace TTShang.Framework.Rbac.Application.Contracts.Dtos.OperLog
{
    public class OperationLogGetListInputVo : PagedAllResultRequestDto
    {
        public OperEnum? OperType { get; set; }
        public string? OperUser { get; set; }
        public string? Title { get; set; }
    }
}
