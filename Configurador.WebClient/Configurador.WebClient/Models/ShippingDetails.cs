using System.ComponentModel.DataAnnotations;

namespace Configurador.WebClient.Models
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Por favor introduce tu nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor introduce tu dirección completa")]
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Direccion3 { get; set; }

        [Required(ErrorMessage = "Por favor introduce tu ciudad")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "Por favor introduce tu estado")]
        public string Provincia { get; set; }

        public string CP { get; set; }

        [Required(ErrorMessage = "Por favor introduce tu pais")]
        public string Pais { get; set; }

        public bool ParaRegalo { get; set; }
    }
}