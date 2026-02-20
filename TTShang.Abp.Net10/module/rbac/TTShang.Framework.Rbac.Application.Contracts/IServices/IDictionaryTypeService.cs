using TTShang.Framework.Ddd.Application.Contracts;
using TTShang.Framework.Rbac.Application.Contracts.Dtos.DictionaryType;

namespace TTShang.Framework.Rbac.Application.Contracts.IServices
{
    /// <summary>
    /// DictionaryType服务抽象
    /// </summary>
    public interface IDictionaryTypeService : IYiCrudAppService<DictionaryTypeGetOutputDto, DictionaryTypeGetListOutputDto, Guid, DictionaryTypeGetListInputVo, DictionaryTypeCreateInputVo, DictionaryTypeUpdateInputVo>
    {

    }
}
