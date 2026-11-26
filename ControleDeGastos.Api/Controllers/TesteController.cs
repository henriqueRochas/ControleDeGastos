using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TesteController : ControllerBase // Herda ferramentas prontas de API (como o Ok)
{
    [HttpGet]
    public IActionResult VerificarStatus()
    {
        return Ok(new
        {
            mensagem = "API Controle de Gastos funcionando!",
            dataHora = DateTime.Now
        });
    }

    [HttpGet("versao")]
    public IActionResult RetornoDeVersao()
    {
        return Ok(new
        {
            nome = "Controle de Gastos",
            versao = "1.0"
        });
    }

    [HttpGet("ola/{nome}")]
    public IActionResult BemVindo(string nome)
    {
        return Ok(new
        {
            mensagem = $"{nome}! Bem vindo ao Controle de gastos"
        });
    }
}
