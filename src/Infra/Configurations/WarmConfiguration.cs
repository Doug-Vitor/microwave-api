using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class WarmConfiguration : IEntityTypeConfiguration<Warm>
{
  public void Configure(EntityTypeBuilder<Warm> builder)
  {
    builder.HasKey(prop => prop.Id);
  }
}