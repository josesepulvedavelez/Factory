﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Domain.DTOs
{
    public class UsuarioDto
    {
        public int UsuarioId { get; set; }

        public string Nombre { get; set; }

        public string Identificacion { get; set; }

        public string Correo { get; set; }

        public string UserName { get; set; }
    }
}
