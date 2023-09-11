using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
	public IEnumerable<Evento> _evento = new Evento[]
	{
		new Evento()
		{
				EventoId = 1,
				Tema = "Curso Angular e .NET 5",
				Lote = "1� Lote",
				QtdPessoas = 15,
				Local = "Florian�polis",
				DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
				ImagemURL = "imagem.jpg"
		},
		new Evento()
		{
				EventoId = 2,
				Tema = "Curso Angular e .NET 5",
				Lote = "2� Lote",
				Local = "Rio de Janeiro",
				QtdPessoas = 15,
				DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
				ImagemURL = "imagem.jpg"
		}
	};

	[HttpGet]
	public IEnumerable<Evento> Get()
	{
		return _evento;
	}

	[HttpGet("{id}")]
	public IEnumerable<Evento> GetById(int id)
	{
		return _evento.Where(evento => evento.EventoId == id);
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
