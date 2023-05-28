using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingShop.DataAccess.EF.TableDefinations
{
    using Model;

    public class BrandTableDefination : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(e => e.Id);

            builder
                .Property(e => e.Id)
                .HasDefaultValueSql("uuid_generate_v4()");

            builder
                .Property(e => e.CreatedDate)
                .HasDefaultValueSql("now() at time zone 'utc'")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder
                .Property(e => e.UpdatedDate)
                .HasDefaultValueSql("now() at time zone 'utc'")
                .ValueGeneratedOnUpdate();

            builder
                .Property(e => e.RecordStatus)
                .HasDefaultValue(RecordStatus.Active)
                .ValueGeneratedOnAdd();

            builder
                .HasIndex(e => e.Name)
                .IsUnique();
        }
    }
}
