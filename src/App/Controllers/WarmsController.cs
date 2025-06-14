using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("warms")]
public class WarmsController(IWarmServices _service) : ControllerBase
{
  [HttpPost]
  public async Task<IActionResult> Post([FromBody] WarmDTO warm)
  {
    if (ModelState.IsValid)
    {
      var dbWarm = await _service.InsertAsync(warm);
      return Ok(dbWarm);
    }

    return BadRequest(ModelState);
  }

  [HttpPost("from-preset/{presetId}")]
  public async Task<IActionResult> CreateFromPreset(int presetId)
  {
    var warm = await _service.CreateFromPresetAsync(presetId);
    return Ok(warm);
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int? id, [FromBody] WarmDTO warm)
  {
    if (ModelState.IsValid)
    {
      var dbWarm = await _service.UpdateAsync(id.Value, warm);
      return Ok(dbWarm);
    }

    return BadRequest(ModelState);
  }
}