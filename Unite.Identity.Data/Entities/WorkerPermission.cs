using Unite.Identity.Data.Entities.Enums;

namespace Unite.Identity.Data.Entities;

public record WorkerPermission
{
    public int WorkerId { get; set; }
    public Permission PermissionId { get; set; }
    public string Restrictions { get; set; }

    public virtual Worker Worker { get; set; }
}
