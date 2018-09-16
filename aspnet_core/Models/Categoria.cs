using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace aspnet_core.Models
{
    public class Categoria

    {
        public int CategoriaID{get;set;}
        [Required(ErrorMessage ="campo requerido ")]
        [StringLength(50,MinimumLength =3,ErrorMessage =" el nombre debe tener un max de 50 carateres y minimo de 5 carateres")]
        
        public string Nombre { get; set; }
        [StringLength(256,ErrorMessage ="la descripcion no debe exceder los 256 caratres")]
        [Display(Name ="Descripcion")]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }

       

    }
}
