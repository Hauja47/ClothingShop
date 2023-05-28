using Microsoft.EntityFrameworkCore;

namespace ClothingShop.DataAccess.EF.TableDefinations
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Model;

    public class AttributeValueTableDefination : IEntityTypeConfiguration<AttributeValue>
    {
        public void Configure(EntityTypeBuilder<AttributeValue> builder)
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
