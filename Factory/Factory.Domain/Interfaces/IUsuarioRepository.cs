﻿using Factory.Domain.DTOs;
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
        Task<UsuarioDto> LoguearUsuario(Usuario usuario);
        Task<IEnumerable<Usuario>> ConsultarUsuarios();
    }
}
