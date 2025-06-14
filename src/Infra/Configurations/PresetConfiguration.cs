using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class PresetConfiguration : IEntityTypeConfiguration<Preset>
{
  public void Configure(EntityTypeBuilder<Preset> builder)
  {
    builder.HasKey(prop => prop.Id);
  }
}