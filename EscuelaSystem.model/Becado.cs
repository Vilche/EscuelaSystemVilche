using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EscuelaSystem.models
{
    public class Becado : EntityBase
    {
        public int hidden;

        [Required(ErrorMessage = "El campo Codigo de Becado no puede estar vacio")]
        [MinLength(2, ErrorMessage = "El campo Codigo de Becado debe tener minimo 2 caracteres")]
        [MaxLength(10, ErrorMessage = "El campo Codigo de Becado debe tener maximo 10 caracteres")]
        [Display(Name = "Codigo de Materia")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo Nombre del Becado no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El campo Nombre del Becado debe tener minimo 3 caracteres")]
        [MaxLength(25, ErrorMessage = "El campo Nombre del Becado debe tener maximo 25 caracteres")]
        [Display(Name = "Nombre del Becado")]
        public string Descripcion { get; set; }
        public bool Inscrito { get; set; }
    }
}
