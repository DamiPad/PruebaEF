using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEF.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        //[Key]
        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }


        public decimal Precio { get; set; }
        [Range(0, 99)]
        public int Existencia { get; set; }
        public bool Descontinuado { get; set; }

        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
