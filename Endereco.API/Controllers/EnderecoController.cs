using Endereco.API.Tools;
using Endereco.Application.UseCases.Commands;
using Endereco.Application.UseCases.Handlers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Endereco.API.Controllers
{
    [Route("v1/[controller]/")]
    public class EnderecoController : Controller
    {
        [HttpPost("GetCep/")]
        public async Task<ActionResult> GetCep([FromBody] ProcessarEnderecoCommand cepCommand, [FromServices] ProcessarEnderecoHandler handler)
        {
            return new ParseRequestResult().ParseToActionResult(await handler.HandleAsync(cepCommand));
        }
    }
}