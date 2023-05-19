using Microsoft.AspNetCore.Mvc;
using RunApi.Models;

namespace RunApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RunController : ControllerBase
{

    private readonly ILogger<RunController> _logger;
    private readonly RunContext _context;

    public RunController(ILogger<RunController> logger, RunContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetRuns")]
    public ActionResult<IEnumerable<Run>> Get()
    {
        if (_context.Runs == null)
        {
            return NotFound();
        }

        return _context.Runs.ToList();
    }

    [HttpPost(Name = "CreateRun")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult Post(Run run)
    {
        if (_context.Runs == null)
        {
            return Problem("Entity set 'Runs' is null.");
        }
        _context.Runs.Add(run);

        return StatusCode(201);
    }
}
