using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NexaraProject.Entities.Concretes;
using System;

namespace NexaraProject.DataAccess.EntityFramework.EntityConfigurations
{
    public class OrderDetailConfigurations : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasOne<ProductModel>().WithMany().HasForeignKey(x => x.ProductModelId);
            builder.HasOne<Color>().WithMany().HasForeignKey(x => x.ColorId);
            builder.HasOne<Order>().WithMany().HasForeignKey(x => x.OrderId);
            builder.HasOne<Pattern>().WithMany().HasForeignKey(x => x.PatternId);
            builder.HasOne<SizeSet>().WithMany().HasForeignKey(x => x.SizeSetId);
            builder.HasOne<Size>().WithMany().HasForeignKey(x => x.SizeId);
            builder.HasOne<Season>().WithMany().HasForeignKey(x => x.SeasonId);
        }
    }
}