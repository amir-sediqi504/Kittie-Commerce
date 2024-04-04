using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
[Route("api/[controller]")]
public class KittensController : ControllerBase
{
    private readonly KittieContext _context;
    
    public KittensController(KittieContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Kitten>>> GetKittens()
    {
        return await _context.Kittens.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Kitten>> GetKitten(int id)
    {
        var kitten = await _context.Kittens.FindAsync(id);
        if (kitten == null)
        {
            return NotFound();
        }
        return kitten;
    }
}

}