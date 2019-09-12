using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entitys;
using System;

namespace QuickBuy.Repository.Config
{
    public class OrderedItemConfiguration : IEntityTypeConfiguration<OrderedItem>
    {
        public void Configure(EntityTypeBuilder<OrderedItem> builder)
        {
            builder.HasKey(o => o.Id);

            builder
                .Property(o => o.ProductId)
                .IsRequired();

            builder
                .Property(o => o.Amount)
                .IsRequired();
      
        }
    }
}
