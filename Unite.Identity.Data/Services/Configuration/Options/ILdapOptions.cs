namespace Unite.Identity.Data.Services.Configuration.Options;

public interface ILdapOptions
{
    string Server { get; }
    string Port { get; }
    string UserTargetOU { get; }
    string ServiceUserRNA { get; }
    string ServiceUserPassword { get; }
}
