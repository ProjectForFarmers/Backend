﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectForFarmers.Domain;

namespace ProjectForFarmers.Persistence.EntityTypeConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(order => order.Id);

            builder.Property(order => order.Number)
                .IsRequired()
                .HasMaxLength(7)
                .ValueGeneratedOnAdd()
                .UseSerialColumn();

            builder.Property(account => account.CreationDate).IsRequired();
            builder.Property(account => account.CustomerName).IsRequired();
            builder.Property(account => account.CustomerPhone).IsRequired();
            builder.Property(account => account.CustomerEmail).IsRequired();
            builder.Property(account => account.PaymentTotal).IsRequired();
            builder.Property(account => account.PaymentType).IsRequired();

            builder.HasOne(order => order.Customer)
                .WithMany()
                .HasForeignKey(order => order.CustomerId);
            
            builder.HasIndex(order => order.Id).IsUnique();
        }
    }

}