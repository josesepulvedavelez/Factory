using Factory.Application.Interfaces;
using Factory.Domain.Entities;
using Factory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Application.Services
{
    public class ComicfavoritoService : IComicFavoritoService
    {
        private readonly IComicFavoritoRepository _comicFavoritoRepository;

        public ComicfavoritoService(IComicFavoritoRepository comicFavoritoRepository) 
        { 
            _comicFavoritoRepository = comicFavoritoRepository;
        }

        public async Task<IEnumerable<ComicFavorito>> ConsultarComicsFavoritos(int usuarioId)
        {
            var result = await _comicFavoritoRepository.ConsultarComicsFavoritos(usuarioId);
            
            return result;
        }

        public async Task<int> GuardarComicFavorito(ComicFavorito comicFavorito)
        {
            var result = await _comicFavoritoRepository.GuardarComicFavorito(comicFavorito);

            return result;
        }

    }
}
