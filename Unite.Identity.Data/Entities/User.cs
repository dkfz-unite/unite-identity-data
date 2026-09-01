namespace Unite.Identity.Data.Entities;

public record User
{
    public int Id { get; set; }
    public int ProviderId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PasswordToken { get; set; }
    public DateTime? PasswordTokenExpires { get; set; }
    public bool IsRoot { get; set; }
    public bool IsActive { get; set; }
    public DateTime LastActive { get; set; }

    public virtual Provider Provider { get; set; }

    public virtual ICollection<UserPermission> UserPermissions { get; set; }
    public virtual ICollection<UserSession> UserSessions { get; set; }
}
