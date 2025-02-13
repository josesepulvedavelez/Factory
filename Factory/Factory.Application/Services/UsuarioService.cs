using Factory.Application.Interfaces;
using Factory.Domain.DTOs;
using Factory.Domain.Entities;
using Factory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        { 
            _usuarioRepository = usuarioRepository;
        }

        public async Task<int> GuardarUsuario(Usuario usuario)
        {
            var result = await _usuarioRepository.GuardarUsuario(usuario);
            return result;
        }

        public async Task<UsuarioDto> LoguearUsuario(Usuario usuario)
        {
            var result = await _usuarioRepository.LoguearUsuario(usuario);
            return result;
        }

        public async Task<IEnumerable<Usuario>> ConsultarUsuarios()
        {
            var result = await _usuarioRepository.ConsultarUsuarios();

            return result;
        }

    }
}
