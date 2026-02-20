using TTShang.Framework.Ddd;
using TTShang.Framework.Ddd.Application.Contracts;

namespace TTShang.Framework.Rbac.Application.Contracts.Dtos.LoginLog
{
    public class LoginLogGetListInputVo : PagedAllResultRequestDto
    {
        public string? LoginUser { get; set; }

        public string? LoginIp { get; set; }
    }
}
