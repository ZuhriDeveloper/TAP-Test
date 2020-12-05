using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAP_TEST.Domain.Entities;

namespace TAP_TEST.Infrastructure.Persistence.Configurations
{
    public class CardPrefixConfiguration : IEntityTypeConfiguration<CardPrefix>
    {
        public void Configure(EntityTypeBuilder<CardPrefix> builder)
        {
            builder.Property(e => e.Prefix).HasColumnName("Prefix");
        }
    }
}
