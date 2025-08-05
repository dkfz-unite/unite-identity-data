namespace Unite.Identity.Data.Entities;

public record Token
{
    public int Id { get; set; }
    public string Key { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public bool Revoked { get; set; }
    
    public virtual ICollection<TokenPermission> TokenPermissions { get; set; }
}
