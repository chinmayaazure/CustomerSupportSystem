using CustomerSupport.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerSupport.Infrastructure.Data.Configurations
{
    public sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.LastName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(20);

            builder.Property(x => x.PasswordHash)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(x => x.RoleId)
                .HasConversion<int>();

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.HasIndex(x => x.PhoneNumber)
                .IsUnique();

            builder.HasIndex(x => x.IsActive); //Non unique Non-clustered index

            //User has RoleId as foreign key
            //User is the dependent entity and Role is the principal entity in this relationship
            builder.HasOne(x => x.Role)          
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.RoleId)       //User has RoleId as foreign key
                .OnDelete(DeleteBehavior.Restrict);// Until any RoleId is in use by any User, it cannot be
                                                   // deleted from the master Role table.
                                                   // Restrict is the default behavior for required relationships.

            //To remember: You can add Delete Behaviour in dependent entity configuration which specifies if principal entity is deleted,
            //what should happen to the dependent entity.
        }
    }
}
