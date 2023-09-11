using Microsoft.AspNetCore.Mvc;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventoController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<EventoController> _logger;

    public EventoController(ILogger<EventoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        return "Exemplo de Get";
    }

	[HttpPost]
	public string Post()
	{
		return "Exemplo de Post";
	}

	[HttpPut("{id}")]
	public string Put(int id)
	{
		return "Exemplo de Put com id = " + id;
	}

	[HttpDelete("{id}")]
	public string Delete(int id)
	{
		return "Exemplo de Delete com id = " + id;
	}
}
