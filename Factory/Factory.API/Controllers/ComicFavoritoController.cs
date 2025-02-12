using Factory.Application.Interfaces;
using Factory.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Factory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicFavoritoController : ControllerBase
    {
        private readonly IComicFavoritoService _comicFavoritoService;

        public ComicFavoritoController(IComicFavoritoService comicFavoritoService)
        { 
            _comicFavoritoService = comicFavoritoService;
        }

        [HttpGet("ConsultarComicsFavoritos/{usuarioId}")]
        public async Task<IActionResult> ConsultarComicsFavoritos(int usuarioId)
        {
            var result = await _comicFavoritoService.ConsultarComicsFavoritos(usuarioId);

            return Ok(result);
        }

        [HttpPost("GuardarComicFavorito")]
        public async Task<IActionResult> GuardarComicFavorito(ComicFavorito comicFavorito)
        {
            var result = await _comicFavoritoService.GuardarComicFavorito(comicFavorito);

            return Ok(result);
        }

    }
}
