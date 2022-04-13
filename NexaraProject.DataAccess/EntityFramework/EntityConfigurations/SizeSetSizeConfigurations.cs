using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.DataAccess.EntityFramework.EntityConfigurations
{
    public class SizeSetSizeConfigurations : IEntityTypeConfiguration<SizeSetSize>
    {
        public void Configure(EntityTypeBuilder<SizeSetSize> builder)
        {
            builder.HasOne<SizeSet>().WithMany().HasForeignKey(x => x.SizeSetId);
            builder.HasOne<Size>().WithMany().HasForeignKey(x => x.SizeId);
        }
    }
}