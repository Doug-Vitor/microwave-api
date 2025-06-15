using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("presets")]
public class PresetsController(
  IReadonlyRepository<Preset> _repository, IPresetServices _service
) : ControllerBase
{
  [HttpGet]
  public async Task<IActionResult> GetAll() => Ok(await _repository.GetAllAsync());

  [HttpPost]
  public async Task<IActionResult> Post([FromBody] PresetDTO preset)
  {
    if (ModelState.IsValid)
    {
      var dbPreset = await _service.InsertAsync(preset);
      return Ok(dbPreset);
    }

    return BadRequest(ModelState);
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int? id, [FromBody] PresetDTO preset)
  {
    if (ModelState.IsValid)
    {
      var dbPreset = await _service.UpdateAsync(id.Value, preset);
      return Ok(dbPreset);
    }

    return BadRequest(ModelState);
  }
}