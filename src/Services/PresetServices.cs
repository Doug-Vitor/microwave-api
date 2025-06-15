
public class PresetServices(AppDbContext dbContext) : WritableRepository<Preset>(dbContext), IPresetServices
{
  public override async Task<Preset> InsertAsync(Preset entity)
  {
    ThrowWhenDuplicatedSymbol(entity.WarmSymbol);
    return await base.InsertAsync(entity);
  }

  public override async Task<Preset> UpdateAsync(int id, Preset entity)
  {

    ThrowWhenDuplicatedSymbol(entity.WarmSymbol);
    return await base.UpdateAsync(id, entity);
  }

  private void ThrowWhenDuplicatedSymbol(string symbol)
  {
    var symbolExists = Collection.Any(
      preset => preset.WarmSymbol.Equals(symbol)
    );

    if (symbolExists) throw new Exception("");
  }
}