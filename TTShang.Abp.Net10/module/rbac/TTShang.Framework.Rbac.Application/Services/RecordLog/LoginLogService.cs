using SqlSugar;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using TTShang.Framework.Ddd.Application;
using TTShang.Framework.Rbac.Application.Contracts.Dtos.LoginLog;
using TTShang.Framework.Rbac.Domain.Entities;
using TTShang.Framework.SqlSugarCore.Abstractions;

namespace TTShang.Framework.Rbac.Application.Services.RecordLog
{
    public class LoginLogService : YiCrudAppService<LoginLogAggregateRoot, LoginLogGetListOutputDto, Guid, LoginLogGetListInputVo>
    {
        private readonly ISqlSugarRepository<LoginLogAggregateRoot> _repository;
        public LoginLogService(ISqlSugarRepository<LoginLogAggregateRoot, Guid> repository) : base(repository)
        {
            _repository = repository;
        }

        public override async Task<PagedResultDto<LoginLogGetListOutputDto>> GetListAsync(LoginLogGetListInputVo input)
        {
            RefAsync<int> total = 0;
            //if (input.Sorting.IsNullOrWhiteSpace())
            //    input.Sorting = $"{nameof(LoginLogAggregateRoot.CreationTime)} Desc";
            var entities = await _repository._DbQueryable.WhereIF(!string.IsNullOrEmpty(input.LoginIp), x => x.LoginIp.Contains(input.LoginIp!))
                          .WhereIF(!string.IsNullOrEmpty(input.LoginUser), x => x.LoginUser!.Contains(input.LoginUser!))
                          .WhereIF(input.StartTime is not null && input.EndTime is not null, x => x.CreationTime >= input.StartTime && x.CreationTime <= input.EndTime)
                          .OrderByDescending(it => it.CreationTime) //降序
                          .ToPageListAsync(input.SkipCount, input.MaxResultCount, total);
            return new PagedResultDto<LoginLogGetListOutputDto>(total, await MapToGetListOutputDtosAsync(entities));
        }

        [RemoteService(false)]
        public override Task<LoginLogGetListOutputDto> UpdateAsync(Guid id, LoginLogGetListOutputDto input)
        {
            return base.UpdateAsync(id, input);
        }
    }
}
