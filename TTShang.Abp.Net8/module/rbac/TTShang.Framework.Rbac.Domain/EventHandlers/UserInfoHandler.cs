using Mapster;
using Microsoft.AspNetCore.Identity;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;
using TTShang.Framework.Rbac.Domain.Managers;
using TTShang.Framework.Rbac.Domain.Repositories;
using TTShang.Framework.Rbac.Domain.Shared.Caches;
using TTShang.Framework.Rbac.Domain.Shared.Dtos;
using TTShang.Framework.Rbac.Domain.Shared.Etos;

namespace TTShang.Framework.Rbac.Domain.EventHandlers
{
    public class UserInfoHandler : ILocalEventHandler<UserRoleMenuQueryEventArgs>, ITransientDependency
    {
        private UserManager _userManager;
        public UserInfoHandler(UserManager userManager)
        {
            _userManager = userManager;
        }
        public async Task HandleEventAsync(UserRoleMenuQueryEventArgs eventData)
        {
            //数据库查询方式
            var result = await _userManager.GetInfoListAsync(eventData.UserIds);
            eventData.Result = result;
        }
    }
}
