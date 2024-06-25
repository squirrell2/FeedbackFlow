using FeedbackFlow.Api.Logic;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackFlow.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FeedBackApplicationController : ControllerBase
{
    /// <inheritdoc cref="IFeedbackApplicationHandler"/>
    private readonly IFeedbackApplicationHandler _handler;

    public FeedBackApplicationController(IFeedbackApplicationHandler handler)
    {
        _handler = handler;
    }


    [HttpGet(nameof(GetById))]
    public async Task<FeedbackApplicationResponseItem> GetById(Guid id, CancellationToken token)
    {
        var result = await _handler.GetById(id, token);
        return result;
    }

    [HttpGet(nameof(GetAll))]
    public async Task<IEnumerable<FeedbackApplicationResponseItem>> GetAll(CancellationToken token)
    {
        var result = await _handler.GetAll(token);
        return result;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] FeedbackApplicationCreateItem createItem, CancellationToken token)
    {
        if (createItem == null)
        {
            return BadRequest("Invalid input");
        }

        var result = await _handler.Create(createItem, token);
        return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
    }

    [HttpPut]
    public async Task<IActionResult> Edit(Guid id, [FromBody] FeedbackApplicationEditItem editItem, CancellationToken token)
    {
        if (editItem == null)
        {
            return BadRequest("Invalid input");
        }

        try
        {
            var result = await _handler.Edit(id, editItem, token);
            return Ok(result);
        }
        catch (ArgumentException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id, CancellationToken token)
    {
        try
        {
            await _handler.Delete(id, token);
            return NoContent();
        }
        catch (ArgumentException ex)
        {
            return NotFound(ex.Message);
        }
    }

    
}
