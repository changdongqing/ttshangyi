using Volo.Abp.Application.Services;
using TTShang.Framework.Ddd.Application.Contracts;
using TTShang.Framework.Rbac.Application.Contracts.Dtos.Post;

namespace TTShang.Framework.Rbac.Application.Contracts.IServices
{
    /// <summary>
    /// Post服务抽象
    /// </summary>
    public interface IPostService : IYiCrudAppService<PostGetOutputDto, PostGetListOutputDto, Guid, PostGetListInputVo, PostCreateInputVo, PostUpdateInputVo>
    {

    }
}
