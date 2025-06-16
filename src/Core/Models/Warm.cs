public class Warm : BaseEntity
{
  public int Time { get; set; }
  public int Power { get; set; }
  public string? WarmSymbol { get; set; }

  public Warm(int time, int power) => (Time, Power) = (time, power);

  public static implicit operator Warm(WarmDTO dto) => new(
    dto.Time!.Value, dto.Power!.Value
  );

  public static implicit operator Warm(Preset preset) => new(preset.Time, preset.Power)
  {
    WarmSymbol = preset.WarmSymbol
  };
}