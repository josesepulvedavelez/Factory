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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly FactoryContext _factoryContext;

        public UsuarioRepository(FactoryContext factoryContext)
        { 
            _factoryContext = factoryContext;
        }

        public async Task<int> GuardarUsuario(Usuario usuario)
        {
             await _factoryContext.Usuario.AddAsync(usuario);
            var result = _factoryContext.SaveChanges();

            return result;
        }

        public async Task<bool> LoguearUsuario(string userName, string pass)
        {
            var result = await _factoryContext.Usuario
                                .FirstOrDefaultAsync(u => u.UserName == userName && u.Pass == pass);

            return result != null;
        }

    }
}
