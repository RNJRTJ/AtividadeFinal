using Games.Data;
using Games.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Games.Controllers
{
[Route("api/[controller]")]
[ApiController]
public class ContatoController : ControllerBase
{
    private readonly AppDbContext _context;

    public ContatoController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Contato
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Contato>>> GetContato()
    {
        return await _context.Contato.ToListAsync();
    }

    // GET: api/Contato/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Contato>> GetContato(int id)
    {
        var contato = await _context.Contato.FindAsync(id);

        if (contato == null)
        {
            return NotFound();
        }

        return contato;
    }

    
}

}