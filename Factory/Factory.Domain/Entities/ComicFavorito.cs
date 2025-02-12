using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Domain.Entities
{
    public class ComicFavorito
    {
        [Key]
        public int ComicFavoritoId { get; set; }

        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        [MaxLength(10)]
        public string Extension { get; set; }

        public int UsuarioId { get; set; }


        public Usuario? Usuario { get; set; }
    }
}
