using Unite.Identity.Data.Entities.Enums;

namespace Unite.Identity.Data.Entities;

public record TokenPermission
{
    public int TokenId { get; set; }
    public Permission PermissionId { get; set; }
    public string Restrictions { get; set; }

    public virtual Token Token { get; set; }
}
