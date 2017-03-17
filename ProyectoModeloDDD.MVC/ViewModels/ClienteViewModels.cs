using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModels
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Agregar un nombre")]
        [MaxLength(150,ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2,ErrorMessage = "Minimo {0} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Agregar un Apellido")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Agregar el campo E-mail")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Agregar un E-mail valido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime FechaRegistro { get; set; }

        public bool Activo { get; set; }

        public virtual IEnumerable<ProductoViewModels> Productos { get; set; }
    }
}