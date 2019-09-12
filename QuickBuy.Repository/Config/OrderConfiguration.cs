using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entitys;
using System;

namespace QuickBuy.Repository.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);

            builder
                .Property(o => o.DateOrder)
                .IsRequired();

            builder
                .Property(o => o.UserId)
                .IsRequired();

            builder
                .Property(o => o.DateDelivery)
                .IsRequired();

            builder
                .Property(o => o.CEP)
                .IsRequired()
                .HasMaxLength(12);

            builder
                .Property(o => o.State)
                .IsRequired()
                .HasMaxLength(22);

            builder
                .Property(o => o.Adress)
                .IsRequired()
                .HasMaxLength(40);

            builder
                .Property(o => o.NumberAdress)
                .IsRequired()
                .HasMaxLength(12);

            builder
                .Property(o => o.FormPayment)
                .IsRequired()
                .HasMaxLength(1);

            builder
                .Property(o => o.OrderedItems)
                .IsRequired();
        }
    }
}
