using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("warms")]
public class WarmsController : ControllerBase
{
  private readonly IWritableRepository<Warm> _repository;

  public WarmsController(IWritableRepository<Warm> repository) => _repository = repository;

  [HttpPost]
  public async Task<IActionResult> Post([FromBody] WarmDTO warm)
  {
    var dbWarm = await _repository.InsertAsync(warm);
    return Ok(dbWarm);
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int? id, [FromBody] WarmDTO warm)
  {
    var dbWarm = await _repository.UpdateAsync(id.Value, warm);
    return Ok(dbWarm);
  }
}