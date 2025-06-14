public interface IWarmServices : IWritableRepository<Warm>
{
  Task<Warm> CreateFromPresetAsync(int presetId);
}