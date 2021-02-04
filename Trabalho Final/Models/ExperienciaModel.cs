using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Final.Models
{
    public class Experiencia
    {
        public int ExperienciaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Início")]
        public string Data_Inicio { get; set; }

        [StringLength(10)]
        [Display(Name = "Fim")]
        public string Data_Fim { get; set; }
    }
}
