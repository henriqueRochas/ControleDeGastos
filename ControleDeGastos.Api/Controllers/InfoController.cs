using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InfoController : ControllerBase
{
    [HttpGet]
    public IActionResult TesteComArrays()
    {
        string[] categorias =
        {
            "Frutas",
            "Verduras",
            "Legumes"
        };

        return Ok(new
        {
            nome = "Gerenciador de gastos",
            categorias = categorias
        });
    }
}

