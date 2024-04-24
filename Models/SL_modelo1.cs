﻿using System.ComponentModel.DataAnnotations;

namespace SebastianLargo_Examen1P.Models
{
    public class SL_modelo1
    {
        [Key]
        public int SLPerfilID {  get; set; }

        [Required]
        public int SLDecimal {  get; set; }

        [Required]
        public string SLNombre { get; set; }

        [Required]
        public bool SLCaracter {  get; set; }

        [Required]
        public DateTime Fecha {  get; set; }


        

    }
}
