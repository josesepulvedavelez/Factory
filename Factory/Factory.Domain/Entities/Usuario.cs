using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Factory.Domain.Entities
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
                
        public string? Nombre { get; set; }
                
        public string? Identificacion { get; set; }

        public string? Correo { get; set; }
                
        public string? UserName { get; set; }
                
        public string? Pass { get; set; }
    }
}
