using Microsoft.EntityFrameworkCore;
using Unite.Identity.Data.Entities;
using Unite.Identity.Data.Services.Configuration.Options;

namespace Unite.Identity.Data.Services;

public class IdentityDbContext : DbContext
{
    private const string _database = "unite_identity";
    private readonly string _connectionString;

    public DbSet<Provider> Providers { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserSession> UserSessions { get; set; }
    public DbSet<UserPermission> UserPermissions { get; set; }
    public DbSet<Worker> Workers { get; set; }
    public DbSet<WorkerPermission> WorkerPermissions { get; set; }
    public DbSet<WorkerToken> WorkerToken { get; set; }
    public DbSet<WorkerTokenPermission> WorkerTokenPermission { get; set; }


    public IdentityDbContext(ISqlOptions options)
    {
        _connectionString = $"Host={options.Host};Port={options.Port};Database={_database};Username={options.User};Password={options.Password}";
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();

        optionsBuilder.UseNpgsql(_connectionString, b => b.MigrationsAssembly("Unite.Identity.Data.Migrations"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new Mappers.ProviderMapper());
        modelBuilder.ApplyConfiguration(new Mappers.Enums.PermissionMapper());
        modelBuilder.ApplyConfiguration(new Mappers.UserMapper());
        modelBuilder.ApplyConfiguration(new Mappers.UserSessionMapper());
        modelBuilder.ApplyConfiguration(new Mappers.UserPermissionMapper());
        modelBuilder.ApplyConfiguration(new Mappers.WorkerMapper());
        modelBuilder.ApplyConfiguration(new Mappers.WorkerPermissionMapper());
        modelBuilder.ApplyConfiguration(new Mappers.WorkerTokenMapper());
        modelBuilder.ApplyConfiguration(new Mappers.WorkerTokenPermissionMapper());
    }
}
