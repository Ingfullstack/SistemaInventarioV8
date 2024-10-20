using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelo.Models
{
    public class Almacen
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre del almacen")]
        [Display(Name = "Nombre de almacen")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripcion del almacen")]
        [Display(Name = "Descripcion de almacen")]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
