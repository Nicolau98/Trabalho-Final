using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Final.Models
{
    public class CartaConducao
    {
        public int CartaConducaoId { get; set; }

        [Required]
        [StringLength(2)]
        public string Tipo { get; set; }
    }
}
