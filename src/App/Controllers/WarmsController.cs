using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("warms")]
public class WarmsController(IWritableRepository<Warm> _repository) : ControllerBase
{
  [HttpPost]
  public async Task<IActionResult> Post([FromBody] WarmDTO warm)
  {
    if (ModelState.IsValid)
    {
      var dbWarm = await _repository.InsertAsync(warm);
      return Ok(dbWarm);
    }

    return BadRequest(ModelState);
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int? id, [FromBody] WarmDTO warm)
  {
    if (ModelState.IsValid)
    {
      var dbWarm = await _repository.UpdateAsync(id.Value, warm);
      return Ok(dbWarm);
    }

    return BadRequest(ModelState);
  }
}