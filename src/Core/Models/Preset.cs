public class Preset : BaseEntity
{
  public string Name { get; set; }
  public string Food { get; set; }
  public int Time { get; set; }
  public int Power { get; set; }
  public string Instructions { get; set; }
  public string WarmSymbol { get; set; }
  public bool Custom { get; set; }

  public static implicit operator Preset(PresetDTO dto) => new()
  {
    Food = dto.Food!,
    Instructions = dto.Instructions!,
    Name = dto.Name!,
    Power = dto.Power.Value,
    Time = dto.Time.Value,
    WarmSymbol = dto.WarmSymbol!,
    Custom = true
  };
}