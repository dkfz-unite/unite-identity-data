using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Entities.Enums;
using Unite.Identity.Services.Models;
using Unite.Identity.Services.Models.Extensions;

namespace Unite.Identity.Services.Mappers.Enums
{
    internal class PermissionMapper : IEntityTypeConfiguration<EnumValue<Permission>>
    {
        public void Configure(EntityTypeBuilder<EnumValue<Permission>> entity)
        {
            var data = new EnumValue<Permission>[]
            {
                Permission.DataRead.ToEnumValue(),
                Permission.DataWrite.ToEnumValue(),
                Permission.DataEdit.ToEnumValue(),
                Permission.DataDelete.ToEnumValue(),

                Permission.UsersRead.ToEnumValue(),
                Permission.UsersWrite.ToEnumValue(),
                Permission.UsersEdit.ToEnumValue(),
                Permission.UsersDelete.ToEnumValue()
            };

            entity.BuildEnumEntity("Permissions", data);
        }
    }
}
