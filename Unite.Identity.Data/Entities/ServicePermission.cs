using Unite.Identity.Data.Entities.Enums;

namespace Unite.Identity.Data.Entities;

public record ServicePermission
{
    public int ServiceId { get; set; }
    public Permission PermissionId { get; set; }
    public string Restrictions { get; set; }

    public virtual Service Service { get; set; }
}
