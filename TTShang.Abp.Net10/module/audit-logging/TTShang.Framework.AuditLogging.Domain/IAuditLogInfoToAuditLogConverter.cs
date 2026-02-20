using System.Threading.Tasks;
using Volo.Abp.Auditing;
using TTShang.Framework.AuditLogging.Domain.Entities;

namespace TTShang.Framework.AuditLogging.Domain;

public interface IAuditLogInfoToAuditLogConverter
{
    Task<AuditLogAggregateRoot> ConvertAsync(AuditLogInfo auditLogInfo);
}
