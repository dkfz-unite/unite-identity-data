using Unite.Identity.Data.Entities.Enums;

namespace Unite.Identity.Data.Entities;

public record WorkerTokenPermission
{
    public int Id { get; set; }
    public Permission PermissionId { get; set; }
    public string Restrictions { get; set; }
    public int TokenId { get; set; }
    public virtual WorkerToken WorkerToken { get; set; }
}
