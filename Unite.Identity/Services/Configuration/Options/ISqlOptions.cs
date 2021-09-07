﻿namespace Unite.Identity.Services.Configuration.Options
{
    public interface ISqlOptions
    {
        string Host { get; }
        string Port { get; }
        string User { get; }
        string Password { get; }
    }
}
