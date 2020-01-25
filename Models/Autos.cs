using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_Sysne_NETCoreWebApp.Models
{
    public partial class Autos
    {

        public short IdAuto { get; set; }

        [Required(ErrorMessage = "X La matricula es requerida")]
        [StringLength(maximumLength:10,MinimumLength = 8,ErrorMessage = "X Verifique la matricula, tamaño requerido 9 caracteres")]
        [Display(Name = "Matricula")]
        public string MatriculaAuto { get; set; }

        [Required(ErrorMessage = "X El tipo de auto es requerido")]
        [Display(Name = "Tipo de auto")]
        public string TipoAuto { get; set; }

        [Required(ErrorMessage = "X El nombre del conductor es requerido")]
        [Display(Name = "Nombre del conductor")]
        public string NombreConductor { get; set; }
    }
}
