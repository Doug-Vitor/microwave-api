using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class WarmDTO
{
  const int DEFAULT_TIME = 30;
  const int DEFAULT_POWER = 10;

  [Range(1, 120, ErrorMessage = "Tempo deve ser entre 1 e 120")]
  public int? Time { get; set; } = DEFAULT_TIME;

  [Range(1, 10, ErrorMessage = "Potência deve ser entre 1 e 10")]
  public int? Power { get; set; } = DEFAULT_POWER;

  public WarmDTO() { }
}