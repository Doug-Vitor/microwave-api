using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class PresetConfiguration : IEntityTypeConfiguration<Preset>
{
  public void Configure(EntityTypeBuilder<Preset> builder)
  {
    builder.HasKey(p => p.Id);
    builder.Property(p => p.Instructions).IsRequired(false);
  }
}