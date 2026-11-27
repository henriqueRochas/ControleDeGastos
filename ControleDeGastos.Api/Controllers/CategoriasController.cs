using ControleDeGastos.Api.Controllers;
using ControleDeGastos.Api.Data;
using ControleDeGastos.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleDeGastos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var categorias = await _context.Categorias.ToListAsync();
            return Ok(categorias);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorId(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);

            if(categoria == null)
            {
                return NotFound();
            }

            return Ok(categoria);
        }

        [HttpPost]
        public async Task<IActionResult> Criar(Categoria novaCategoria)
        {
            _context.Categorias.Add(novaCategoria);
            await _context.SaveChangesAsync();

            return Created(string.Empty, novaCategoria);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
