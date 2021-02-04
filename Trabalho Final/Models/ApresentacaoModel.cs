using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Final.Models
{
    public class Apresentacao
    {
        public int ApresentacaoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(10)]
        public string Nascimento { get; set; }

        [StringLength(115)]
        public string Morada { get; set; }

        [Required]
        [Display(Name = "Pequeno texto")]
        public string Texto { get; set; }

        public byte[] Foto { get; set; }
    }
}
