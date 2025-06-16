using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class PresetDTO
{
  [Required(ErrorMessage = "Nome é obrigatório")]
  public string? Name { get; set; }

  [Required(ErrorMessage = "Comida é obrigatória")]
  public string? Food { get; set; }

  [Required(ErrorMessage = "Tempo é obrigatório")]

  [Range(1, int.MaxValue, ErrorMessage = "Tempo deve ser no mínimo 1.")]
  public int? Time { get; set; }

  [Required(ErrorMessage = "Potência é obrigatória")]
  [Range(1, int.MaxValue, ErrorMessage = "Potência deve ser no mínimo 1.")]
  public int? Power { get; set; }

  [Required(ErrorMessage = "Símbolo de aquecimento é obrigatório")]
  public string? WarmSymbol { get; set; }

  public string? Instructions { get; set; }

  public PresetDTO() { }
}