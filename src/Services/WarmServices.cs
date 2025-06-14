
public class WarmServices(AppDbContext dbContext, IReadonlyRepository<Preset> _presetRepository) : WritableRepository<Warm>(dbContext), IWarmServices
{
  public async Task<Warm> CreateFromPresetAsync(int presetId)
  {
    var preset = await _presetRepository.GetByIdAsync(presetId);
    return await InsertAsync(preset);
  }
}