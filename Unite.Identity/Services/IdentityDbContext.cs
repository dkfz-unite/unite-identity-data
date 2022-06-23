using Microsoft.EntityFrameworkCore;
using Unite.Identity.Entities;
using Unite.Identity.Services.Configuration.Options;

namespace Unite.Identity.Services;

public class IdentityDbContext : DbContext
{
    private const string _database = "unite_identity";
    private readonly string _connectionString;

    public DbSet<User> Users { get; set; }
    public DbSet<UserSession> UserSessions { get; set; }
    public DbSet<UserPermission> UserPermissions { get; set; }


    public IdentityDbContext(ISqlOptions options)
    {
        _connectionString = $"Host={options.Host};Port={options.Port};Database={_database};Username={options.User};Password={options.Password}";
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();

        optionsBuilder.UseNpgsql(_connectionString, b => b.MigrationsAssembly("Unite.Identity.Migrations"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new Mappers.Enums.PermissionMapper());
        modelBuilder.ApplyConfiguration(new Mappers.UserMapper());
        modelBuilder.ApplyConfiguration(new Mappers.UserSessionMapper());
        modelBuilder.ApplyConfiguration(new Mappers.UserPermissionMapper());
    }
}
