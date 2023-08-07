namespace Unite.Identity.Data.Entities;

public record Service
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Token { get; set; }
    public DateTime? TokenExpiryDate { get; set; }

    public virtual ICollection<ServicePermission> ServicePermissions { get; set; }
}
