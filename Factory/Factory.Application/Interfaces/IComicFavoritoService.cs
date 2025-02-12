using Factory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Application.Interfaces
{
    public interface IComicFavoritoService
    {
        Task<int> GuardarComicFavorito(ComicFavorito comicFavorito);
        Task<IEnumerable<ComicFavorito>> ConsultarComicsFavoritos(int usuarioId);
    }
}
