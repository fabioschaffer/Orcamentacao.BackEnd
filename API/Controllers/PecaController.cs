using Application.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("peca")]
public class PecaController(IPecaService pecaService) : ControllerBase {


    [HttpPost("criar")]
    public IActionResult Criar() {

        pecaService.CriarPeca();

        return Ok();
    }

}