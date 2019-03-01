using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEF.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required]
        public string NombreCategoria { get; set; }

        public virtual ICollection<Producto> Productos{ get; set; }
    }
}
