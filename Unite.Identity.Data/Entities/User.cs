namespace Unite.Identity.Data.Entities;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsRoot { get; set; }
    public bool IsRegistered { get; set; }

    public virtual ICollection<UserPermission> UserPermissions { get; set; }
    public virtual ICollection<UserSession> UserSessions { get; set; }
}
