using Microsoft.AspNetCore.Mvc;

namespace FeedbackFlow.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    /// <summary>
    /// Ответ метода Get
    /// </summary>
    public const string HomeResponse = "hello";

    [HttpGet]
    public ActionResult<string> Get()
    {
        return HomeResponse;
    }
}
