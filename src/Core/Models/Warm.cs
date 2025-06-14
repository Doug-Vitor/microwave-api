public class Warm : BaseEntity
{
  public int Time { get; set; }
  public int Power { get; set; }

  public static implicit operator Warm(WarmDTO dto) => new()
  {
    Power = dto.Power!.Value,
    Time = dto.Time!.Value,
  };
}