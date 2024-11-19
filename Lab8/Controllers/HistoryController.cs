using Lab8.Models;
using Lab8.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab8.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class HistoryController(IHistoryService historyService) : ControllerBase
{
    private readonly IHistoryService _historyService = historyService;


    [HttpGet]
    public Task<IEnumerable<History>> Get()
    {
        return _historyService.GetAllAsync();
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<History>> GetById(Guid id)
    {
        return await _historyService.GetByIdAsync(id) is { } data ? data : NotFound();
    }


    [HttpPost]
    public async Task<ActionResult<History>> Post(History history)
    {
        history = await _historyService.CreateAsync(history);
        return CreatedAtAction(nameof(GetById), new { id = history.Id }, history);
    }


    [HttpPut]
    public async Task<IActionResult> Update(History history)
    {
        return await _historyService.UpdateAsync(history) ? NoContent() : NotFound();
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return await _historyService.DeleteAsync(id) ? NoContent() : NotFound();
    }
}
