using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Final.Models
{
    public class Lingua
    {
        public int LinguaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name = "Compreensão Oral")]
        public string Coral { get; set; }

        [Required]
        [StringLength(2)]
        public string Leitura { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name = "Produção Oral")]
        public string Poral { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name = "Interação Oral")]
        public string Ioral { get; set; }

        [Required]
        [StringLength(2)]
        public string Escrita { get; set; }
    }
}
