using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class PresetDTO
{
  [Required(ErrorMessage = "Nome é obrigatório")]
  public string? Name { get; set; }

  [Required(ErrorMessage = "Comida é obrigatória")]
  public string? Food { get; set; }

  [Required(ErrorMessage = "Tempo é obrigatório")]
  public int? Time { get; set; }

  [Required(ErrorMessage = "Potência é obrigatória")]
  public int? Power { get; set; }

  [Required(ErrorMessage = "Símbolo de aquecimento é obrigatório")]
  public string? WarmSymbol { get; set; }

  public string? Instructions { get; set; }

  public PresetDTO() { }
}