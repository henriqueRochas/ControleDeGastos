using ControleDeGastos.Api.Controllers;
using ControleDeGastos.Api.Data;
using ControleDeGastos.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleDeGastos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DespesasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarDespesas()
        { 
            var despesas = await _context.Despesas.ToListAsync();

            return Ok(despesas);
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarDespesas(Despesa novaDespesa)
        {
             _context.Despesas.Add(novaDespesa);
            await _context.SaveChangesAsync();

            return Created(string.Empty, novaDespesa);
        }
    } 
}
