﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Valuables;
using System;

namespace QuickBuy.Repository.Config
{
    public class FormPaymentConfiguration : IEntityTypeConfiguration<FormPayment>
    {
        public void Configure(EntityTypeBuilder<FormPayment> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(25);

            builder
                .Property(f => f.Description)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}
