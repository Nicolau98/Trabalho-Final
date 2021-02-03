using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Final.Models
{
    public class Educacao
    {
        public int EducacaoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(115)]
        public string Local { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Data de Início")]
        public string Data_Inicio { get; set; }

        [StringLength(10)]
        [Display(Name = "Data de Fim")]
        public string Data_Fim { get; set; }
    }
}
