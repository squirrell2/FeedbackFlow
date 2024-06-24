using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FeddbackFlow.Data.EfModels;

/// <summary>
/// Ef конфигурация <see cref="FeedBackApplication"/>
/// </summary>
public class FeedBackApplicationConfiguration : IEntityTypeConfiguration<FeedBackApplication>
{
    public void Configure(EntityTypeBuilder<FeedBackApplication> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(256);
    }
}
