﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entitys;
using System;

namespace QuickBuy.Repository.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(1000);

            builder
                .HasMany(u => u.Orders)
                .WithOne(p => p.User);
        }
    }
}
