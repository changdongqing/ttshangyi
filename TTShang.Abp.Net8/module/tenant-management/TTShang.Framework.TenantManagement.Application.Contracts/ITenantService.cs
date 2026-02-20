using TTShang.Framework.Ddd.Application.Contracts;
using TTShang.Framework.TenantManagement.Application.Contracts.Dtos;

namespace TTShang.Framework.TenantManagement.Application.Contracts
{
    public interface ITenantService:IYiCrudAppService< TenantGetOutputDto, TenantGetListOutputDto, Guid, TenantGetListInput, TenantCreateInput, TenantUpdateInput>
    {
    }
}
