using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoModeloDDD.MVC.ViewModels
{
    public class ProductoViewModels
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Agregar un nombre")]
        [MaxLength(250, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nombre { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","999999999999")]
        [Required(ErrorMessage = "Ingresa un valor")]
        public decimal Valor { get; set; }

        [DisplayName("Disponible?")]
        public bool Disponible { get; set; }

        public int ClienteId { get; set; }
        public virtual ClienteViewModels Cliente { get; set; }
    }
}