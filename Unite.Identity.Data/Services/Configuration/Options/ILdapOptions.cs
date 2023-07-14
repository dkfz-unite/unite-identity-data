namespace Unite.Identity.Data.Services.Configuration.Options;

public interface ILdapOptions
{
    string Server { get; }
    int? Port { get; }
    string UserTargetOU { get; }
    string ServiceUserRNA { get; }
    string ServiceUserPassword { get; }
}
