using Factory.Application.Interfaces;
using Factory.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Factory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService) 
        { 
            _usuarioService = usuarioService;
        }

        [HttpPost("GuardarUsuario")]
        public async Task<IActionResult> GuardarUsuario([FromBody] Usuario usuario)
        { 
            var result = await _usuarioService.GuardarUsuario(usuario);

            return Ok(result);
        }

        [HttpPost("LoguearUsuario")]
        public async Task<IActionResult> LoguearUsuario([FromBody] Usuario usuario)
        {
            var result = await _usuarioService.LoguearUsuario(usuario);

            return Ok(result);
        }

        [HttpGet("ConsultarUsuarios")]
        public async Task<IActionResult> ConsultarUsuarios()
        { 
            var result = await _usuarioService.ConsultarUsuarios();

            return Ok(result);
        }
    }
}
