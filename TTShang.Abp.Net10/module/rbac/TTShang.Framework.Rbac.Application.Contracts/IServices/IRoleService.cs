using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Services;
using TTShang.Framework.Ddd.Application.Contracts;
using TTShang.Framework.Rbac.Application.Contracts.Dtos.Role;
using TTShang.Framework.Rbac.Domain.Shared.Enums;

namespace TTShang.Framework.Rbac.Application.Contracts.IServices
{
    /// <summary>
    /// Role服务抽象
    /// </summary>
    public interface IRoleService : IYiCrudAppService<RoleGetOutputDto, RoleGetListOutputDto, Guid, RoleGetListInputVo, RoleCreateInputVo, RoleUpdateInputVo>
    {
        /// <summary>
        /// 获取角色菜单树
        /// </summary>
        /// <param name="roleId">角色ID</param>
        /// <returns>角色菜单树数据，包含已选中的菜单ID和菜单树结构</returns>
        Task<ActionResult> GetMenuTreeAsync(Guid roleId,MenuSourceEnum menuSource);

        /// <summary>
        /// 获取角色部门树
        /// </summary>
        /// <param name="roleId">角色ID</param>
        /// <returns>角色部门树数据，包含已选中的部门ID和部门树结构</returns>
        Task<ActionResult> GetDeptTreeAsync(Guid roleId);
    }
}
