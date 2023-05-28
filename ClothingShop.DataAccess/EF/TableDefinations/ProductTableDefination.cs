using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingShop.DataAccess.EF.TableDefinations
{
    using ClothingShop.Model;

    public class ProductTableDefination : IEntityTypeConfiguration<Model.Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
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
        }
    }
}
