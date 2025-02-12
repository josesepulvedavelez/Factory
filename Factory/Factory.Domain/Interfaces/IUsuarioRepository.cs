using Factory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<int> GuardarUsuario(Usuario usuario);
        Task<bool> LoguearUsuario(string userName, string pass);
    }
}
