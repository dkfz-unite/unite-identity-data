using System;

namespace Unite.Identity.Entities
{
    public class UserSession
    {
        public int UserId { get; set; }
        public string Client { get; set; }
        public string Session { get; set; }

        public virtual User User { get; set; }
    }
}
