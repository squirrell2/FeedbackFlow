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
}
