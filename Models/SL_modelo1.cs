using System.ComponentModel.DataAnnotations;

namespace SebastianLargo_Examen1P.Models
{
    public class SL_modelo1
    {
        [Key]
        public int SLPerfilID {  get; set; }

        [Required(ErrorMessage = "El campo solo debe contener letras")]
        public string? SLNombre { get; set; }

        [Required(ErrorMessage ="El caracter debe ser verdadero o falso")]
        public bool SLCaracter {  get; set; }
        
        [Required]
        public int SLDecimal {  get; set; }

        [Required]
        public DateTime Fecha {  get; set; }


        

    }
}
