using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingShop.DataAccess.EF.TableDefinations
{
    using Model;

    public class OrderTableDefination : IEntityTypeConfiguration<Model.Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
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
                .Property(e => e.OrderStatus)
                .HasDefaultValue(OrderStatus.WaitForConfirm)
                .ValueGeneratedOnAdd();
        }
    }
}
