using System.Runtime.Serialization;
using Unite.Identity.Data.Entities.Constants;

namespace Unite.Identity.Data.Entities.Enums;

public enum Permission
{
    // Data
    [EnumMember(Value = Permissions.Data.Read)]
    DataRead = 1,

    [EnumMember(Value = Permissions.Data.Write)]
    DataWrite = 2,

    [EnumMember(Value = Permissions.Data.Edit)]
    DataEdit = 3,

    [EnumMember(Value = Permissions.Data.Delete)]
    DataDelete = 4,


    // User
    [EnumMember(Value = Permissions.Users.Read)]
    UsersRead = 5,

    [EnumMember(Value = Permissions.Users.Write)]
    UsersWrite = 6,

    [EnumMember(Value = Permissions.Users.Edit)]
    UsersEdit = 7,

    [EnumMember(Value = Permissions.Users.Delete)]
    UsersDelete = 8,
}
