using Factory.Domain.DTOs;
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

        public async Task<IEnumerable<Usuario>> ConsultarUsuarios()
        {
            var result = await _factoryContext.Usuario.ToListAsync();

            return result;
        }

        public async Task<int> GuardarUsuario(Usuario usuario)
        {
             await _factoryContext.Usuario.AddAsync(usuario);
            var result = _factoryContext.SaveChanges();

            return result;
        }

        public async Task<UsuarioDto> LoguearUsuario(Usuario usuario)
        {
            var result = await _factoryContext.Usuario
                                .FirstOrDefaultAsync(u => u.UserName == usuario.UserName && u.Pass == usuario.Pass);

            if (result != null)
            {
                UsuarioDto usuarioDto = new UsuarioDto
                { 
                    UsuarioId = result.UsuarioId,
                    Nombre = result.Nombre,
                    Correo = result.Correo,
                    Identificacion = result.Identificacion,
                    UserName = result.UserName
                };

                return usuarioDto;
            }
            else
            {
                return null;
            }
        }

    }
}
