using Factory.Domain.Entities;
using Factory.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Infrastructure.Data
{
    public class ComicFavoritoRepository : IComicFavoritoRepository
    {
        private readonly FactoryContext _factoryContext;

        public ComicFavoritoRepository(FactoryContext factoryContext) 
        { 
            _factoryContext = factoryContext;
        }

        public async Task<IEnumerable<ComicFavorito>> ConsultarComicsFavoritos(int usuarioId)
        {
            var result = await _factoryContext.ComicFavorito
                               .Where(x => x.UsuarioId == usuarioId)
                               .ToListAsync();

            return result.AsEnumerable();
        }

        public async Task<int> GuardarComicFavorito(ComicFavorito comicFavorito)
        {
            await _factoryContext.ComicFavorito.AddAsync(comicFavorito);
            var result = _factoryContext.SaveChanges();

            return result;
        }

    }
}
