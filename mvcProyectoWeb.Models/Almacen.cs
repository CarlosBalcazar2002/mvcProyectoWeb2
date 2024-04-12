using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoWeb.Models
{
    public class Almacen
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese El Nombre De Almacen")]
        [Display(Name = "Nombre Del Almacen")]
        public string NombreAlmacen { get; set; }
        [Required(ErrorMessage = "La direccion es obligatoria")]
        public string Direccion { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name = "image")]
        public string ImageUrl { get; set; }
        [Display(Name = "Orden de Visualizacion")]
        [Range(1, 100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int Orden { get; set; }
    }
}
