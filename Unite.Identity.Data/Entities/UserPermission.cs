using Unite.Identity.Data.Entities.Enums;

namespace Unite.Identity.Data.Entities;

public class UserPermission
{
    public int UserId { get; set; }
    public Permission PermissionId { get; set; }
    public string Restrictions { get; set; }

    public virtual User User { get; set; }
}
