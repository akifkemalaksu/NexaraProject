using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.EntityConfigurations
{
    public class OrderConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne<Country>().WithMany().HasForeignKey(x => x.CountryId);
        }
    }
}