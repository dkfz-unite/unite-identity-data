using Unite.Identity.Entities.Enums;

namespace Unite.Identity.Entities;

public class UserPermission
{
    public int UserId { get; set; }
    public Permission PermissionId { get; set; }
    public string Restrictions { get; set; }

    public virtual User User { get; set; }
}
