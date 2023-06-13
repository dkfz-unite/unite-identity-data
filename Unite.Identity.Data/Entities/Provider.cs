namespace Unite.Identity.Data.Entities;

public class Provider
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Label { get; set; }
    public bool IsActive { get; set; }
    public int? Priority { get; set; }

    public virtual ICollection<User> Users { get; set; }
}
