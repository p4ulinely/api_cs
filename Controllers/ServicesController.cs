using api.Domain.Entities;
using api.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServicesController : ControllerBase
{
    private readonly ILogger<ServicesController> _logger;
    private readonly IMathService _mathService;
    private readonly ITextService _textService;

    public ServicesController
    (
        ILogger<ServicesController> logger,
        IMathService mathService,
        ITextService textService
    )
    {
        _logger = logger;
        _mathService = mathService;
        _textService = textService;
    }

    [HttpPost]
    [Route("CalculaSoma")]
    public IActionResult CalculaSoma()
    {
        _logger.LogInformation("POST CalculaSoma");
        return Ok(_mathService.CalculaSoma(1,2));
    }

    [HttpPost]
    [Route("ConcatText")]
    public IActionResult ConcatText([FromBody] Text text)
    {
        if (text.Invalid)
        {
            _logger.LogInformation(text.LastErrorMessage());
            return BadRequest(text.LastErrorMessage());
        }
        
        return Ok(_textService.ConcatText(text.Text1, text.Text2));
    }
}