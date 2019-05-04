using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWeb2.Models.Almacen
{
    public class ActualizarViewModel
    {
        [Required]
        public int idcategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The name must have at least {2} and maximium {1} characteres")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }    
    }
}
