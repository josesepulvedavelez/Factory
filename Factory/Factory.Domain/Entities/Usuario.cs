using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Domain.Entities
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(15)]
        public string Identificacion { get; set; }

        [Required]
        [MaxLength(500)]
        public string Correo { get; set; }

        [Required]
        [MaxLength(10)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Pass { get; set; }

        public ICollection<ComicFavorito> ComicsFavoritos { get; set; } = new List<ComicFavorito>();
    }
}
