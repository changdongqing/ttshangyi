using TTShang.Framework.AuditLogging.Domain.Entities;

namespace TTShang.Framework.AuditLogging.Domain;

public class EntityChangeWithUsername
{
    public EntityChangeEntity EntityChange { get; set; }

    public string UserName { get; set; }
}
