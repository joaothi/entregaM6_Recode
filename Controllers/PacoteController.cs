using JTViagens.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JTViagens.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PacoteController : ControllerBase
	{

		private readonly PacoteDBContext _context;

		public PacoteController(PacoteDBContext context)
		{
			_context = context;
		}

		//
		[HttpGet]
		public IEnumerable<Pacote> GetPacote()
		{
			return _context.Pacote;
		}

		//
		[HttpGet("{id}")]
		public IActionResult GetPacotePorId(int id)
		{
			Pacote pacote = _context.Pacote.SingleOrDefault(modelo => modelo.PacoteId == id);
			if (pacote == null)
			{
				return NotFound();
			}
			return new ObjectResult(pacote);
		}

		//
		[HttpPost]
		public IActionResult CriarPacote(Pacote item)
		{
			if (item == null)
			{
				return BadRequest();
			}

			_context.Pacote.Add(item);
			_context.SaveChanges();
			return new ObjectResult(item);

		}

		//
		[HttpPut("{id}")]
		public IActionResult Pacote(int id, Pacote item)
		{
			if (id != item.PacoteId)
			{
				return BadRequest();
			}
			_context.Entry(item).State = EntityState.Modified;
			_context.SaveChanges();

			return new NoContentResult();
		}

		//
		[HttpDelete("{id}")]
		public IActionResult DeletaPacote(int id)
		{
			var pacote = _context.Pacote.SingleOrDefault(m => m.PacoteId == id);

			if (pacote == null)
			{
				return BadRequest();
			}

			_context.Pacote.Remove(pacote);
			_context.SaveChanges();
			return Ok(pacote);
		}
	}
}
