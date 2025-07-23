namespace Unite.Identity.Data.Entities;

public record WorkerToken
{
    public int Id { get; set; }
    public string Value { get; set; }
    public DateTime? TokenExpiryDate { get; set; }
    public int WorkerId { get; set; }
    public virtual Worker Worker { get; set; }
    public virtual ICollection<WorkerTokenPermission> WorkerTokenPermission { get; set; }
}
