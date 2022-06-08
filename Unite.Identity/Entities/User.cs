using System.Collections.Generic;

namespace Unite.Identity.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        public virtual ICollection<UserSession> UserSessions { get; set; }
    }
}
