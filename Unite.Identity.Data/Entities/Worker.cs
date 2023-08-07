namespace Unite.Identity.Data.Entities;

public record Worker
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Token { get; set; }
    public DateTime? TokenExpiryDate { get; set; }

    public virtual ICollection<WorkerPermission> WorkerPermissions { get; set; }
}
